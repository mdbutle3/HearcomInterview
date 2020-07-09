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

namespace Herokuapp_Automation
{
    class NewWindowPage
    {
        private IWebDriver driver;
        public NewWindowPage(IWebDriver driver) {
            this.driver = driver;
        }

        //clicks on the open new window button
        public void clickOpenNewWindow()
        {
            driver.FindElement(By.XPath("//*[@id='content']/div/a")).Click();
        }
    }
}
