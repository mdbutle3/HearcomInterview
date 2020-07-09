using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Herokuapp_Automation
{
    class ExitIntentPage
    {
        private IWebDriver driver;
        public ExitIntentPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //moves cursor off of the window but selenium blows up when you leave the window for me
        public void LeavePage()
        {
            IWebElement test = driver.FindElement(By.Id("content"));
            Actions action = new Actions(driver);
            action.MoveToElement(test).MoveByOffset(0, 100).Build().Perform();
        }
    }
}
