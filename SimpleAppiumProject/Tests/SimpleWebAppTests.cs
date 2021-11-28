using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using SimpleAppiumProject.Core;
using Xunit;

namespace SimpleAppiumProject.Tests
{
    public class SimpleWebAppTests: BaseTests
    {
        public SimpleWebAppTests()
        {
            options.AddAdditionalCapability("deviceName", "AndoidEmulator");
            options.AddAdditionalCapability("PlatformName", "Android");
            options.AddAdditionalCapability(MobileCapabilityType.BrowserName, "chrome");
            options.AddAdditionalCapability("chromedriverExecutable", @"C:/drivers/chromedriver.exe");
            driver = (AppiumDriver<IWebElement>)driverManager.CurrentDriver(options);
        }

        [Fact]
        public void WebAppTest()
        {
            driver.Navigate().GoToUrl("http://www.google.com");

            driver.FindElementByCssSelector("input[name='q']").SendKeys("execute automation");
            driver.FindElementByCssSelector("input[name='q']").SendKeys(Keys.Enter);
        }
        [Fact]
        public void WebAppTest2()
        {
            driver.Navigate().GoToUrl("http://www.google.com");

            driver.FindElementByCssSelector("input[name='q']").SendKeys("execute automation");
            driver.FindElementByCssSelector("input[name='q']").SendKeys(Keys.Enter);
        }
    }
}
