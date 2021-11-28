using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace SimpleAppiumProject.Core
{
    public class DriverManager
    {
        protected IWebDriver driver;
        public IWebDriver CurrentDriver (DriverOptions driverOptions) => GetDriver(driverOptions);
        public IWebDriver GetDriver(DriverOptions driverOptions)
        {
            if (driver == null)
            {
                driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), driverOptions);
            }
            return driver;
        }
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
