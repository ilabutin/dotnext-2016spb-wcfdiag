using System;
using System.ServiceModel;
using System.Threading;

namespace WCFServer.InternalService
{
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
  public class InternalService : IInternalContract
  {
    public void DoSomething()
    {
      Console.WriteLine("Internal service did something");
    }
  }
}
