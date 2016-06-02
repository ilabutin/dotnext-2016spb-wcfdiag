using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace WCFServer
{
  public class CustomUserNamePasswordValidator : UserNamePasswordValidator
  {
    public override void Validate(string userName, string password)
    {
      if (userName != "validUser")
      {
        throw new FaultException("You should guess valid user name better!");
      }
    }
  }
}
