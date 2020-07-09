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
    class DynamicControlTest
    {
        IWebDriver driver;



        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome");
            driver.Url = "https://the-internet.herokuapp.com/dynamic_controls";
        }

        //Clicks Enable waits until box is enabled enters text disables then checks to make sure text still exists
        [Test]
        public void FocusUnfocusTest()
        {
            DynamicControlPage control = new DynamicControlPage(driver);
            control.ClickEnable();
            Assert.True(control.IsTextEnabled(true));
            string testString = "test string";
            control.TextBox = testString;
            control.ClickEnable();
            Assert.True(control.IsTextEnabled(false));
            Assert.AreEqual(testString, control.TextBox);

        }


        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
