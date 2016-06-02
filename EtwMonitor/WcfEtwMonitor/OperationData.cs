using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfEtwMonitor
{
  public class OperationData
  {
    public string Name;
    public int Calls;
    public long SentBytes;
    public long ReceivedBytes;
    public TimeSpan Duration;

    internal void Reset()
    {
      Calls = 0;
      SentBytes = 0;
      ReceivedBytes = 0;
      Duration = TimeSpan.Zero;
    }
  }
}
