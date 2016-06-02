using System.ServiceModel;

namespace WCFServer.InternalService
{
  [ServiceContract]
  public interface IInternalContract
  {
    [OperationContract]
    void DoSomething();
  }
}
