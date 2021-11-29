using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using SimpleAppiumProject.Core;
using SimpleAppiumProject.Pages.Google;
using Xunit;

namespace SimpleAppiumProject.Tests
{
    public class GoogleTests : BaseTests
    {
        readonly SearchPage searchPage = new();
        public GoogleTests()
        {
            options.AddAdditionalCapability("deviceName", "AndoidEmulator");
            options.AddAdditionalCapability("PlatformName", "Android");
            options.AddAdditionalCapability(MobileCapabilityType.BrowserName, "chrome");
            options.AddAdditionalCapability("chromedriverExecutable", @"C:/drivers/chromedriver.exe");
            driver = (AppiumDriver<IWebElement>)DriverManager.GetInstance().CurrentDriver(options);
        }

        [Fact]
        public void SearchTest()
        {
            driver.Navigate().GoToUrl(Constants.startGoogletUrl);
            driver.FindElement(searchPage.SearchField).SendKeys(Constants.searchPhrase);
            driver.FindElement(searchPage.SearchField).SendKeys(Keys.Enter);
            waits.ElementIsVisible(searchPage.FirstResultReference, driver);
            Assert.Contains(Constants.searchPhrase, driver.FindElement(searchPage.FirstResultReference).Text);
        }
    }
}
