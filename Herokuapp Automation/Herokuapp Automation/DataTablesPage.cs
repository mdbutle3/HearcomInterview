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
    class DataTablesPage
    {
        private IWebDriver driver;
        private Boolean lastNameSorted = false;
        public DataTablesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Boolean SortExample1LastName()
        {
            IWebElement table1 = driver.FindElement(By.Id("table1"));
            table1.FindElement(By.XPath(".//th[1]")).Click();
            lastNameSorted = !lastNameSorted;
            return lastNameSorted;
        }

        public Boolean SortExample2FirstName()
        {
            IWebElement table1 = driver.FindElement(By.Id("table2"));
            table1.FindElement(By.XPath(".//th[2]")).Click();
            lastNameSorted = !lastNameSorted;
            return lastNameSorted;
        }

        public IList<IWebElement> getExample1LastNames()
        {
            IWebElement table1 = driver.FindElement(By.Id("table1"));
            return table1.FindElements(By.XPath(".//tbody/tr/td[1]"));
        }

        public IList<IWebElement> getExample2FirstNames()
        {
            IWebElement table1 = driver.FindElement(By.Id("table1"));
            return table1.FindElements(By.XPath(".//tbody/tr/td[2]"));
        }
    }
}
