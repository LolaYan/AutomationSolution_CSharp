using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xero.Api;
using Xero.Api.Core.Model;
using Xero.Api.Core;
using Xero.Api.Common;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Example.Applications.Public;
using Xero.Api.Example.TokenStores;
using Xero.Api.Payroll;
using Xero.Api.Serialization;
using XeroEndpointsAPIAutomation.OAuthUtils;

namespace XeroEndpointsAPIAutomation.Tests
{
    /// <summary>
    ///  BaseTest Class, which will be extended by EndpointsAPITest.
    ///  Using UnitTesting Attributes
    ///  Feature 1: Initialization of public XeroCoreApi object.
    ///  Note 1: All the authorisation url and xero app credentials are configured in Project.Properties.Settins.
    /// </summary>
    /// <author>Lola Yan</author>
    /// <author>LolaYan@outlook.com</author>
    ///

    [TestClass]
    public class EndpointBaseTest
    {
        public XeroCoreApi public_app_api;
        public Organisation org;
        public EndpointBaseTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;         

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        #endregion

        //[TestInitialize] is run before each test. Likewise [TestCleanup] is after each test.
        //[ClassInitialize] and [ClassCleanup] are run before and after the 'suite' of tests inside the TestClass.
        [TestInitialize]
        public void Setup()
        {
            PublicAppHandler public_app = new PublicAppHandler();
            public_app_api = public_app.Create_PublicAppAPI();
            org = public_app.Create_PublicAppAPI_Organisation(public_app_api);
            //public_app_api = Create_PublicAppAPI();
            //org = Create_PublicAppAPI_Organisation(public_app_api);
        }

        [TestCleanup]
        public void Cleanup()
        {

        }

    }
}
