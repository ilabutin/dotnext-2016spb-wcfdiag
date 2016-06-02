using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Session;

namespace WcfEtwMonitor
{
  public class WcfMonitor : IDisposable
  {
    private class OperationDataExtended : OperationData
    {
      public Guid LastActivityID;
    }
    private static readonly Guid WcfProviderGuid = new Guid("c651f5f6-1c0d-492e-8ae1-b4efd7c9d503");
    private int currentProcessId;
    private Action<IReadOnlyList<OperationData>> onOperationsUpdated;
    private TraceEventSession session;
    private Dictionary<int, OperationDataExtended> pendingReceiveOps = new Dictionary<int, OperationDataExtended>();
    private Dictionary<int, double> opStartTimeStamps = new Dictionary<int, double>();
    private List<OperationDataExtended> operations = new List<OperationDataExtended>();
    private SynchronizationContext originalContext;

    public bool IsRunning => session != null;

    public static bool ProcessCanBeMonitored(int processId)
    {
      return TraceEventProviders
        .GetRegisteredProvidersInProcess(processId)
        .Contains(WcfProviderGuid);
    }

    public WcfMonitor(int processId, Action<IReadOnlyList<OperationData>> operationsUpdated)
    {
      currentProcessId = processId;
      onOperationsUpdated = operationsUpdated;
      originalContext = SynchronizationContext.Current;
    }

    public WcfMonitor(Action<IReadOnlyList<OperationData>> operationsUpdated)
      : this(System.Diagnostics.Process.GetCurrentProcess().Id, operationsUpdated)
    {
    }

    public void Start()
    {
      operations.Clear();
      opStartTimeStamps.Clear();
      pendingReceiveOps.Clear();

      session = new TraceEventSession("WCFMonitorSession");
      session.Source.Dynamic.All +=
        data => { if (data.ProcessID == currentProcessId) { OnNewEvent(data); } };

      session.EnableProvider(WcfProviderGuid);
      Task.Run(() => session.Source.Process());
      Notify();
    }

    public void Stop()
    {
      if (session == null)
      {
        return;
      }
      session.Dispose();
      session = null;
    }

    public void Reset()
    {
      foreach (var op in operations)
      {
        op.Reset();
      }
      Notify();
    }

    public IReadOnlyList<OperationData> GetOperations()
    {
      return operations.ToList().AsReadOnly();
    }

    public void Dispose()
    {
      Stop();
    }

    private void OnNewEvent(TraceEvent data)
    {
      if (data.EventName == "ServiceChannelCall/Start")
      {
        opStartTimeStamps[data.ThreadID] = data.TimeStampRelativeMSec;
      }
      if (data.EventName == "ClientRuntime/OperationPrepared")
      {
        string action = (string)data.PayloadByName("Action");
        string contractName = (string)data.PayloadByName("ContractName");

        action = action.Substring(action.IndexOf(contractName));

        var op = operations.FirstOrDefault(x => x.Name == action);
        if (op == null)
        {

          op = new OperationDataExtended
          {
            Name = action
          };
          operations.Add(op);
        }

        op.LastActivityID = data.ActivityID;
      }
      if (data.EventName == "MessageEncoding/Stop")
      {
        var op = operations.FirstOrDefault(x => x.LastActivityID == data.ActivityID);
        if (op == null)
        {
          return;
        }
        int size = (int)data.PayloadByName("Size");
        op.SentBytes += size;
      }
      if (data.EventName == "MessageDecoding/Start")
      {
        var op = operations.FirstOrDefault(x => x.LastActivityID == data.ActivityID);
        if (op == null)
        {
          return;
        }
        // Remember thread ID
        pendingReceiveOps[data.ThreadID] = op;
      }
      if (data.EventName == "MessageDecoding/Stop")
      {
        // Find pending OP by thred ID
        OperationDataExtended op;
        if (!pendingReceiveOps.TryGetValue(data.ThreadID, out op))
        {
          return;
        }
        int size = (int)data.PayloadByName("Size");
        op.ReceivedBytes += size;
      }
      if (data.EventName == "ServiceChannelCall/Stop")
      {
        // Find pending OP by thred ID
        OperationDataExtended op;
        if (!pendingReceiveOps.TryGetValue(data.ThreadID, out op))
        {
          return;
        }

        // Find start time by thread ID
        double startTime;
        if (!opStartTimeStamps.TryGetValue(data.ThreadID, out startTime))
        {
          return;
        }

        double duration = data.TimeStampRelativeMSec - startTime;
        op.Duration += TimeSpan.FromMilliseconds(duration);
        op.Calls++;

        Notify();
      }
    }

    private void Notify()
    {
      if (onOperationsUpdated == null)
      {
        return;
      }
      var ops = GetOperations();
      if (originalContext != null)
      {
        originalContext.Post(x => onOperationsUpdated(ops), null);
      }
      else
      {
        onOperationsUpdated(ops);
      }
    }
  }
}
