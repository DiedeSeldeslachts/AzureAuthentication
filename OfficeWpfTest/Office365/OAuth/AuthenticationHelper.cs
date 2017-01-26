////----------------------------------------------------------------------------------------------
////    Copyright 2014 Microsoft Corporation
////
////    Licensed under the Apache License, Version 2.0 (the "License");
////    you may not use this file except in compliance with the License.
////    You may obtain a copy of the License at
////
////      http://www.apache.org/licenses/LICENSE-2.0
////
////    Unless required by applicable law or agreed to in writing, software
////    distributed under the License is distributed on an "AS IS" BASIS,
////    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
////    See the License for the specific language governing permissions and
////    limitations under the License.
////----------------------------------------------------------------------------------------------


//using Microsoft.IdentityModel.Clients.ActiveDirectory;
//using Newtonsoft.Json;
//using OfficeWpfTest;
//using OfficeWpfTest.Office365.OAuth.Models;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;


//namespace OfficeWpfTest.Office365.OAuth
//{
//    //public class OAuth2Helper
//    //{
//    //    public async Task<OAuth2Response> AuthenticateMe(AuthenticationSettings authenticateSettings)
//    //    {
//    //        OAuth2Response twitAuthResponse = null;

//    //        using (HttpClient client = new HttpClient())
//    //        {
//    //            var values = new Dictionary<string, string>
//    //            {
//    //                { "client_id", authenticateSettings.ClientId },
//    //                { "response_type", "code" },
//    //                { "redirect_uri", authenticateSettings.RedirectUri },
//    //                { "response_mode", "query" },
//    //                { "resource", authenticateSettings.Resource },
//    //                { "state", authenticateSettings.VerifyToken }

//    //            };

//    //            var content = new FormUrlEncodedContent(values);
//    //            string uri = authenticateSettings.Url + "?" + values.Aggregate(new StringBuilder(), (sb, kvp) => sb.AppendFormat("{0}={1}&", kvp.Key, kvp.Value), sb => sb.ToString());

//    //            //System.Diagnostics.Process.Start(uri);
//    //            var response = await client.GetAsync(uri);
//    //            //var response = await client.GetAsync(authenticateSettings.Url, content);

//    //            var responseString = await response.Content.ReadAsStringAsync();

//    //            twitAuthResponse = JsonConvert.DeserializeObject<OAuth2Response>(responseString);

//    //            return twitAuthResponse;
//    //        }




//    //        //// Do the Authenticate
//    //        //var authHeaderFormat = "Basic {0}";

//    //        //var authHeader = string.Format(authHeaderFormat,
//    //        //                               Convert.ToBase64String(
//    //        //                                   Encoding.UTF8.GetBytes(Uri.EscapeDataString(authenticateSettings.OAuthConsumerKey) + ":" +

//    //        //                                                          Uri.EscapeDataString((authenticateSettings.OAuthConsumerSecret)))

//    //        //                                   ));
//    //        //var postBody = "grant_type=client_credentials";
//    //        //HttpWebRequest authRequest = (HttpWebRequest)WebRequest.Create(authenticateSettings.OAuthUrl);

//    //        //authRequest.Headers.Add("Authorization", authHeader);
//    //        //authRequest.Method = "POST";
//    //        //authRequest.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
//    //        //authRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
//    //        //using (Stream stream = authRequest.GetRequestStream())
//    //        //{
//    //        //    byte[] content = ASCIIEncoding.ASCII.GetBytes(postBody);
//    //        //    stream.Write(content, 0, content.Length);
//    //        //}
//    //        //authRequest.Headers.Add("Accept-Encoding", "gzip");
//    //        //WebResponse authResponse = authRequest.GetResponse();
//    //        // deserialize into an object

//    //    }

//    //}
//    public class AuthenticationHelper
//    {
//        public static readonly string DiscoveryServiceResourceId = "https://api.office.com/discovery/";

//        static readonly string AuthorityFormat = App.Current.Resources["ida:AADInstance"] + "{0}";

//        public static readonly Uri DiscoveryServiceEndpointUri = new Uri("https://api.office.com/discovery/v1.0/me/");

//        static readonly string ClientId = App.Current.Resources["ida:ClientID"].ToString();


//        static string _authority = String.Empty;

//        static string _lastTenantId = App.Current.Resources["ida:Domain"].ToString();

//        const string _lastTenantIdKey = "LastAuthority";

//        static AuthenticationContext authContext = new AuthenticationContext(Authority);

//        public static Uri AppRedirectURI
//        {
//            get
//            {
//                return new Uri("");//WebAuthenticationBroker.GetCurrentApplicationCallbackUri();
//            }
//        }

//        public static string Authority
//        {
//            get
//            {
//                _authority = String.Format(AuthorityFormat, _lastTenantId);

//                return _authority;
//            }
//        }

//        public static async Task<AuthenticationResult> GetAccessToken(string serviceResourceId)
//        {
//            AuthenticationResult authResult = null;

//            var cache = authContext.TokenCache.ReadItems();
//            if (authContext.TokenCache.Count == 0)
//            {
//                #region To enable Windows Integrated Authentication (if you deploying your app in a corporate network)

//                // To enable Windows Integrated Authentication, in Package.appxmanifest, in the Capabilities tab, enable:
//                // * Enterprise Authentication
//                // * Private Networks (Client & Server)
//                // * Shared User Certificates
//                // Plus add the following line of code:
//                // 
//                //authContext.UseCorporateNetwork = true;

//                #endregion

//                authResult = await authContext.AcquireTokenAsync(serviceResourceId,.ClientId);
//            }
//            else
//            {
//                authResult = await authContext.AcquireTokenSilentAsync(serviceResourceId, ClientId);
//            }

//            _lastTenantId = authResult.TenantId;

//            if (authResult.Status != AuthenticationStatus.Success)
//            {
//                _lastTenantId = authResult.TenantId;


//            }

//            return authResult;
//        }
//        public static async Task Logout()
//        {
//            using (HttpClient client = new HttpClient())
//            {
//                var cachedUser = authContext.TokenCache.ReadItems().Where(t => t.TenantId == _lastTenantId).FirstOrDefault();
//                if (cachedUser != null)
//                {
//                    authContext.TokenCache.DeleteItem(cachedUser);
//                }
//                //Uri url = new Uri(String.Format("https://login.windows.net/{0}/oauth2/logout?post_logout_redirect_uri={1}", _lastTenantId, AppRedirectURI));
//                //var response = await client.GetAsync(url);
//            }
//        }

//    }
//}
