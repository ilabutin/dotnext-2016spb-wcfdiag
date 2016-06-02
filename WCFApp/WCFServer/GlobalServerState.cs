using WCFContract;

namespace WCFServer
{
  public static class GlobalServerState
  {
    public static State CurrentState { get; set; }
  }
}