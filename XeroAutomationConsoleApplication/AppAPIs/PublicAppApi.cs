using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xero.Api;
using Xero.Api.Core.Model;
using Xero.Api.Core;
using Xero.Api.Common;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Example.Applications.Public;
using Xero.Api.Example.TokenStores;
using Xero.Api.Payroll;
using Xero.Api.Serialization;
using XeroAutomationConsoleApplication.Utils;

namespace XeroAutomationConsoleApplication.AppAPIs
{
    public class PublicAppApi
    {
        string ConsumerKey = Properties.Settings.Default.ConsumerKey;
        string ConsumerSecret = Properties.Settings.Default.ConsumerSecret;
        string OAuthCallbackDomain = Properties.Settings.Default.OAuthCallbackDomain;
        string RequestTokenURL = Properties.Settings.Default.RequestTokenURL;
        string AuthoriseURL = Properties.Settings.Default.AuthoriseURL;
        string AccessTokenURL = Properties.Settings.Default.AccessTokenURL;
        string baseURL = "https://api.xero.com";
        public MemoryTokenStore tokenStore;
        public AutoPublicAuthenticator auth;
        public Consumer consumer;
        public DefaultMapper readMapper;
        public DefaultMapper writeMapper;
        public ApiUser user;
        public XeroCoreApi public_app_api;
        public Organisation org;



        public PublicAppApi()
        {
            //this.public_app_api = Create_PublicAppAPI();
            //this.org = Create_PublicAppAPI_Organisation(this.public_app_api);
        }

        public XeroCoreApi Create_PublicAppAPI()
        {
            tokenStore = new MemoryTokenStore();
            auth = new AutoPublicAuthenticator(baseURL, baseURL, OAuthCallbackDomain, tokenStore);
            consumer = new Consumer(ConsumerKey, ConsumerSecret);
            readMapper = new DefaultMapper();
            writeMapper = new DefaultMapper();
            user = new ApiUser { Name = Environment.MachineName };
            public_app_api = new XeroCoreApi(baseURL, auth, consumer, user, readMapper, writeMapper);
            return public_app_api;
        }

        public Organisation Create_PublicAppAPI_Organisation(XeroCoreApi api)
        {
            org = api.Organisation;
            return org;
        }

    }
}
