using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWpfTest.Office365.OAuth.Models
{
    public class OAuth2Response
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }

    public class OAuth1Response
    {
        [JsonProperty("oauth_token")]
        public string AccessToken { get; set; }
        [JsonProperty("oauth_token_secret")]
        public string AccessTokenSecret { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("screen_name")]
        public string UserName { get; set; }

    }
}
