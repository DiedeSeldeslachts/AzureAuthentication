using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWpfTest.Office365.OAuth.Models
{
    public class AuthenticationSettings
    {
        public string ClientId { get; set; }
        public string RedirectUri { get; set; }
        public string Url { get; set; }
        public string Resource { get; set; }
        public string VerifyToken { get; set; }

    }
}
