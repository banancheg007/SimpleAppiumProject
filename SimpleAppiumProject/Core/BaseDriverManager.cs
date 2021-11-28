using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppiumProject.Core
{
    abstract public class BaseDriverManager
    {
        protected AppiumDriver<IWebElement> driver;
        public AppiumDriver<IWebElement> CurrentDriver => GetDriver();
        public abstract AppiumDriver<IWebElement> GetDriver();
        public string GetUrl()
        {
            return driver.Url;
        }

        public void Quit()
        {

            if (driver == null)
                return;

            else
            {
                driver.Quit();
                driver = null;
            }

        }
    }
}
