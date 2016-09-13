using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace XeroWebUIAutomation.Drivers
{
    public class WebDriverSupport
    {
        public IWebDriver driver;
        int timeWaitInSeconds = Int32.Parse(Properties.Settings.Default.timeWaitInSeconds.ToUpper());
        string DriversLocation = Properties.Settings.Default.DriversLocation;

        public WebDriverSupport()
        {
        }

        public IWebDriver InitDriver(string browser)
        {
            //DriversLocation = DirectoryProvider.GetDriversDirectoryInfo();

            //open browser
            switch (browser)
            {
                case "CHROME":
                    //this.driver = new ChromeDriver(@DriversLocation);
                    this.driver = new ChromeDriver();
                    break;
                case "IE":
                    //this.driver = new InternetExplorerDriver(@DriversLocation);
                    this.driver = new InternetExplorerDriver();
                    break;
                case "FIREFOX":
                    this.driver = new FirefoxDriver();
                    break;
            }

            //Implicitly Wait
            this.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeWaitInSeconds));

            return driver;
        }

        public void DestroyDriver()
        {
            this.driver.Quit();
        }
    }
}
