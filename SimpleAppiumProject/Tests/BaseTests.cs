using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SimpleAppiumProject.Core;
using System;
using Xunit;

namespace SimpleAppiumProject.Tests
{
    [Collection("Our Test Collection #1")]
    public abstract class BaseTests: IDisposable
    {
        public BaseDriverManager driverManager;
        public AppiumDriver<IWebElement> driver;

        public void Dispose()
        {
            driverManager.Quit();
        }
    }
}
