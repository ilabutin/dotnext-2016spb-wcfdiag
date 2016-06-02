using System;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;

namespace WCFClient
{
  public class AuthCredentials : ClientCredentialsElement
  {
    /// <summary>
    /// Type of behavior this class is representing.
    /// </summary>
    public override Type BehaviorType
    {
      get
      {
        return typeof(ClientCredentials);
      }
    }

    /// <summary>
    /// Creates behavior.
    /// </summary>
    protected override object CreateBehavior()
    {
      ClientCredentials credentials = (ClientCredentials)base.CreateBehavior();

      if (credentials == null)
      {
        return null;
      }

      credentials.UserName.UserName = CredentialStorage.UserName ?? string.Empty;

      ApplyConfiguration(credentials);

      return credentials;
    }
  }
}
