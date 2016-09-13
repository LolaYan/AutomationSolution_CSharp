using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using XeroWebUIAutomation.Pages;

namespace XeroWebUIAutomation.Tests
{
    /// <summary>
    /// Summary description for RepeatingInvoicePageTest
    /// </summary>
    [TestClass]
    public class RepeatingInvoicePageTest : BaseTest
    {
        public RepeatingInvoicePageTest()
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

        //Test Data
        #region TestData
        string email = Properties.Settings.Default.UserEmail;
        string password = Properties.Settings.Default.UserPassword;
        string invalidEmail = "";
        string invalidPassword = "";
        #endregion

        [TestMethod]
        public void RepeatingInvoiceTest()
        {
            LoginPage loginPage = new LoginPage(this.driver);
            loginPage.InputEmail(email);
            loginPage.InputPassword(password);
            loginPage.clickSubmitButton();
            Thread.Sleep(2000);

            DashboardPage dashboardPage = new DashboardPage(this.driver);
            dashboardPage.clickOrgName();
            dashboardPage.chooseDemoOrgNZ();
            dashboardPage.clickNavAccounts();
            dashboardPage.clickNavAccountsSales();

            SalesPage salesPage = new SalesPage(this.driver);
            //if the organisation is Demo org
            salesPage.clickRepeatingTab();
            //salesPage.clickNewDroplist();
            //salesPage.clickNewRepeatingInvoice();

            RepeatingInvoicePage repeatingInvoicePage = new RepeatingInvoicePage(this.driver);
            repeatingInvoicePage.ClickSearchButton();
        }
    }
}
