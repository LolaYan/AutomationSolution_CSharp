using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace XeroMobileUIAutomation.Screens
{
    public class MyXeroScreen : BaseScreen
    {
        public MyXeroScreen(AndroidDriver<AndroidElement> driver)
            : base(driver)
        {
            this.driver = driver;
            WaitForPageElement(ByTextDemoOrg());
        }

        #region ByElements
        private By ByTextDemoOrg() { return By.Name("Demo Company (NZ)"); }
        private By ByButtonLogout() { return By.Id("com.xero.touch:id/menu_logout_action"); }
        private By ByTextMoreOptions() { return By.Name("More options"); }
        #endregion

        #region Methods
        public void ClickDemoOrg()
        {
            this.driver.FindElement(ByTextDemoOrg()).Click();
        }
        public void ClickLogout()
        {
            this.driver.FindElement(ByButtonLogout()).Click();
        }
        #endregion

    }
}
