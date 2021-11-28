using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SimpleAppiumProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAppiumProject.Tests
{
    public abstract class BaseTests
    {
        readonly BaseDriverManager driverManager;
        readonly AppiumDriver<IWebElement> driver;

        public void Dispose()
        {
            driverManager.Quit();
        }
    }
}
