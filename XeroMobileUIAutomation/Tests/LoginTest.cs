using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XeroMobileUIAutomation.Screens;

namespace XeroMobileUIAutomation.Tests
{
    [TestClass]
    public class LoginTest : BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            StartScreen StartScreen = new StartScreen(driver);
            StartScreen.ClickLogin();

            LoginScreen LoginScreen = new LoginScreen(driver);
            LoginScreen.InputUsername("lolayan@outlook.com");
            LoginScreen.InputPassword("password123");
            LoginScreen.ClickLogin();

            PinSetupScreen PinSetupScreen = new PinSetupScreen(driver);
            PinSetupScreen.ClickSkip();

            MyXeroScreen MyXeroScreen = new MyXeroScreen(driver);
            MyXeroScreen.ClickDemoOrg();

            DemoOrgHomeScreen DemoOrgHomeScreen = new DemoOrgHomeScreen(driver);
            DemoOrgHomeScreen.ClickAwaitingReceipt();
            //DemoOrgHomeScreen.ClickTabInvoice();

        }
    }
}
