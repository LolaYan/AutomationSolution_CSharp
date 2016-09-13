using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

using XeroMobileUIAutomation.Utilities;

namespace XeroMobileUIAutomation.Screens
{
    public class DemoOrgHomeScreen : BaseScreen
    {
        public DemoOrgHomeScreen(AndroidDriver<AndroidElement> driver)
            : base(driver)
        {
            this.driver = driver;
            WaitForPageElement(ByTitleBankAccounts());
        }

        #region ByElements

        //nav
        private By ByNavBack() { return By.Name("Navigate up"); }
        private By ByNavMoreOptions() { return By.Name("More options"); }

        //com.xero.touch:id/psts_tab_title
        private By ByTabDashboard() { return By.Name("DASHBOARD"); }
        private By ByTabInvoice() { return By.Name("INVOICES"); }
        private By ByTabReceipts() { return By.Name("RECEIPTS"); }
        private By ByTabContacts() { return By.Name("CONTACTS"); }

        //com.xero.touch:id/text_header_title
        private By ByTitleBankAccounts() { return By.Name("Bank accounts"); }
        private By ByTitleReceipts() { return By.Name("Receipts"); }
        private By ByTitleInvoices() { return By.Name("Invoices"); }        

        //Invoice
        private By ByTextOverdue() { return By.Name("Overdue"); }
        private By ByTextUnpaid() { return By.Name("Unpaid"); }
        private By ByTextDraft() { return By.Name("Draft"); }

        //reseipt
        private By ByTextOverdueDraftReceipt() { return By.Name("Draft"); }
        private By ByTextAwaitingReceipt() { return By.Name("Awaiting Repayment"); }
        #endregion

        #region Methods
        
        //Tab
        public void ClickTabDashboard()
        {
            this.driver.FindElement(ByTabDashboard()).Click();
        }
        public void ClickTabInvoice()
        {
            this.driver.FindElement(ByTabInvoice()).Click();
        }
        public void ClickTabReceipts()
        {
            this.driver.FindElement(ByTabReceipts()).Click();
        }
        public void ClickTabContacts()
        {
            this.driver.FindElement(ByTabContacts()).Click();
        }

        //Invoice
        public void ClickOverdueInvoices()
        {
            this.driver.FindElement(ByTextOverdue()).Click();
        }
        public void ClickUnpaidInvoices()
        {
            this.driver.FindElement(ByTextUnpaid()).Click();
        }
        public void ClickDraftInvoices()
        {
            this.driver.FindElement(ByTextDraft()).Click();
        }

        //receipt
        public void ClickAwaitingReceipt()
        {
            ScrollUptoFindElement( ByTextAwaitingReceipt(), 2000);
            //var elem = driver.FindElement(ByTextAwaitingReceipt());
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", elem);
            this.driver.FindElement(ByTextAwaitingReceipt()).Click();
        }

        #endregion

    }
}
