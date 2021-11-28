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
    public class SimpleNativeAppTests: IDisposable
    {
        readonly NativeDriverManager driverManager;
        readonly AppiumDriver<IWebElement> driver;
        public SimpleNativeAppTests()
        {
            driverManager = new NativeDriverManager();
            driver = (AppiumDriver<IWebElement>)driverManager.CurrentDriver;
        }
        public void Dispose()
        {
            driverManager.Quit();
        }

        [Fact]
        public void NativeAppTest()
        {
            //Verify if the app is launched
            Assert.NotNull(((AppiumDriver<IWebElement>)driverManager.CurrentDriver).Context);

            //get from resource-id field
            driver.FindElementById("digit_7").Click();
            driver.FindElementById("op_sub").Click();
            driver.FindElementById("digit_5").Click();

            //get from content-desc field
            driver.FindElementByAccessibilityId("equals").Click();


            //get from class field
            string result = driver.FindElementByClassName("android.widget.TextView").Text;
            Assert.Equal("2", result);
        }

        [Fact]
        public void NativeAppTest2()
        {
            //Verify if the app is launched
            Assert.NotNull(((AppiumDriver<IWebElement>)driverManager.CurrentDriver).Context);

            //get from resource-id field
            driver.FindElementById("digit_7").Click();
            driver.FindElementById("op_sub").Click();
            driver.FindElementById("digit_5").Click();

            //get from content-desc field
            driver.FindElementByAccessibilityId("equals").Click();


            //get from class field
            string result = driver.FindElementByClassName("android.widget.TextView").Text;
            Assert.Equal("2", result);
        }
    }
}
