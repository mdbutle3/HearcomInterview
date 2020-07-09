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

namespace Herokuapp_Automation.Tests
{
    class NewWindowTest
    {
        private IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome");
            driver.Url = "https://the-internet.herokuapp.com/windows";
        }

        [Test]
        public void OpenNewTab()
        {
            NewWindowPage page = new NewWindowPage(driver);
            int NumOfWindowHandlesStart = driver.WindowHandles.Count;
            page.clickOpenNewWindow();
            int NumOfWindowHandlesEnd = driver.WindowHandles.Count;
            Assert.AreEqual(NumOfWindowHandlesEnd, NumOfWindowHandlesStart + 1);

        }


        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Dispose();

        }
    }
}