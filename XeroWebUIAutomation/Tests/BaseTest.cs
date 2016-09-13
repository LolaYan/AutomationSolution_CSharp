using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XeroWebUIAutomation.Drivers;

namespace XeroWebUIAutomation.Tests
{
    /// <summary>
    /// Summary description for BaseTest
    /// </summary>
    [TestClass]
    public class BaseTest
    {
        public WebDriverSupport wds;
        public IWebDriver driver;

        public BaseTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestInitialize]
        public void Setup()
        {
            string browser = Properties.Settings.Default.Browser.ToUpper();
            string url = Properties.Settings.Default.Url;

            this.wds = new WebDriverSupport();
            this.driver = wds.InitDriver(browser);

            //Example URL - To be removed/modified based on testing requirement
            this.driver.Navigate().GoToUrl(url);

        }

        [TestCleanup]
        public void Cleanup()
        {
            //wds.DestroyDriver();
        }
    }
}
