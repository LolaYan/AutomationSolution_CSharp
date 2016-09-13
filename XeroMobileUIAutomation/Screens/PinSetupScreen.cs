
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
    public class PinSetupScreen: BaseScreen
    {
        public PinSetupScreen(AndroidDriver<AndroidElement> driver)
            : base(driver)
        {
            this.driver = driver;
            WaitForPageElement(ByButtonSkip());
        }

        #region ByElements
        private By ByButtonSkip() {
            By res = By.Id("com.xero.touch:id/button_forgot");
            //res = By.Name("Skip");
            return res; 
        }
        private By ByButtonNo(string No) { return By.Id("com.xero.touch:id/btn_"+No); }
        private By ByButtonBackspace() { return By.Id("com.xero.touch:id/button_backspace"); }
        #endregion

        #region Methods
        public void ClickSkip()
        {
            this.driver.FindElement(ByButtonSkip()).Click();
        }
        public void ClickNo(string No)
        {
            this.driver.FindElement(ByButtonNo(No)).Click();
        }
        public void ClickBackspace()
        {
            this.driver.FindElement(ByButtonBackspace()).Click();
        }
        #endregion

    }
    
}
