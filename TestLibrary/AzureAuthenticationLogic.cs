using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestLibrary.Models;

namespace TestLibrary
{
    public class AzureAuthenticationLogic : IAzureAuthenticationLogic
    {
        private readonly AzureAuthenticationSettings _settings;
        private AuthenticationContext _authContext;

        public AzureAuthenticationLogic(AzureAuthenticationSettings settings)
        {
            _settings = settings;
            _authContext = new AuthenticationContext(Authority);
        }

        public AzureAuthenticationLogic(AzureAuthenticationSettings settings, TokenCache tokenCache)
        {
            _settings = settings;
            _authContext = new AuthenticationContext(Authority, true, tokenCache);
        }

        private string _lastTenantId;

        private string Authority
        {
            get
            {
                return _settings.Url + _settings.Tenant;
            }
        }

        public async Task<AuthenticationResult> Login()
        {
            AuthenticationResult authResult = null;
            #region To enable Windows Integrated Authentication (if you deploying your app in a corporate network)

            // To enable Windows Integrated Authentication, in Package.appxmanifest, in the Capabilities tab, enable:
            // * Enterprise Authentication
            // * Private Networks (Client & Server)
            // * Shared User Certificates
            // Plus add the following line of code:
            // 
            //authContext.UseCorporateNetwork = true;

            #endregion

            authResult = await _authContext.AcquireTokenAsync(_settings.Resource, _settings.ClientId, _settings.RedirectUri, _settings.PlatformParameters);

            _lastTenantId = authResult.TenantId;

            return authResult;
        }

        public async Task<AuthenticationResult> GetAccessToken()
        {
            AuthenticationResult authResult = null;

            var cache = _authContext.TokenCache.ReadItems();

            try
            {
                authResult = await _authContext.AcquireTokenSilentAsync(_settings.Resource, _settings.ClientId);
            }
            catch (AdalException)
            {
                authResult = await _authContext.AcquireTokenAsync(_settings.Resource, _settings.ClientId, _settings.RedirectUri, _settings.PlatformParameters);
            }

            _lastTenantId = authResult.TenantId;

            return authResult;
        }

        public void Logout()
        {
            using (HttpClient client = new HttpClient())
            {
                var cachedUser = _authContext.TokenCache.ReadItems().Where(t => t.TenantId == _lastTenantId).FirstOrDefault();
                if (cachedUser != null)
                {
                    _authContext.TokenCache.DeleteItem(cachedUser);
                }
            }
        }
    }
}
