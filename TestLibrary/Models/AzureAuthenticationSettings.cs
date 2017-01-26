using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.Models
{
    public class AzureAuthenticationSettings
    {
        public string ClientId { get; set; }
        public string Tenant { get; set; }
        public Uri RedirectUri { get; set; }
        public string Url { get; set; }
        public string Resource { get; set; }
        public IPlatformParameters PlatformParameters { get; set; }
    }
}
