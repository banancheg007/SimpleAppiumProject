using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using SimpleAppiumProject.Core;
using SimpleAppiumProject.Pages.BitBucket;
using Xunit;

namespace SimpleAppiumProject.Tests
{
    public class BitBucketTests : BaseTests
    {
        readonly LoginPage loginPage = new();
        readonly PersonalPage personalPage = new();
        public BitBucketTests()
        {
            options.AddAdditionalCapability("deviceName", "AndoidEmulator");
            options.AddAdditionalCapability("PlatformName", "Android");
            options.AddAdditionalCapability(MobileCapabilityType.BrowserName, "chrome");
            options.AddAdditionalCapability("chromedriverExecutable", @"C:/drivers/chromedriver.exe");
            driver = (AppiumDriver<IWebElement>)DriverManager.GetInstance().CurrentDriver(options);
        }

        [Fact]
        public void LogInTest()
        {
            driver.Navigate().GoToUrl(Constants.startBitBucketUrl);
            driver.FindElement(loginPage.ToggleNavbarMenu).Click();
            driver.FindElement(loginPage.LogInButton).Click();
            waits.ElementIsVisible(loginPage.EmailField, driver);
            driver.FindElement(loginPage.EmailField).SendKeys(Constants.email);
            driver.FindElement(loginPage.ContinueButton).Click();
            waits.ElementIsVisible(loginPage.PasswordField, driver);
            driver.FindElement(loginPage.PasswordField).SendKeys(Constants.password);
            driver.FindElement(loginPage.ContinueButton).Click();
            waits.ElementIsVisible(personalPage.PullRequestsButton, driver);
            Assert.True(driver.FindElement(personalPage.YourWorkButton).Displayed);
            Assert.True(driver.FindElement(personalPage.YourWorkButton).Displayed);
        }
    }
}
