using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace EtwMonitor
{
  public partial class ProcessChooseDialog : Form
  {
    private List<WcfServiceProcess> processes = new List<WcfServiceProcess>();

    public WcfServiceProcess SelectedProcess { get; set; }

    public ProcessChooseDialog()
    {
      InitializeComponent();
    }

    private List<ProcessInfo> GetProcessList()
    {
      var connection = new ConnectionOptions { Authentication = AuthenticationLevel.PacketPrivacy };

      var scope = new ManagementScope(@"\\localhost\root\CIMV2", connection);
      scope.Connect();

      var processQuery = new ObjectQuery("SELECT * FROM Win32_Process");
      var processSearcher = new ManagementObjectSearcher(scope, processQuery);

      var infoList = new List<ProcessInfo>();
      try
      {
        foreach (var p in processSearcher.Get())
        {
          try
          {
            PropertyData pidProp = p.Properties["ProcessId"];
            PropertyData pathProp = p.Properties["ExecutablePath"];

            if (pidProp.Value != null && pathProp.Value != null)
            {
              infoList.Add(
                new ProcessInfo
                {
                  ProcessId = (int)(uint)pidProp.Value,
                  Path = (string)pathProp.Value,
                  Name = System.IO.Path.GetFileName((string)pathProp.Value)
                });
            }
          }
          catch (Exception)
          {
          }
        }
      }
      catch (ManagementException)
      {
      }

      return infoList;
    }

    private List<WcfServiceProcess> GetWcfServiceProcesses(
        IReadOnlyList<ProcessInfo> processInfo)
    {
      var connection = new ConnectionOptions
      {
        Authentication = AuthenticationLevel.PacketPrivacy
      };

      const string wcfNamespace = @"\\localhost\Root\ServiceModel";

      var scope = new ManagementScope(wcfNamespace, connection);
      scope.Connect();

      var oQuery = new ObjectQuery("SELECT * FROM AppDomainInfo");
      var searcher = new ManagementObjectSearcher(scope, oQuery);

      var listOfProcesses = new List<WcfServiceProcess>();
      try
      {
        foreach (ManagementObject mo in searcher.Get())
        {
          int pid = (int)mo["ProcessId"];

          var serviceProcess =
            listOfProcesses.FirstOrDefault(x => x.Process.ProcessId == pid);
          if (serviceProcess == null)
          {
            serviceProcess = new WcfServiceProcess
            {
              Process = processInfo.First(x => x.ProcessId == pid)
            };
            listOfProcesses.Add(serviceProcess);
          }

          var instance = new WcfServiceAppDomain(mo);
          serviceProcess.Services.Add(instance);
        }
      }
      catch (ManagementException)
      {
      }
      return listOfProcesses;
    }

    private void ProcessChooseDialog_Load(object sender, EventArgs e)
    {
      var allProcesses = GetProcessList();
      processes =
        GetWcfServiceProcesses(allProcesses).OrderBy(x => x.Name).ToList();

      foreach (var p in processes)
      {
        processList.Items.Add(p.Name);
      }

      if (processes.Any())
      {
        processList.SelectedIndex = 0;
      }
    }

    private void selectButton_Click(object sender, EventArgs e)
    {
      SelectedProcess = processes[processList.SelectedIndex];
      this.Close();
    }

    private void ProcessChooseDialog_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      SelectedProcess = processes[processList.SelectedIndex];
      this.Close();
    }
  }

  public class ProcessInfo
  {
    public int ProcessId { get; set; }

    public string Path { get; set; }

    public string Name { get; set; }
  }
}
