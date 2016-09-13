using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace XeroWebUIAutomation.Pages
{
    public class SignupPage : BasePage
    {
        //constructor
        public SignupPage(IWebDriver driver)
            : base(driver)
        {
            WaitForPageElement(BySearchSubmitButton());
        }

        //elements
        #region ByElements
        private By BySearchFirstName()
        {
            return By.XPath("//name[@class='FirstName']");
        }
        private By BySearchLastName()
        {
            return By.XPath("//name[@class='LastName']");
        }
        private By BySearchEmailAddress()
        {
            return By.XPath("//name[@class='EmailAddress']");
        }
        private By BySearchPhoneNumber()
        {
            return By.XPath("//name[@class='PhoneNumber']");
        }
        private By BySearchTermsAcceptedCheckbox()
        {
            return By.XPath("//name[@class='TermsAccepted']");
        }
        private By BySearchSubmitButton()
        {
            return By.XPath("//button[.='Get started']");
        }
        #endregion

        //functions
        #region methods
        public void InputFirstName(string FirstName)
        {
            this.driver.FindElement(BySearchFirstName()).Clear();
            this.driver.FindElement(BySearchFirstName()).SendKeys(FirstName);
        }

        public void InputLastName(string LastName)
        {
            this.driver.FindElement(BySearchLastName()).Clear();
            this.driver.FindElement(BySearchLastName()).SendKeys(LastName);
        }
        public void InputEmail(string email)
        {
            this.driver.FindElement(BySearchEmailAddress()).Clear();
            this.driver.FindElement(BySearchEmailAddress()).SendKeys(email);
        }

        public void InputPhoneNumber(string PhoneNumber)
        {
            this.driver.FindElement(BySearchPhoneNumber()).Clear();
            this.driver.FindElement(BySearchPhoneNumber()).SendKeys(PhoneNumber);
        }
        public void TickAcceptedCheckbox()
        {
            this.driver.FindElement(BySearchTermsAcceptedCheckbox()).SendKeys(Keys.Enter);
        }
        public void clickSubmitButton()
        {
            this.driver.FindElement(BySearchSubmitButton()).Click();
        }
        #endregion
    }
}
