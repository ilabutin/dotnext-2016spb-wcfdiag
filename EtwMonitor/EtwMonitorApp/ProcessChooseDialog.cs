using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace EtwMonitor
{
  public partial class ProcessChooseDialog : Form
  {
    private List<ProcessInfo> processes = new List<ProcessInfo>();

    public ProcessInfo SelectedProcess { get; set; }

    public ProcessChooseDialog()
    {
      InitializeComponent();
    }

    private List<ProcessInfo> GetProcessList()
    {
      var connection = new ConnectionOptions { Authentication = AuthenticationLevel.PacketPrivacy };

      // Get list of processes
      ManagementScope scope = new ManagementScope(@"\\localhost\root\CIMV2", connection);
      scope.Connect();

      ObjectQuery processQuery = new ObjectQuery("SELECT * FROM Win32_Process");
      ManagementObjectSearcher processSearcher = new ManagementObjectSearcher(scope, processQuery);

      var infoList = new List<ProcessInfo>();
      try
      {
        foreach (ManagementObject p in processSearcher.Get())
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

    private void ProcessChooseDialog_Load(object sender, EventArgs e)
    {
      var allProcesses = GetProcessList();

      processes = allProcesses
        .Where(x => WcfEtwMonitor.WcfMonitor.ProcessCanBeMonitored(x.ProcessId))
        .OrderBy(x => x.Name).ToList();
      foreach (var p in processes)
      {
        processList.Items.Add(p.Name);
      }

      processList.SelectedIndex = 0;
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
