using System;
using System.ServiceModel;
using WCFContract;
using WCFServer.InternalService;

namespace WCFServer
{
  [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
  class Service : IService
  {
    public void SetServerState(State newState)
    {
      using (InternalProxy p = new InternalProxy())
      {
        p.DoSomething();
      }
      Console.WriteLine("Setting server state to {0}", newState);
      GlobalServerState.CurrentState = newState;
    }

    public ServerState GetServerState()
    {
      ServerState state = new ServerState
      {
        State = GlobalServerState.CurrentState,
        Time = DateTime.Now
      };

      InternalProxy p = new InternalProxy();
      p.DoSomething();

      Console.WriteLine("Returning {0}", state);
      return state;
    }

    public void SendLargeBuffer(byte[] buffer)
    {
      using (InternalProxy p = new InternalProxy())
      {
        p.DoSomething();
      }

      Console.WriteLine("Received buffer[{0}]", buffer.Length);
    }
  }
}
