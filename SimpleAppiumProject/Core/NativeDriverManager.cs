using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppiumProject.Core
{
    public class NativeDriverManager: BaseDriverManager
    {
        public override IWebDriver GetDriver()
        {
            if (driver == null)
            {
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("deviceName", "AndoidEmulator");
                options.AddAdditionalCapability("PlatformName", "Android");
                options.AddAdditionalCapability("appPackage", "com.google.android.calculator");
                options.AddAdditionalCapability("appActivity", "com.android.calculator2.Calculator");

                driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), options);

                //driver.Url = url;
            }
            return driver;
        }
    }
}
