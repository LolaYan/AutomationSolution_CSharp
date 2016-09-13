using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium.Interfaces;
using XeroMobileUIAutomation.Utilities;

namespace XeroMobileUIAutomation.Screens
{
    public class BaseScreen
    {
        public AndroidDriver<AndroidElement> driver;
        public TouchActionHelper TouchActionHelper = new TouchActionHelper();

        public BaseScreen(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        public void WaitForPageElement(By id)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(id));
            }
            catch (WebDriverTimeoutException)
            {
                //add throw new exception message
            }
        }

        public void WaitForElement(By by, int durationSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(durationSeconds));

            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (WebDriverTimeoutException)
            {
                //add throw new exception message
            }
        }

        //Scroll
        public void ScrollToUsingResourceIdTestCase()
        {
            this.driver.ScrollTo("View", "android: id / list");
        }

        public void verticalScroll()
        {
            
            TouchActionHelper.Scrollup(this.driver);
        }

        public void horizontalScroll()
        {
            TouchActionHelper.ScrolltoRight(this.driver);
        }

        public void ScrollUptoFindElement(By by, int durationSeconds)
        {
            TouchActionHelper.ScrollUptoFindElement(this.driver, by, durationSeconds);
        }
    }
}
