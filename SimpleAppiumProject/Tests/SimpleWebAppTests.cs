using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SimpleAppiumProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleAppiumProject.Tests
{
    [Collection("Our Test Collection #1")]
    public class SimpleWebAppTests: IDisposable
    {
        readonly WebDriverManager driverManager;
        readonly AppiumDriver<IWebElement> driver;

        public void Dispose()
        {
            driverManager.Quit();
        }

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
