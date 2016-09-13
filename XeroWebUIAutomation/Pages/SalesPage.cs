using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace XeroWebUIAutomation.Pages
{
    public class SalesPage : BasePage
    {

        string SalesUrl = Properties.Settings.Default.SalesUrl;

        //constructor
        public SalesPage(IWebDriver driver)
            : base(driver)
        {
            //this.driver.Navigate().GoToUrl(SalesUrl);
            WaitForPageElement(By.Id("invoicesToBePaidChart"));
        }

        //elements
        #region ByElements
        private By BySearchNewDroplist()
        {
            return By.XPath("//a[@href='/AccountsReceivable/Edit.aspx']/span");
        }
        private By BySearchNewRepeatingInvoice()
        {
            return By.XPath("//b[.='Repeating invoice']");
        }
        private By BySearchRepeatingTab()
        {
            return By.XPath("//a[.='Repeating']");
        }
        private By BySearchinvoicesToBePaidChart()
        {
            return By.Id("invoicesToBePaidChart");
        }
        #endregion

        //functions
        #region methods
        public void clickNewDroplist()
        {
            this.driver.FindElement(BySearchNewDroplist()).Click();
        }
        public void clickNewRepeatingInvoice()
        {
            this.driver.FindElement(BySearchNewRepeatingInvoice()).Click();
        }
        public void clickRepeatingTab()
        {
            this.driver.FindElement(BySearchRepeatingTab()).Click();
        }
        #endregion
    }
}
