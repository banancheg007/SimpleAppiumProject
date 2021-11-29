using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SimpleAppiumProject.Core;
using SimpleAppiumProject.Pages.Calculator;
using Xunit;

namespace SimpleAppiumProject.Tests
{
    public class CalculatorTests: BaseTests
    {
        readonly CalculatorMainActivity calculatorMainActivity = new();
        public CalculatorTests()
        {
            options.AddAdditionalCapability("deviceName", "AndoidEmulator");
            options.AddAdditionalCapability("PlatformName", "Android");
            options.AddAdditionalCapability("appPackage", "com.google.android.calculator");
            options.AddAdditionalCapability("appActivity", "com.android.calculator2.Calculator");
            driver = (AppiumDriver<IWebElement>)DriverManager.GetInstance().GetDriver(options);
        }

        [Fact]
        public void SubstractionTest()
        {
            //get from resource-id field
            driver.FindElementById(calculatorMainActivity.digit7Id).Click();
            driver.FindElementById(calculatorMainActivity.subtractionOperationId).Click();
            driver.FindElementById(calculatorMainActivity.digit5Id).Click();
            //get from content-desc field
            driver.FindElementByAccessibilityId(calculatorMainActivity.equalsAccId).Click();
            //get from class field
            string result = driver.FindElementByClassName(calculatorMainActivity.resultFieldClass).Text;
            Assert.Equal("2", result);
        }

        [Fact]
        public void DeleteTest()
        {
            driver.FindElementById(calculatorMainActivity.digit7Id).Click();
            driver.FindElementById(calculatorMainActivity.digit7Id).Click();
            driver.FindElementById(calculatorMainActivity.digit7Id).Click();
            driver.FindElementById(calculatorMainActivity.deleteId).Click();
            driver.FindElementById(calculatorMainActivity.deleteId).Click();
            string result = driver.FindElementByClassName("android.widget.TextView").Text;
            Assert.Equal("7", result);
        }

        [Fact]
        public void ClearTest()
        {
            driver.FindElementById(calculatorMainActivity.digit7Id).Click();
            driver.FindElementById(calculatorMainActivity.digit5Id).Click();
            driver.FindElementById(calculatorMainActivity.digit9Id).Click();
            driver.FindElementById(calculatorMainActivity.digit5Id).Click();
            driver.FindElementById(calculatorMainActivity.clearId).Click();
            string result = driver.FindElementByClassName("android.widget.TextView").Text;
            Assert.Equal(string.Empty, result);
        }
    }
}
