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
    class DataTablesTests
    {
        IWebDriver driver;



        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome");
            driver.Url = "https://the-internet.herokuapp.com/tables";
        }

        [Test]
        public void SortLastNameExample1()
        {
            DataTablesPage tablespage = new DataTablesPage(driver);
            tablespage.SortExample1LastName();
            IList<IWebElement> elements = tablespage.getExample1LastNames();
            Assert.True(areAlphabetical(elements));
            tablespage.SortExample1LastName();
            elements = tablespage.getExample1LastNames();
            Assert.True(areAlphabetical(elements, false));

        }

        [Test]
        public void SortFirstNameExample2()
        {
            DataTablesPage tablespage = new DataTablesPage(driver);
            tablespage.SortExample2FirstName();
            IList<IWebElement> elements = tablespage.getExample2FirstNames();
            Assert.True(areAlphabetical(elements));
            tablespage.SortExample2FirstName();
            elements = tablespage.getExample2FirstNames();
            Assert.True(areAlphabetical(elements, false));
        }

        //returns true if sorted correctly. It will default to ascending order but if you add a value of false it will check if they are descending values
        //This won't work if the values are the same need to fix that.
        public Boolean areAlphabetical(IList<IWebElement> list, Boolean ascending = true)
        {
            int asc = 1;
            if (!ascending)
            {
                asc = -1;
            }
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (StringComparer.Ordinal.Compare(list[i].Text, list[i + 1].Text) == asc)
                {
                    return false;
                }
            }
            return true;
        }


        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
