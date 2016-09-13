using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Enums;

namespace XeroMobileUIAutomation.Drivers
{
    public class AndroidDriverSupport
    {
        public AndroidDriver<AndroidElement> androidDriver;
        public AndroidDriver<AndroidElement> InitAndroidDriver()
        {
            DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            string appName = "Webjet.com.apk";
            //appName = "mylotto-cat1.apk";
            appName = "XeroAccountingSoftware.apk";
            var app = directory.Parent.Parent.FullName + "\\Resources\\" + appName;

            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("device", "Android");
            capabilities.SetCapability(CapabilityType.Platform, "Android");
            capabilities.SetCapability("deviceName", "emulator-5554"); 
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "4.4");

            capabilities.SetCapability("app", @app);
            capabilities.SetCapability("appPackage", "com.xero.touch");
            capabilities.SetCapability("appActivity", "com.xero.touch.myxero.MyXeroActivity");


            androidDriver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
            return androidDriver;
        }

        public static DesiredCapabilities getAndroid501Caps(string app, string appPackage, string appActivity, string DeviceName, string PlatformName, string PlatformVersion)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "Android Emulator");
            capabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "4.4");

            //capabilities.SetCapability(MobileCapabilityType.App, app);
            //capabilities.SetCapability(MobileCapabilityType.AppPackage, "io.appium.android.apis");
            //capabilities.SetCapability(MobileCapabilityType.AppActivity, ".Apidemos");
            capabilities.SetCapability("app", "Webjet.com.apk");
            capabilities.SetCapability("appPackage", "au.com.webjet");
            capabilities.SetCapability("appActivity", "au.com.webjet.activity.MainActivity");

            return capabilities;
        }

        public void DestroyDriver()
        {
            this.androidDriver.Quit();
        }
    }
}
