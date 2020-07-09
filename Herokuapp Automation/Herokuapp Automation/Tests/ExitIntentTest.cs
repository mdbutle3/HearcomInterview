using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//I never got this test to work :(
namespace Herokuapp_Automation.Tests
{
    class ExitIntentTest
    {

        private IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome");
            driver.Url = "https://the-internet.herokuapp.com/exit_intent";
        }

        //Tries to move cursor out of window to make popup show up never got this to work though :(
        [Test]
        public void UnfocusTest()
        {
            ExitIntentPage exit = new ExitIntentPage(driver);
            exit.LeavePage();
        }


        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Dispose();

        }
    }
}
