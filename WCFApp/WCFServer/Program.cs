using System;
using System.ServiceModel;
using WCFContract;
using WCFServer.InternalService;

namespace WCFServer
{
  class Program
  {
    static void Main(string[] args)
    {
      using (ServiceHost host = new ServiceHost(typeof(Service)))
      using (ServiceHost internalHost = new ServiceHost(typeof (InternalService.InternalService)))
      {
        ClientBase<IInternalContract>.CacheSetting = CacheSetting.AlwaysOff;

        //internalHost.Open();
        GlobalServerState.CurrentState = State.Stopped;
        host.Open();

        Console.WriteLine("Service started");
        Console.ReadLine();
      }
    }
  }
}
