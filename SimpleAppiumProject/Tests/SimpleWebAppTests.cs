﻿using OpenQA.Selenium;
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
        WebDriverManager driverManager = new WebDriverManager();

        public void Dispose()
        {
            driverManager.Quit();
        }

        [Fact]
        public void WebAppTest()
        {
            driverManager.CurrentDriver.Navigate().GoToUrl("http://www.google.com");

            driverManager.CurrentDriver.FindElementByCssSelector("input[name='q']").SendKeys("execute automation");
            driverManager.CurrentDriver.FindElementByCssSelector("input[name='q']").SendKeys(Keys.Enter);
        }
        [Fact]
        public void WebAppTest2()
        {
            driverManager.CurrentDriver.Navigate().GoToUrl("http://www.google.com");

            driverManager.CurrentDriver.FindElementByCssSelector("input[name='q']").SendKeys("execute automation");
            driverManager.CurrentDriver.FindElementByCssSelector("input[name='q']").SendKeys(Keys.Enter);
        }
    }
}
