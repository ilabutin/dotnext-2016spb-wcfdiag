using System;
using System.Text;
using System.Windows.Forms;
using WCFContract;

namespace WCFClient
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void getStateButton_Click(object sender, EventArgs e)
    {
      CredentialStorage.UserName = "validUser";
      try
      {
        stateTextBox.Text = string.Empty;
        int totalSize = 0;

        for (int size = 4096; size <= 512*1024; size *= 2)
        {
          for (int i = 0; i < 20; i++)
          {
            using (ServiceProxy proxy = new ServiceProxy())
            {
              byte[] largeBuffer = new byte[size];
              proxy.SendLargeBuffer(largeBuffer);
              ServerState state = proxy.GetServerState();

              totalSize += size;
              stateTextBox.Text = state.ToString();
              runningRadioButton.Checked = state.State == State.Running;
              stoppedRadioButton.Checked = state.State == State.Stopped;
            }
          }
        }
        stateTextBox.Text = stateTextBox.Text + Environment.NewLine +
                            $"Total sent bytes: {totalSize}";
      }
      catch (Exception exception)
      {
        PrintException(exception);
      }
    }

    private void setButton_Click(object sender, EventArgs e)
    {
      try
      {
        CredentialStorage.UserName = "validUser";
        stateTextBox.Text = string.Empty;

        using (ServiceProxy proxy = new ServiceProxy())
        {
          proxy.SetServerState(runningRadioButton.Checked ? State.Running : State.Stopped);
          stateTextBox.Text = "Done";
        }
      }
      catch (Exception exception)
      {
        PrintException(exception);
      }
    }

    private void PrintException(Exception exception)
    {
        StringBuilder sb = new StringBuilder();
        while (exception.InnerException != null)
        {
            sb.AppendFormat("{0}:{1}", exception.GetType().Name, Environment.NewLine);
            exception = exception.InnerException;
        }
        sb.AppendLine("Message:");
        sb.AppendLine(exception.Message);
        stateTextBox.Text = sb.ToString();
    }
  }
}
