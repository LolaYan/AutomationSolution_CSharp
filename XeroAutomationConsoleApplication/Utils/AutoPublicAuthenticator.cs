using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using Xero.Api.Example.Applications.Public;
using Xero.Api.Infrastructure.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace XeroAutomationConsoleApplication.Utils
{
    public class AutoPublicAuthenticator : PublicAuthenticator
    {

        public AutoPublicAuthenticator(string baseUri, string tokenUri, string callBackUrl, ITokenStore store)
            : base(baseUri, tokenUri, callBackUrl, store)
        {

        }

        //Override the AuthorizeUser function of Xero.Api.Example.Applications.Public.PublicAuthenticator
        protected override string AuthorizeUser(IToken token)
        {
            var authorizeUrl = GetAuthorizeUrl(token);

            //Process.Start(authorizeUrl);
            //Console.WriteLine("Enter the PIN given on the web page");
            //return Console.ReadLine();
            var tokenPin = getAuthCode(authorizeUrl);

            return tokenPin;
        }

        public string getAuthCode(string url)
        {
            string LoginUrl = Properties.Settings.Default.XeroLoginUrl;
            string email = Properties.Settings.Default.XeroUserEmail;
            string password = Properties.Settings.Default.XeroUserPassword;

            //new chromedriver
            IWebDriver driver = new ChromeDriver();
            //login xero
            LoginXero(driver, email, password);
            //get the verify code and return
            var tokenPin = AuthoriseXero(driver, url);
            //close driver
            driver.Close();

            return tokenPin;

        }

        public string AuthoriseXero(IWebDriver driver, string authorizeUrl)
        {
            driver.Navigate().GoToUrl(authorizeUrl);
            //Real Scenario: User is requested to select which Xero organisation they want to grant the application access to.

            //Go to Authorise Page

            //Find Demo Company in Organisation Droplist
            By selectOrg = By.XPath("//select[@name='SelectedOrganisation']");
            WaitForPageElement(driver, selectOrg);
            driver.FindElement(selectOrg).Click();

            //Click Demo Company in Organisation Droplist
            By selectDemoCompanyOrg = By.XPath("//option[.='Demo Company (NZ)']");
            WaitForPageElement(driver, selectDemoCompanyOrg);
            driver.FindElement(selectDemoCompanyOrg).Click();

            //Find Authorise button
            By elementAuthorise = By.XPath("//span[.='Authorise']");
            WaitForPageElement(driver, elementAuthorise);
            driver.FindElement(elementAuthorise).Click();

            //Redirect to TokenPin, and get tokenPin value
            By elementTokenPin = By.Id("tokenPin");
            WaitForPageElement(driver, elementTokenPin);
            string tokenPin = driver.FindElement(elementTokenPin).Text.ToString();

            //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //js.ExecuteScript("document.getElementById('save-button').click()");
            //string tokenPin = (string)js.ExecuteScript("return document.getElementById('tokenPin').innerHTML;");

            return tokenPin;
        }

        public void LoginXero(IWebDriver driver, string email, string password)
        {

            string LoginUrl = Properties.Settings.Default.XeroLoginUrl;

            //Real Scenario: User is redirected to Xero and prompted to login if they do not already have an active session.
            driver.Navigate().GoToUrl(LoginUrl);

            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(password);

            driver.FindElement(By.Id("submitButton")).Click();

            Thread.Sleep(2000);
        }
        public void WaitForPageElement(IWebDriver driver, By element)
        {
            int timeWaitInSeconds = Int32.Parse(Properties.Settings.Default.timeWaitInSeconds.ToUpper());
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeWaitInSeconds));

            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(element));
            }
            catch (WebDriverTimeoutException)
            {
                //add throw new exception message
            }
        }
    }
}
