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
        NativeDriverManager driverManager = new NativeDriverManager();

        public void Dispose()
        {
            driverManager.Quit();
        }

        [Fact]
        public void NativeAppTest()
        {
            //Verify if the app is launched
            Assert.NotNull(driverManager.CurrentDriver.Context);

            //get from resource-id field
            driverManager.CurrentDriver.FindElementById("digit_7").Click();
            driverManager.CurrentDriver.FindElementById("op_sub").Click();
            driverManager.CurrentDriver.FindElementById("digit_5").Click();

            //get from content-desc field
            driverManager.CurrentDriver.FindElementByAccessibilityId("equals").Click();


            //get from class field
            string result = driverManager.CurrentDriver.FindElementByClassName("android.widget.TextView").Text;
            Assert.Equal("2", result);
        }
        [Fact]
        public void NativeAppTest2()
        {
            //Verify if the app is launched
            Assert.NotNull(driverManager.CurrentDriver.Context);

            //get from resource-id field
            driverManager.CurrentDriver.FindElementById("digit_7").Click();
            driverManager.CurrentDriver.FindElementById("op_sub").Click();
            driverManager.CurrentDriver.FindElementById("digit_5").Click();

            //get from content-desc field
            driverManager.CurrentDriver.FindElementByAccessibilityId("equals").Click();


            //get from class field
            string result = driverManager.CurrentDriver.FindElementByClassName("android.widget.TextView").Text;
            Assert.Equal("2", result);
        }
    }
}
