using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace TestLibrary
{
    public interface IAzureAuthenticationLogic
    {
        Task<AuthenticationResult> GetAccessToken();
        Task<AuthenticationResult> Login();
        void Logout();
    }
}