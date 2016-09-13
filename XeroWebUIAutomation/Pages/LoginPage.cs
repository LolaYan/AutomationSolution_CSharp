using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace XeroWebUIAutomation.Pages
{
    public class LoginPage : BasePage
    {
        //constructor
        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            WaitForPageElement(BySearchSubmitButton());
        }

        //elements
        #region ByElements
        private By BySearchEmail()
        {
            return By.Id("email");
        }
        private By BySearchPassword()
        {
            return By.Id("password");
        }
        private By BySearchSubmitButton()
        {
            return By.Id("submitButton");
        }
        #endregion

        //functions
        #region methods
        public void InputEmail(string email)
        {
            this.driver.FindElement(BySearchEmail()).Clear();
            this.driver.FindElement(BySearchEmail()).SendKeys(email);
        }

        public void InputPassword(string password)
        {
            this.driver.FindElement(BySearchPassword()).Clear();
            this.driver.FindElement(BySearchPassword()).SendKeys(password);
        }

        public void clickSubmitButton()
        {
            this.driver.FindElement(BySearchSubmitButton()).Click();
        }

        #endregion
    }
}
