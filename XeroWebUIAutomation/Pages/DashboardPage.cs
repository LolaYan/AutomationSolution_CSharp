using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace XeroWebUIAutomation.Pages
{
    public class DashboardPage : BasePage
    {

        string DashboardUrl = Properties.Settings.Default.DashboardUrl;

        //constructor
        public DashboardPage(IWebDriver driver)
            : base(driver)
        {
            this.driver.Navigate().GoToUrl(DashboardUrl);
            //new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementExists((By.Id("title"))));

            //It is best that element to be wait here should be the last element to be load in the page.
            WaitForPageElement(BySearchLastLoginSummary());

        }

        //elements
        #region ByElements
        private By BySearchNavAccounts()
        {
            return By.Id("Accounts");
        }
        private By BySearchNavAccountsSales()
        {
            return By.XPath("//li/a[.='Sales']");
        }
        private By BySearchLastLoginSummary()
        {
            return By.Id("last-login-summary");
        }
        //
        private By BySearchOrgName()
        {
            return By.XPath("//h2[@class='org-name']");
        }
        private By BySearchDemoOrgNZ()
        {
            return By.XPath("//li//a[.='Demo Company (NZ)']");
        }
        #endregion

        //functions
        #region methods
        public void clickNavAccounts()
        {
            this.driver.FindElement(BySearchNavAccounts()).Click();
        }
        public void clickNavAccountsSales()
        {
            this.driver.FindElement(BySearchNavAccountsSales()).Click();
        }
        public void clickOrgName()
        {
            this.driver.FindElement(BySearchOrgName()).Click();
        }
        public void chooseDemoOrgNZ()
        {
            this.driver.FindElement(BySearchDemoOrgNZ()).Click();
        }
        #endregion
    }
}