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
    class HerokuappLoginTest
    {
        IWebDriver driver;
   


        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome");
        }

        //Tests logging in with proper credentials and makes sure that user is authenticated
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

        //Tests logging in with the wrong username and makes sure the message says it has the wrong username
        [Test]
        public void LoginTestWrongUserName()
        {
            driver.Url = "https://the-internet.herokuapp.com/login";
            LoginPage login = new LoginPage(driver);
            login.UserName = "Tomsmith";
            login.Password = "SuperSecretPassword!";
            //tries to sign in
            login.Submit();
            string messageText = login.getMessage();
            Assert.AreEqual("Your username is invalid!\r\n×", messageText);
        }

        //Tests logging in with the wrong password and makes sure that the message says it has the wrong password
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
