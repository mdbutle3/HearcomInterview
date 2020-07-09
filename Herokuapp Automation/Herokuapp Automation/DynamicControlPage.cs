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
    //Class for the dyanmic control page
    class DynamicControlPage
    {
        private IWebDriver driver;
        private string textBox;

        
        public string TextBox
        {
            // reads the value from the text box and returns it
            get
            {
                return driver.FindElement(By.XPath("//*[@id='input-example']/input")).GetAttribute("value");
            }
            //sets the value from teh text box
            set
            {
                driver.FindElement(By.XPath("//*[@id='input-example']/input")).SendKeys(value);
                textBox = value;
            }
        }

        public DynamicControlPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //clicks the enable/disable button
        public void ClickEnable()
        {
            driver.FindElement(By.XPath("//*[@id='input-example']/button")).Click();
        }

        //Waits until text box is enabled if boolean param is true or disabled if param is false
        public Boolean IsTextEnabled(Boolean enabled)
        {
            IWebElement textBox = driver.FindElement(By.XPath("//*[@id='input-example']/input"));
            for(int i = 0; i<20; i++)
            {
                if (textBox.Enabled == enabled)
                {
                    return true;
                }
                Thread.Sleep(1000);
            }
            return false;
        }

    }
}
