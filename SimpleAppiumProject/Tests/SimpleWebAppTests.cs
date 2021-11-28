using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SimpleAppiumProject.Core;
using Xunit;

namespace SimpleAppiumProject.Tests
{
    public class SimpleWebAppTests: BaseTests
    {
        public SimpleWebAppTests()
        {
            driverManager = new WebDriverManager();
            driver = (AppiumDriver<IWebElement>)driverManager.CurrentDriver;
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
