using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;

namespace EtwMonitor
{
  public enum WcfTraceLevel
  {
    Off,
    Error,
    Warning,
    Information,
    Verbose,
  }

  public class InstanceConfiguration
  {
    public string ServiceModelTraceLevel { get; set; }
    public bool LogMessageAtServiceLevel { get; set; }

    public static InstanceConfiguration ReadFromWmi(ManagementObject mo)
    {
      var newConfiguration = new InstanceConfiguration
      {
        ServiceModelTraceLevel = (string)mo["TraceLevel"],
        LogMessageAtServiceLevel = (bool)mo["LogMessagesAtServiceLevel"]
      };
      return newConfiguration;
    }

    public override string ToString()
    {
      return string.Format("ServiceModelTrace={0},LogMsgAtServiceLevel={1}", ServiceModelTraceLevel,
        LogMessageAtServiceLevel);
    }

  }

  public class WcfServiceProcess
  {
    public ProcessInfo Process { get; set; }
    public List<WcfServiceAppDomain> Services { get; } = new List<WcfServiceAppDomain>();
    public string Name => Process.Name;
  }

  public class WcfServiceAppDomain
  {
    public string Name { get; }
    public ManagementObject ManagementObject { get; }
    public InstanceConfiguration Configuration { get; private set; }
    public bool LogMessageAtServiceLevel => Configuration.LogMessageAtServiceLevel;

    public WcfTraceLevel TraceLevel
    {
      get
      {
        string serviceModelTraceLevelValue = Configuration.ServiceModelTraceLevel;
        if (serviceModelTraceLevelValue == "All")
        {
          return WcfTraceLevel.Verbose;
        }

        return Enum.GetValues(typeof(WcfTraceLevel))
          .Cast<WcfTraceLevel>()
          .LastOrDefault(x => serviceModelTraceLevelValue.Contains(x.ToString()));
      }
    }

    public bool ActivityTracing
    {
      get
      {
        return Configuration.ServiceModelTraceLevel == "All" ||
               Configuration.ServiceModelTraceLevel.Contains("ActivityTracing");
      }
    }

    public WcfServiceAppDomain(ManagementObject mo)
    {
      ManagementObject = mo;
      Name = (string)mo["Name"];
      Configuration = InstanceConfiguration.ReadFromWmi(mo);
    }

    public void ApplyConfiguration(InstanceConfiguration configuration)
    {
      ManagementObject.SetPropertyValue("LogMessagesAtServiceLevel", configuration.LogMessageAtServiceLevel);
      ManagementObject.SetPropertyValue("TraceLevel", configuration.ServiceModelTraceLevel);
      ManagementObject.Put();
      Configuration = InstanceConfiguration.ReadFromWmi(ManagementObject);
    }
  }
}
