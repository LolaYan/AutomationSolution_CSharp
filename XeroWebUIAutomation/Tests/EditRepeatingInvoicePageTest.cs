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
    /// Summary description for EditRepeatingInvoicePageTest
    /// </summary>
    [TestClass]
    public class EditRepeatingInvoicePageTest : BaseTest
    {
        public EditRepeatingInvoicePageTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        //TestData
        #region TestData
        string email = Properties.Settings.Default.UserEmail;
        string password = Properties.Settings.Default.UserPassword;
        string PeriodUnit = "2";
        string TimeUnit = "Weeks";
        string strStartDate = DateTime.Today.ToString("dd MMMM yyyy");
        string DueDateDay = "10";
        string strEndDate = DateTime.Today.AddDays(90).ToString("dd MMMM yyyy");
        string SaveType = "saveAsAutoApproved";
        string PaidtoName = "Xero";
        string TestReference = "TEST";
        #endregion

        //Test Method
        [TestMethod]
        public void EditRepeatingInvoiceTest()
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
            salesPage.clickNewDroplist();
            salesPage.clickNewRepeatingInvoice();

            //RepeatingInvoicePage repeatingInvoicePage = new RepeatingInvoicePage(this.driver);
            //repeatingInvoicePage.ClickNewRepeatingInvoice();


            EditRepeatingInvoicePage editRepeatingInvoicePage = new EditRepeatingInvoicePage(this.driver);
            editRepeatingInvoicePage.CreateNewRepeatingInvoice(PeriodUnit,TimeUnit,strStartDate,DueDateDay,strEndDate,SaveType,PaidtoName,TestReference);
            /*
            editRepeatingInvoicePage.InputPeriodUnit("2");
            editRepeatingInvoicePage.InputTimeUnit("Weeks");
            editRepeatingInvoicePage.SetStartDate(strStartDate);
            editRepeatingInvoicePage.SetDueDateDay("10");
            editRepeatingInvoicePage.SetEndDate(strEndDate);
            editRepeatingInvoicePage.ChooseSaveType("saveAsAutoApproved");
            editRepeatingInvoicePage.SetPaidtoName("Xero");
            editRepeatingInvoicePage.InputTestReference("TEST");
            editRepeatingInvoicePage.SelectExistingItem(1, "Train-MS: Half day training - Microsoft Office");
            editRepeatingInvoicePage.SelectExistingItem(2, "BOOK: Fish out of Water: Finding Your Brand");
            editRepeatingInvoicePage.SelectExistingItem(3, "PR-BR: Project management & implementation - branding");
            editRepeatingInvoicePage.SelectExistingItem(4, "Support-M: Desktop/network support via email & phone");
            editRepeatingInvoicePage.SaveRepeatingInvoice();
            */
        }
    }
}
