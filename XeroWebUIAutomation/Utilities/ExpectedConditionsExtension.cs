using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace XeroWebUIAutomation.Utilities
{

    public class ExpectedConditionsExtension
    {

        public static Func<IWebDriver, bool> AngularIsReady()
        {

            return (driver) =>
            {
                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                bool httpComplete = (bool)js.ExecuteScript("return (window.angular != null) && (angular.element(document).injector() != null) && (angular.element(document).injector().get('$http').pendingRequests.length === 0)");
                bool templateRendered = false;
                if (httpComplete)
                {
                    ReadOnlyCollection<IWebElement> els = driver.FindElements(By.CssSelector("body[ng-cloak]"));
                    if (els.Count == 0)
                    {
                        templateRendered = true;
                    }
                }

                return (httpComplete && templateRendered);
            };


        }

        public static Func<IWebDriver, bool> PageTransitionComplete()
        {
            return (driver) =>
            {

                IWebElement activePane;

                try
                {
                    activePane = driver.FindElement(By.CssSelector(".slider-control .active"));
                }
                catch
                {
                    activePane = driver.FindElement(By.CssSelector("#pager"));
                }

                if (activePane.GetCssValue("display").Contains("block"))
                {
                    return true;
                }
                //add last-active display none if issues?
                return false;
            };
        }

        public static Func<IWebDriver, string> ElementHasText(IWebElement element)
        {
            return (driver) =>
            {
                string elementText = element.Text.Trim();
                if (elementText.Equals("") || elementText.Equals(null))
                {
                    return null;
                }
                return elementText;
            };
        }

        public static Func<IWebDriver, bool> ElementDoesNotExist(By locator)
        {
            return (driver) =>
            {
                if (driver.FindElement(locator).Displayed)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            };
        }

        public static Func<IWebDriver, bool> NewTabExists()
        {
            return (driver) =>
            {
                IEnumerator<string> enumerator = driver.WindowHandles.GetEnumerator();
                enumerator.MoveNext();

                do
                {
                    String windowHandle = enumerator.Current;

                    if (!windowHandle.Contains(driver.CurrentWindowHandle))
                    {
                        driver.SwitchTo().Window(windowHandle);
                        return true;
                    }

                } while (enumerator.MoveNext());
                return false;
            };
        }

        public static Func<IWebDriver, bool> BringDefaultTabInFront()
        {
            return (driver) =>
            {
                string originalTabHandle = driver.CurrentWindowHandle;
                IEnumerator<string> enumerator = driver.WindowHandles.GetEnumerator();
                enumerator.MoveNext();

                do
                {
                    String windowHandle = enumerator.Current;

                    if (!windowHandle.Contains(originalTabHandle))
                    {
                        driver.SwitchTo().Window(windowHandle).Close();
                        driver.SwitchTo().Window(originalTabHandle);
                        return true;
                    }

                } while (enumerator.MoveNext());
                return false;
            };
        }

        public static Func<IWebDriver, bool> ErrorIsDisplayed()
        {
            return (driver) =>
            {
                IReadOnlyCollection<IWebElement> errorCollection = driver.FindElements(By.Name("nameValidationError"));

                foreach (IWebElement el in errorCollection)
                {
                    if (el.Displayed)
                    {
                        return true;
                    }
                }

                return false;
            };
        }

        public static Func<IWebDriver, bool> TextInElement(IWebElement element, string text)
        {
            return (driver) =>
            {
                if (element.GetAttribute("value").Equals(text))
                {
                    return true;
                }

                return false;
            };
        }

    }
}
