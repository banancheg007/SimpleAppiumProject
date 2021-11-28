using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace SimpleAppiumProject.Core
{
    public class WebDriverManager: BaseDriverManager
    {
        public override IWebDriver GetDriver()
        {
            if (driver == null)
            {
                AppiumOptions options = new();
                options.AddAdditionalCapability("deviceName", "AndoidEmulator");
                options.AddAdditionalCapability("PlatformName", "Android");
                options.AddAdditionalCapability(MobileCapabilityType.BrowserName, "chrome");
                options.AddAdditionalCapability("chromedriverExecutable", @"C:/drivers/chromedriver.exe");

                driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), options);
            }
            return driver;
        }
    }
}
