using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using wireista.Models;

namespace wireista
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: System.Configuration.ConfigurationManager.AppSettings["FacebookAppId"],
                appSecret: System.Configuration.ConfigurationManager.AppSettings["FacebookAppSecret"]);
                //appId: "151733318319423",
                //appSecret: "e0fd1eafb98a9b5d8c622e1303fc76be");

            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
