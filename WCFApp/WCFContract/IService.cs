using System.ServiceModel;

namespace WCFContract
{
  [ServiceContract]
  public interface IService
  {
    [OperationContract]
    void SetServerState(State newState);

    [OperationContract]
    ServerState GetServerState();

    [OperationContract]
    void SendLargeBuffer(byte[] buffer);
  }
}
