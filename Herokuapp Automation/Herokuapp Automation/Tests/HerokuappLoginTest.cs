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
//Command to run tests with output XML
// C:\Users\mdbut>dotnet test "C:\Users\mdbut\source\repos\NewRepo\Herokuapp Automation\Herokuapp Automation\bin\Debug\netcoreapp3.1\HerokuappAutomation.dll" -l:trx;LogFileName=C:\temp\TestOutput.xml


namespace Herokuapp_Automation.Tests
{
    class HerokuappLoginTest
    {
        IWebDriver driver;
   


        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome");
        }

        [Test]
        public void LoginTestSuccess()
        {
            driver.Url = "https://the-internet.herokuapp.com/login";
            LoginPage login = new LoginPage(driver);
            login.UserName = "tomsmith";
            login.Password = "SuperSecretPassword!";
            login.Submit();
            string messageText = login.getMessage();
            Assert.AreEqual("You logged into a secure area!\r\n×", messageText);
        }

        [Test]
        public void LoginTestWrongUserName()
        {
            driver.Url = "https://the-internet.herokuapp.com/login";
            LoginPage login = new LoginPage(driver);
            login.UserName = "Tomsmith";
            login.Password = "SuperSecretPassword!";
            login.Submit();
            string messageText = login.getMessage();
            Assert.AreEqual("Your username is invalid!\r\n×", messageText);
        }

        [Test]
        public void LoginTestWrongPassword()
        {
            driver.Url = "https://the-internet.herokuapp.com/login";
            LoginPage login = new LoginPage(driver);
            login.UserName = "tomsmith";
            login.Password = "superSecretPassword!";
            login.Submit();
            string messageText = login.getMessage();
            Assert.AreEqual("Your password is invalid!\r\n×", messageText);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
