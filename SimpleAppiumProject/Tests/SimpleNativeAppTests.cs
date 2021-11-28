using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SimpleAppiumProject.Core;
using Xunit;

namespace SimpleAppiumProject.Tests
{
    public class SimpleNativeAppTests: BaseTests
    {
        public SimpleNativeAppTests()
        {
            options.AddAdditionalCapability("deviceName", "AndoidEmulator");
            options.AddAdditionalCapability("PlatformName", "Android");
            options.AddAdditionalCapability("appPackage", "com.google.android.calculator");
            options.AddAdditionalCapability("appActivity", "com.android.calculator2.Calculator");
            driver = (AppiumDriver<IWebElement>)driverManager.CurrentDriver(options);
        }
        [Fact]
        public void NativeAppTest()
        {
            //Verify if the app is launched
            Assert.NotNull(driver.Context);

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
            Assert.NotNull(driver.Context);

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
