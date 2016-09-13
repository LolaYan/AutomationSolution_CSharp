using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace XeroWebUIAutomation.Pages
{
    public class RepeatingInvoicePage : BasePage
    {
        //constructor
        public RepeatingInvoicePage(IWebDriver driver)
            : base(driver)
        {
            WaitForPageElement(By.Id("title"));
        }

        //elements
        #region ByElements
        private By BySearch_Item_Name()
        {
            return By.XPath("//td//a[contains(text(),'Name')]");
        }
        private By BySearch_Item_Reference()
        {
            return By.XPath("//td//a[contains(text(),'Reference')]");
        }
        private By BySearch_Item_Amount()
        {
            return By.XPath("//td//a[contains(text(),'Amount')]");
        }
        private By BySearch_Item_EndDate()
        {
            return By.XPath("//td//a[contains(text(),'End Date')]");
        }
        private By BySearch_Item_InvoiceWillBe()
        {
            return By.XPath("//a[contains(text(),'InvoiceWillBe')]");
        }

        private By BySearch_Search_Button()
        {
            return By.XPath("//span[.='Search']");
        }
        //sb_txtReference
        private By BySearch_SearchReference_Input()
        {
            return By.Id("sb_txtReference");
        }
        //sb_drpWithin_value
        private By BySearch_SearchWithin_Input()
        {
            return By.Id("sb_drpWithin_value");
        }
        //sb_dteStartDate
        private By BySearch_SearchStartDate_Input()
        {
            return By.Id("sb_dteStartDate");
        }
        //sb_dteEndDate
        private By BySearch_SearchEndDate_Input()
        {
            return By.Id("sb_dteEndDate");
        }
        //"//*[@id='sbContainer_']//a[@class='icons search-delete']"
        private By BySearch_SearchDelete_Icon()
        {
            return By.XPath("//*[@id='sbContainer_']//a[@class='icons search-delete']");
        }
        private By BySearch_ClearSearch_Button()
        {
            return By.XPath("//a[contains(text(),'Clear')]");
        }
        private By BySearch_NewRepeatingInvoice_Button()
        {
            return By.XPath("//a[contains(text(),'New Repeating Invoice')]");
        }
        #endregion

        //functions
        #region methods
        public void ClickSearchButton()
        {
            this.driver.FindElement(BySearch_Search_Button()).Click();
        }

        public void ClickNewRepeatingInvoice()
        {
            this.driver.FindElement(BySearch_NewRepeatingInvoice_Button()).Click();
        }

        #endregion
    }
}
