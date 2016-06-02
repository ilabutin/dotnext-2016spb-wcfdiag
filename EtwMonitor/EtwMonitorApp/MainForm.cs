using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WcfEtwMonitor;

namespace EtwMonitor
{
  public partial class MainForm : Form
  {
    private ProcessInfo process;
    private WcfMonitor monitor;

    public MainForm()
    {
      InitializeComponent();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      StopMonitoring();
      this.Close();
    }

    private void chooseProcessButton_Click(object sender, EventArgs e)
    {
      var processChooseDialog = new ProcessChooseDialog();
      processChooseDialog.ShowDialog();
      process = processChooseDialog.SelectedProcess;
      processNameTextBox.Text = process.Name;
      startStopButton.Enabled = true;
      startStopButton.BackColor = System.Drawing.Color.LightGreen;
    }

    private void startStopButton_Click(object sender, EventArgs e)
    {
      if (monitor == null)
      {
        StartMonitoring();
        startStopButton.Text = "Stop";
        startStopButton.BackColor = System.Drawing.Color.LightPink;
      }
      else
      {
        StopMonitoring();
        startStopButton.Text = "Start";
        startStopButton.BackColor = System.Drawing.Color.LightGreen;
      }
    }

    private void StartMonitoring()
    {
      monitor = new WcfMonitor(process.ProcessId, OnOperationsUpdated);
      monitor.Start();
    }

    private void OnOperationsUpdated(IReadOnlyList<OperationData> ops)
    {
      if (monitor == null)
      {
        return;
      }
      var shownOps = new Dictionary<string, DataGridViewRow>();
      var rowsToRemove = new List<int>();
      for (int i = 0; i < operationsGrid.Rows.Count; i++)
      {
        string action = (string)operationsGrid.Rows[i].Tag;
        OperationData op = ops.FirstOrDefault(x => x.Name == action);
        if (op != null)
        {
          shownOps.Add(action, operationsGrid.Rows[i]);
        }
        else
        {
          rowsToRemove.Add(i);
        }
      }

      rowsToRemove.Reverse();
      foreach (int index in rowsToRemove)
      {
        operationsGrid.Rows.RemoveAt(index);
      }

      // Now we may have some rows to add or update
      foreach (var op in ops)
      {
        if (shownOps.ContainsKey(op.Name))
        {
          // Just update
          UpdateGridRow(op, shownOps[op.Name]);
        }
        else
        {
          var newRow = (DataGridViewRow)operationsGrid.RowTemplate.Clone();
          UpdateGridRow(op, newRow);
          operationsGrid.Rows.Add(newRow);
        }
      }

      operationsGrid.ClearSelection();
    }

    private void UpdateGridRow(OperationData op, DataGridViewRow gridRow)
    {
      gridRow.Tag = op.Name;
      if (gridRow.Cells.Count == 0)
      {
        for (int i = 0; i < 5; i++)
        {
          gridRow.Cells.Add(new DataGridViewTextBoxCell());
        }
      }
      gridRow.Cells[0].Value = op.Name;
      gridRow.Cells[1].Value = op.Calls;
      gridRow.Cells[2].Value = op.Duration.TotalSeconds.ToString("N3");
      gridRow.Cells[3].Value = op.SentBytes.ToString("N0");
      gridRow.Cells[4].Value = op.ReceivedBytes.ToString("N0");
    }

    private void StopMonitoring()
    {
      if (monitor != null)
      {
        monitor.Dispose();
        monitor = null;
      }
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
      if (monitor != null)
      {
        monitor.Reset();
      }
    }
  }
}
