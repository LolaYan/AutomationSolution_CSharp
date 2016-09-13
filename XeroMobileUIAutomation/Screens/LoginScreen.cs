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
    public class LoginScreen: BaseScreen
    {
        public LoginScreen(AndroidDriver<AndroidElement> driver)
            : base(driver)
        {
            this.driver = driver;
            WaitForPageElement(ByButtonLogin());
        }

        #region ByElements
        private By ByEditTextUsername() { return By.Id("com.xero.touch:id/username_edittext"); }
        private By ByEditTextPwd() { return By.Id("com.xero.touch:id/password_edittext"); }
        private By ByButtonLogin() { return By.Id("com.xero.touch:id/loginButton"); }
        #endregion

        #region Methods
        public void InputUsername(string username)
        {
            this.driver.FindElement(ByEditTextUsername()).SendKeys(username);
        }
        public void InputPassword(string password)
        {
            this.driver.FindElement(ByEditTextPwd()).SendKeys(password);
        }
        public void ClickLogin()
        {
            this.driver.FindElement(ByButtonLogin()).Click();
        }
        #endregion

    }
    
}
