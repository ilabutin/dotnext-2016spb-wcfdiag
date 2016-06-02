using System;
using System.ServiceModel;

namespace WCFServer.InternalService
{
  public class InternalProxy : ClientBase<IInternalContract>, IInternalContract, IDisposable
  {
    public void DoSomething()
    {
      Channel.DoSomething();
    }

    public void Dispose()
    {
      try
      {
        if (State == CommunicationState.Faulted)
        {
          Abort();
        }
        else
        {
          Close();
        }
      }
      catch (Exception)
      {
      }
    }

  }
}
