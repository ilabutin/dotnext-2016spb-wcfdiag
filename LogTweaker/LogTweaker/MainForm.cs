using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EtwMonitor
{
  public partial class MainForm : Form
  {
    private WcfServiceProcess process;

    public MainForm()
    {
      InitializeComponent();

      serviceModelTraceLevel.Items.AddRange(Enum.GetNames(typeof(WcfTraceLevel)));
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void chooseProcessButton_Click(object sender, EventArgs e)
    {
      var processChooseDialog = new ProcessChooseDialog();
      processChooseDialog.ShowDialog();
      process = processChooseDialog.SelectedProcess;
      if (process == null)
      {
        return;
      }
      processNameTextBox.Text = process.Name;
      RefreshGrid();
    }

    private void RefreshGrid()
    {
      appDomainsGrid.Rows.Clear();
      foreach (WcfServiceAppDomain appDomain in process.Services.OrderBy(x => x.Name))
      {
        var newRow = (DataGridViewRow)appDomainsGrid.RowTemplate.Clone();
        UpdateGridRow(appDomain, newRow);
        appDomainsGrid.Rows.Add(newRow);
      }
    }

    private void UpdateGridRow(WcfServiceAppDomain appDomain, DataGridViewRow gridRow)
    {
      gridRow.Tag = appDomain;
      if (gridRow.Cells.Count == 0)
      {
        for (int i = 0; i < 4; i++)
        {
          gridRow.Cells.Add(new DataGridViewTextBoxCell());
        }
      }
      gridRow.Cells[0].Value = appDomain.Name;
      gridRow.Cells[1].Value = appDomain.LogMessageAtServiceLevel;
      gridRow.Cells[2].Value = appDomain.TraceLevel;
      gridRow.Cells[3].Value = appDomain.ActivityTracing;
    }

    private IEnumerable<WcfServiceAppDomain> SelectedAppDomains
    {
      get
      {
        return appDomainsGrid.SelectedRows
          .Cast<DataGridViewRow>()
          .Select(x => (WcfServiceAppDomain)x.Tag);
      }
    }

    private void appDomainsGrid_SelectionChanged(object sender, EventArgs e)
    {
      WcfServiceAppDomain[] serviceAppDomains =
        SelectedAppDomains.ToArray();
      if (serviceAppDomains.Length == 0)
      {
        appDomainConfigurationGroupBox.Enabled = false;
        return;
      }

      appDomainConfigurationGroupBox.Enabled = true;

      logMessagesAtServiceLevelBox.CheckState =
        serviceAppDomains.All(x => x.LogMessageAtServiceLevel)
          ? CheckState.Checked
          : serviceAppDomains.All(x => !x.LogMessageAtServiceLevel)
            ? CheckState.Unchecked
            : CheckState.Indeterminate;
      activityTracingCheckbox.CheckState =
        serviceAppDomains.All(x => x.ActivityTracing)
          ? CheckState.Checked
          : serviceAppDomains.All(x => !x.ActivityTracing)
            ? CheckState.Unchecked
            : CheckState.Indeterminate;

      WcfTraceLevel[] traceLevels =
        serviceAppDomains.Select(x => x.TraceLevel).Distinct().ToArray();
      serviceModelTraceLevel.SelectedItem =
        traceLevels.Length == 1 ? traceLevels[0].ToString() : null;

      serviceModelTraceLevel.Invalidate();
      serviceModelTraceLevel.Update();
    }

    private void applyButton_Click(object sender, EventArgs e)
    {
      WcfServiceAppDomain[] appDomains = SelectedAppDomains.ToArray();
      if (appDomains.Length == 0)
      {
        return;
      }

      string serviceModelTraceLevelValue =
        (string)serviceModelTraceLevel.SelectedItem;
      if (serviceModelTraceLevelValue == null)
      {
        return;
      }
      if (logMessagesAtServiceLevelBox.CheckState == CheckState.Indeterminate)
      {
        return;
      }
      if (activityTracingCheckbox.CheckState == CheckState.Indeterminate)
      {
        return;
      }

      if (activityTracingCheckbox.Checked)
      {
        serviceModelTraceLevelValue += ", ActivityTracing";
      }
      var newConfiguration = new InstanceConfiguration
      {
        LogMessageAtServiceLevel = logMessagesAtServiceLevelBox.Checked,
        ServiceModelTraceLevel = serviceModelTraceLevelValue
      };

      foreach (var appDomain in appDomains)
      {
        appDomain.ApplyConfiguration(newConfiguration);
      }

      RefreshGrid();
    }
  }
}
