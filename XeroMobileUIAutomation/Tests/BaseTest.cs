using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeroMobileUIAutomation.Drivers;

namespace XeroMobileUIAutomation.Tests
{
    [TestClass]
    public class BaseTest
    {
        public AndroidDriverSupport ads;
        public AndroidDriver<AndroidElement> driver;

        [TestInitialize]
        public void Setup()
        {
            this.ads = new AndroidDriverSupport();
            this.driver = ads.InitAndroidDriver();

          
        }
        [TestCleanup]
        public void Cleanup()
        {
            //ads.DestroyDriver();
        }
    }
}
