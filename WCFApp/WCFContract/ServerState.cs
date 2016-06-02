using System;
using System.Runtime.Serialization;

namespace WCFContract
{
  public enum State
  {
    Running,
    Stopped
  }

  [DataContract]
  public class ServerState
  {
    [DataMember]
    public DateTime Time { get; set; }

    [DataMember]
    public State State { get; set; }

    public override string ToString()
    {
      return $"ServerState({State} at {Time})";
    }
  }
}
