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

namespace XeroMobileUIAutomation.Utilities
{
    public class TouchActionHelper
    {
        private Size winSize;  
       
        
        // define two methods that compute the actual coordinates given the percentage
        public int GetX(int inx)
        {
            return (int)((winSize.Width * inx) / 100);
        }

        public int GetY(int iny)
        {
            return (int)((winSize.Height * iny) / 100);
        }

        public void Scrollup(AndroidDriver<AndroidElement> driver)
        {
            //Retrieve actual device dimensions - after creating the driver
            winSize = driver.Manage().Window.Size;
            
            // scroll by using touch action from (40%,80%) to (35%,25%)
            int startX, startY, endX, endY;
            startX = GetX(50);
            startY = GetY(85);
            endX = GetX(50);
            endY = GetY(80);

            driver.Swipe(startX, startY, endX, endY,1000);
            //TouchAction scrollUp = new TouchAction(driver);
            //scrollUp.Press(startX, startY).Wait(1000).MoveTo(endX, endY).Release().Perform();

        }

        public void ScrolltoRight(AndroidDriver<AndroidElement> driver)
        {
            winSize = driver.Manage().Window.Size;

            // scroll by using touch action from (40%,80%) to (35%,25%)
            int startX, startY, endX, endY;
            startX = GetX(50);
            startY = GetY(10);
            endX = GetX(80);
            endY = GetY(50);

            driver.Swipe(startX, startY, endX, endY, 1000);

        }


        public void ScrollUptoFindElement(AndroidDriver<AndroidElement> driver, By by, int durationSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(durationSeconds));
            try
            {
                do
                {
                    Scrollup(driver);
                } while (!driver.FindElement(by).Displayed);
            }
            catch (NoSuchElementException)
            {
                //add throw new exception message
            }

            
        }
    }
}
