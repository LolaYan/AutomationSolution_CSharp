using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using XeroWebUIAutomation.Utilities;

namespace XeroWebUIAutomation.Pages
{
    public class EditRepeatingInvoicePage : BasePage
    {
        //constructor
        public EditRepeatingInvoicePage(IWebDriver driver)
            : base(driver)
        {
            WaitForPageElement(BySearch_StartDate_Toggle());
        }

        //elements
        #region ByElements
        private By BySearch_PeriodUnit_Input()
        {
            return By.Id("PeriodUnit");
        }
        //TimeUnit_value
        private By BySearch_TimeUnitValue_Input()
        {
            return By.Id("TimeUnit_value");
        }
        //TimeUnit toggle
        private By BySearch_TimeUnit_toggle()
        {
            return By.Id("TimeUnit_toggle");
        }
        private By BySearch_TimeUnitSuggestions_Weeks()
        {
            return By.XPath("//div[@id='TimeUnit_suggestions']//*[.='Week(s)']");
        }
        private By BySearch_TimeUnitSuggestions_Month()
        {
            return By.XPath("//div[@id='TimeUnit_suggestions']//*[.='Month(s)']");
        }
        //StartDate
        private By BySearch_StartDate_Input()
        {
            return By.Id("StartDate");
        }
        //StartDate Toggle
        private By BySearch_StartDate_Toggle()
        {
            return By.XPath("//input[@id='StartDate']/..//img");
        }
        //DueDateDay
        private By BySearch_DueDateDay_Input()
        {
            return By.Id("DueDateDay");
        }
        //DueDateDay toggle
        private By BySearch_DueDateType_Toggle()
        {
            return By.Id("DueDateType_toggle");
        }
        //EndDate
        private By BySearch_EndDate_Input()
        {
            return By.Id("EndDate");
        }

        //saveAsDraft Checkbox
        private By BySearch_saveAsDraft_Checkbox()
        {
            return By.Id("saveAsDraft");
        }
        //saveAsAutoApproved
        private By BySearch_saveAsAutoApproved_Checkbox()
        {
            return By.Id("saveAsAutoApproved");
        }
        //saveAsAutoApprovedAndEmail
        private By BySearch_saveAsAutoApprovedAndEmail_Checkbox()
        {
            return By.Id("saveAsAutoApprovedAndEmail");
        }

        //Invoice to Name
        private By BySearch_InvoicetoName_Input()
        {
            return By.XPath("//input[contains(@id,'PaidToName_')]");
        }
        //Reference
        private By BySearch_Reference_Input()
        {
            return By.XPath("//input[contains(@id,'Reference_')]");
        }
        //Placeholder
        private By BySearch_Placeholder_Selector()
        {
            return By.XPath("//a[contains(text(),'  Insert Placeholder')]/span");
        }
        //ItemDescriptChoice_Toggle
        private By BySearch_ItemDescriptChoice_Toggle()
        {
            return By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colPriceList')]");
        }
        //ItemDescript_NewItem
        private By BySearch_ItemDescript_NewItem()
        {
            return By.XPath("//div[@id='invoice']//div[@class='x-grid3-scroller']//img[@src='/common/images/default/s-5378c2b4f938712e61a6a89b3703efbe.gif']");
        }

        private By BySearchSubmitButton()
        {
            return By.XPath("//div[@id='bodyContainer']//button//span[.='Save']/..");
        }
        #endregion

        //functions
        #region methods
        public void InputPeriodUnit(string PeriodUnit)
        {
            this.driver.FindElement(BySearch_PeriodUnit_Input()).Clear();
            this.driver.FindElement(BySearch_PeriodUnit_Input()).SendKeys(PeriodUnit);
        }

        public void InputTimeUnit(string TimeUnit)
        {
            driver.FindElement(By.Id("TimeUnit_toggle")).Click();
            if (TimeUnit.Equals("Weeks"))
            {
                driver.FindElement(BySearch_TimeUnitSuggestions_Weeks()).Click();
            }else
            {
                driver.FindElement(BySearch_TimeUnitSuggestions_Month()).Click();
            }
        }

        public void SetStartDate(string StartDate)
        {
            this.driver.FindElement(BySearch_StartDate_Input()).SendKeys(StartDate);
        }
        public void SetDueDateDay(string DueDateDay)
        {
            this.driver.FindElement(BySearch_DueDateDay_Input()).SendKeys(DueDateDay);
        }
        public void SetEndDate(string EndDate)
        {
            this.driver.FindElement(BySearch_EndDate_Input()).SendKeys(EndDate);
        }

        public void ChooseSaveType(string SaveType)
        {
            if (SaveType.Equals("saveAsAutoApprovedAndEmail"))
            {
                driver.FindElement(BySearch_saveAsAutoApprovedAndEmail_Checkbox()).Click();
            }
            else if (SaveType.Equals("saveAsAutoApproved"))
            {
                driver.FindElement(BySearch_saveAsAutoApproved_Checkbox()).Click();
            }
            else
            {
                driver.FindElement(BySearch_saveAsDraft_Checkbox()).Click();
            }
        }

        //Set up PaidtoName
        public void SetPaidtoName(string PaidtoName)
        {
            this.driver.FindElement(BySearch_InvoicetoName_Input()).SendKeys(PaidtoName);
        }

        //test reference
        public void InputTestReference(string TestReference)
        {
            this.driver.FindElement(BySearch_Reference_Input()).SendKeys(TestReference);
        }

        public void ClickDueDateTypeToggle()
        {
            this.driver.FindElement(BySearch_DueDateType_Toggle()).Click();
        }

        public void InputInvoicetoName(String PaiyerName)
        {
            this.driver.FindElement(BySearch_InvoicetoName_Input()).SendKeys(PaiyerName);
        }

        public void InputInvoiceReference(String InvoiceReference)
        {
            this.driver.FindElement(BySearch_Reference_Input()).SendKeys(InvoiceReference);
        }

        public void SaveRepeatingInvoice()
        {
            this.driver.FindElement(BySearchSubmitButton()).Click();
        }

        public void SelectExistingItem(int lineNo, String ItemDes)
        {
            /** ItemDes can be:
             * BOOK: Fish out of Water: Finding Your Brand
             * Train-MS: Half day training - Microsoft Office
             * PR-BR: Project management & implementation - branding
             * Support-M: Desktop/network support via email & phone
             * GB1-White: Golf balls - white single
             * GB3-White: Golf balls - white 3-pack
             * GB6-White: Golf balls - white 6-pack
             * ...
             * */
            // 8.1 Click toogle
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colPriceList')]"))[lineNo].Click();
            driver.FindElement(By.XPath("//div[@id='invoice']//div[@class='x-grid3-scroller']//img[@src='/common/images/default/s-5378c2b4f938712e61a6a89b3703efbe.gif']")).Click();
            driver.FindElement(By.XPath("//div[.='" + ItemDes + "']")).Click();
            Thread.Sleep(1000);

        }

        public void CreateNewRepeatingInvoiceO()
        {

            // 1. Repeat this transaction every 2 weeks
            driver.FindElement(By.Id("PeriodUnit")).SendKeys("2");
            driver.FindElement(By.Id("TimeUnit_toggle")).Click();
            driver.FindElement(By.XPath("//div[@id='TimeUnit_suggestions']//*[.='Week(s)']")).Click();

            // 2. Choosing Invoice Date/Start Date, which needs to be future day.
            driver.FindElement(By.Id("StartDate")).SendKeys("23 Jul 2016");

            // 3. Input Due Date.
            driver.FindElement(By.Id("DueDateDay")).SendKeys("10");
            //driver.FindElement(By.Id("DueDateType_toggle")).Click();
            //driver.FindElement(By.XPath("//div[.='day(s) after the end of the invoice month']")).Click();

            // 4. Input End Date.
            driver.FindElement(By.Id("EndDate")).SendKeys("23 Sep 2016");

            // 5. Choosing save type - 1:saveAsDraft 2:saveAsAutoApproved 3:saveAsAutoApprovedAndEmail 
            driver.FindElement(By.Id("saveAsAutoApproved")).Click();

            // 6.1 Input 'test' as 'Invoice to' Contact
            driver.FindElement(By.XPath("//input[contains(@id,'PaidToName_')]")).SendKeys("Xero");

            // 6.2 Or create a new contact
            //+ New Contact
            //driver.FindElement(By.XPath("//span[.='+ New Contact']")).Click();

            // 7.1 Input 'test' as 'Reference'
            driver.FindElement(By.XPath("//input[contains(@id,'Reference_')]")).SendKeys("test");
            // 7.2 Or Insert Placeholder
            //driver.FindElement(By.XPath("//a[contains(text(),'  Insert Placeholder')]/span")).Click();

            Thread.Sleep(2000);

            //driver.FindElement(By.XPath("//div[.='Week']")).Click();

            //Add a new line
            //driver.FindElement(By.XPath("//span[.='Add a new line']")).Click();

            String ranStr = DataGenerator.RandomString(5);
            String ItemNo = "TEST" + ranStr;
            String ItemName = "TEST Item Name" + ranStr;
            // 8 Create a new item
            // 8.1 Click toogle
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colPriceList')]"))[1].Click();
            driver.FindElement(By.XPath("//div[@id='invoice']//div[@class='x-grid3-scroller']//img[@src='/common/images/default/s-5378c2b4f938712e61a6a89b3703efbe.gif']")).Click();
            Thread.Sleep(2000);
            //+ New Item
            driver.FindElement(By.XPath("//span[.='+ New Item']")).Click();

            //Input item code
            Thread.Sleep(2000);
            driver.FindElement(By.Id("Code")).SendKeys(ItemNo);
            driver.FindElement(By.Id("Name")).SendKeys(ItemName);

            //driver.FindElement(By.Id("IsTrackedAsInventory")).Click();
            //driver.FindElement(By.Id("IsPurchased")).Click();

            driver.FindElement(By.Id("UnitPrice")).SendKeys("10");
            driver.FindElement(By.Id("Account_value")).SendKeys("200 - Sales");

            //Description

            driver.FindElement(By.Id("Description")).SendKeys("This is a test for description!");
            driver.FindElement(By.XPath("//a[contains(text(),'Save')]")).Click();
            Thread.Sleep(2000);

            this.driver.FindElement(BySearchSubmitButton()).Click();
        }

        public void CreateNewRepeatingInvoice(string PeriodUnit, string TimeUnit, string StartDate, string DueDateDay, string EndDate, string SaveType, string PaidtoName,string TestReference)
        {
            // 1. Repeat this transaction every 2 weeks
            InputPeriodUnit(PeriodUnit);
            InputTimeUnit(TimeUnit);
            // 2. Choosing Invoice Date/Start Date, which needs to be future day.
            SetStartDate(StartDate);
            // 3. Input Due Date.
            SetDueDateDay(DueDateDay);
            // 4. Input End Date.
            SetEndDate(EndDate);
            // 5. Choosing save type - 1:saveAsDraft 2:saveAsAutoApproved 3:saveAsAutoApprovedAndEmail 
            ChooseSaveType(SaveType);
            // 6.1 Input 'test' as 'Invoice to' Contact
            SetPaidtoName(PaidtoName);
            // 7.1 Input 'test' as 'Reference'
            InputTestReference(TestReference);
            Thread.Sleep(2000);
            // 8 Edit Invoice item
            SelectExistingItem(1, "Train-MS: Half day training - Microsoft Office");
            SelectExistingItem(2, "BOOK: Fish out of Water: Finding Your Brand");
            SelectExistingItem(3, "PR-BR: Project management & implementation - branding");
            SelectExistingItem(4, "Support-M: Desktop/network support via email & phone");
            // 9 Save current invoice
            SaveRepeatingInvoice();
        }

        public void CreateNewRepeatingInvoiceItem(String ItemNo, String ItemName)
        {
            String ranStr = DataGenerator.RandomString(5);
            ItemNo = "TEST" + ranStr;
            ItemName = "TEST Item Name" + ranStr;
            // 8 Create a new item
            // 8.1 Click toogle
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colPriceList')]"))[1].Click();
            driver.FindElement(By.XPath("//div[@id='invoice']//div[@class='x-grid3-scroller']//img[@src='/common/images/default/s-5378c2b4f938712e61a6a89b3703efbe.gif']")).Click();
            Thread.Sleep(2000);
            //+ New Item
            driver.FindElement(By.XPath("//span[.='+ New Item']")).Click();

            //Input item code
            Thread.Sleep(2000);
            driver.FindElement(By.Id("Code")).SendKeys(ItemNo);
            driver.FindElement(By.Id("Name")).SendKeys(ItemName);

            //driver.FindElement(By.Id("IsTrackedAsInventory")).Click();
            //driver.FindElement(By.Id("IsPurchased")).Click();

            driver.FindElement(By.Id("UnitPrice")).SendKeys("10");
            driver.FindElement(By.Id("Account_value")).SendKeys("200 - Sales");

            //Description

            driver.FindElement(By.Id("Description")).SendKeys("This is a test for description!");
            driver.FindElement(By.XPath("//a[contains(text(),'Save')]")).Click();
            Thread.Sleep(2000);

        }


        public void EditExistingItem(int lineNo, String ItemDes)
        {
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colPriceList')]"))[1].Click();
            driver.FindElement(By.XPath("//div[@id='invoice']//div[@class='x-grid3-scroller']//img[@src='/common/images/default/s-5378c2b4f938712e61a6a89b3703efbe.gif']/..//input")).SendKeys("");

            /* To be continued
             * 
             * */
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colDescription')]"))[lineNo].Click();
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colQuantity')]"))[lineNo].Click();
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colUnitPrice')]"))[lineNo].Click();
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colDiscount')]"))[lineNo].Click();
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colAccount')]"))[lineNo].Click();
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colGST')]"))[lineNo].Click();
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colGSTAmount')]"))[lineNo].Click();
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colTracking1')]"))[lineNo].Click();
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colLineAmount')]"))[lineNo].Click();
            driver.FindElements(By.XPath("//div[@id='invoice']//td[contains(@class,'x-grid3-td-colDelete')]"))[lineNo].Click();
        }
        #endregion
    }
}
