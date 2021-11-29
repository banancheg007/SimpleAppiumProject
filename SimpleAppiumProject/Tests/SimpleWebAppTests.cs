using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using SimpleAppiumProject.Core;
using SimpleAppiumProject.Pages.BitBucket;
using Xunit;

namespace SimpleAppiumProject.Tests
{
    public class SimpleWebAppTests: BaseTests
    {
        readonly MainBucketPage mainBucketPage = new();
        readonly LoginPage loginPage = new();
        public SimpleWebAppTests()
        {
            options.AddAdditionalCapability("deviceName", "AndoidEmulator");
            options.AddAdditionalCapability("PlatformName", "Android");
            options.AddAdditionalCapability(MobileCapabilityType.BrowserName, "chrome");
            options.AddAdditionalCapability("chromedriverExecutable", @"C:/drivers/chromedriver.exe");
            driver = (AppiumDriver<IWebElement>)DriverManager.GetInstance().CurrentDriver(options);
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

        [Fact]
        public void LogInTest()
        {
            driver.Navigate().GoToUrl(Constants.startUrl);
            driver.FindElement(mainBucketPage.ToggleNavbarMenu).Click();
            driver.FindElement(mainBucketPage.LogInButton).Click();
            //Thread.Sleep(5000);
            waits.ElementIsVisible(loginPage.EmailField, driver);
            driver.FindElement(loginPage.EmailField).SendKeys(Constants.email);
            driver.FindElement(loginPage.ContinueButton).Click();
            //Thread.Sleep(5000);
            waits.ElementIsVisible(loginPage.PasswordField, driver);
            driver.FindElement(loginPage.PasswordField).SendKeys(Constants.password);
            driver.FindElement(loginPage.ContinueButton).Click();

            //driver.FindElementByCssSelector("input[name='q']").SendKeys("execute automation");
            //driver.FindElementByCssSelector("input[name='q']").SendKeys(Keys.Enter);
        }
    }
}
