using System;
using System.Collections.Generic;
using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Etlx;
using Microsoft.Diagnostics.Tracing.Stacks;
using PerfViewExtensibility;

public class Commands : CommandEnvironment
{
  public void OpenWcfEventsView(string etlFileName, string viewName)
  {
    ETLDataFile etlFile = OpenETLFile(etlFileName);
    TraceLog traceLog = etlFile.TraceLog;

    var eventSource = traceLog.Events.GetSource();
    var stackSource = new InternStackSource();
    StackSourceModuleIndex emptyModuleIdx = stackSource.Interner.ModuleIntern("");

    var mySample = new StackSourceSample(stackSource);

    var operations = new List<OperationData>();
    var opStartTimeStamps = new Dictionary<int, double>();
    var pendingOps = new Dictionary<int, OperationData>();
    eventSource.Dynamic.All += x => OnNewEvent(operations, opStartTimeStamps, pendingOps, x);
    eventSource.Process();

    foreach (var op in operations)
    {
      mySample.TimeRelativeMSec = op.TimeStamp;
      mySample.Metric = (float)op.Duration.TotalMilliseconds;
      mySample.StackIndex =
          stackSource.Interner.CallStackIntern(
              stackSource.Interner.FrameIntern(op.Contract, emptyModuleIdx), StackSourceCallStackIndex.Invalid);
      mySample.StackIndex =
          stackSource.Interner.CallStackIntern(
              stackSource.Interner.FrameIntern(op.Name, emptyModuleIdx), mySample.StackIndex);

      stackSource.AddSample(mySample);
    }

    Stacks stacksForViewer = new Stacks(stackSource, viewName, etlFile);
    OpenStackViewer(stacksForViewer);
  }

  private void OnNewEvent(
    List<OperationData> operations,
    Dictionary<int, double> opStartTimeStamps,
    Dictionary<int, OperationData> pendingOps,
    TraceEvent data)
  {
    if (data.EventName == "ServiceChannelCall/Start")
    {
      opStartTimeStamps[data.ThreadID] = data.TimeStampRelativeMSec;
    }
    if (data.EventName == "ClientRuntime/OperationPrepared")
    {
      string action = (string)data.PayloadByName("Action");
      string contractName = (string)data.PayloadByName("ContractName");

      action = action.Substring(action.IndexOf(contractName) + contractName.Length + 1);

      var op = new OperationData
      {
        Name = action,
        Contract = contractName,
        TimeStamp = data.TimeStampRelativeMSec
      };

      pendingOps[data.ThreadID] = op;
    }
    if (data.EventName == "ServiceChannelCall/Stop")
    {
      // Find pending OP by thred ID
      OperationData op;
      if (!pendingOps.TryGetValue(data.ThreadID, out op))
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

      operations.Add(op);
      pendingOps.Remove(data.ThreadID);
      opStartTimeStamps.Remove(data.ThreadID);
    }
  }

}
