﻿using NUnit.Framework;
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
    class LoginPage
    {
        private IWebDriver driver;
        private string userName;
        private string password;

        public string UserName
        {
            get
            {
                return UserName;
            }
            //inputs the text to the username field
            set
            {
                driver.FindElement(By.Id("username")).SendKeys(value);
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return Password;
            }
            //inputs the text to the password field
            set
            {
                driver.FindElement(By.Id("password")).SendKeys(value);
                password = value;
            }
        }


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //submits the credentials
        public void Submit()
        {
            driver.FindElement(By.ClassName("radius")).Click();
            return;
        }

        //returns the notification message
        public string getMessage()
        {

            IWebElement message = driver.FindElement(By.Id("flash"));
            return message.Text;
        }
    }
}
