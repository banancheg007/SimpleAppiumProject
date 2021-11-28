using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppiumProject.Core
{
    public class WebDriverManager
    {
        protected AppiumDriver<IWebElement> driver;

        private static readonly Lazy<WebDriverManager> lazy =
             new Lazy<WebDriverManager>(() => new WebDriverManager());
        public AppiumDriver<IWebElement> CurrentDriver => GetDriver();

        public AppiumDriver<IWebElement> GetDriver()
        {
            if (driver == null)
            {
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("deviceName", "AndoidEmulator");
                options.AddAdditionalCapability("PlatformName", "Android");

                /*
                    options.AddAdditionalCapability("appPackage", "com.google.android.calculator");
                    options.AddAdditionalCapability("appActivity", "com.android.calculator2.Calculator");
                }
                */

                options.AddAdditionalCapability(MobileCapabilityType.BrowserName, "chrome");
                options.AddAdditionalCapability("chromedriverExecutable", @"C:/drivers/chromedriver.exe");

                driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), options);

                //driver.Url = url;
            }
            return driver;
        }

        public static WebDriverManager GetInstance()
        {
            return lazy.Value;
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
