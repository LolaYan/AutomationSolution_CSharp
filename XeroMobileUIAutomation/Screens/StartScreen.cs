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
    public class StartScreen : BaseScreen
    {
        public StartScreen(AndroidDriver<AndroidElement> driver)
            : base(driver)
        {
            this.driver = driver;
            WaitForPageElement(ByButtonLogin());
        }

        #region ByElements
        private By ByButtonLogin() { return By.Id("com.xero.touch:id/login_start_button"); }
        private By ByButtonSignup() { return By.Id("com.xero.touch:id/signup_start_button"); }
        #endregion

        #region Methods
        public void ClickLogin()
        {
            this.driver.FindElement(ByButtonLogin()).Click();
        }
        public void ClickSignup()
        {
            this.driver.FindElement(ByButtonSignup()).Click();
        }
        #endregion

    }
}
