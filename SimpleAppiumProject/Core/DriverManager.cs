using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace SimpleAppiumProject.Core
{
    public class DriverManager
    {
        static IWebDriver driver;
        private static readonly Lazy<DriverManager> lazy =
     new(() => new DriverManager());
        public IWebDriver CurrentDriver (DriverOptions driverOptions = null) => GetDriver(driverOptions);
        public IWebDriver GetDriver(DriverOptions driverOptions = null)
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
        public static DriverManager GetInstance()
        {
            return lazy.Value;
        }
    }
}
