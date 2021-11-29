using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SimpleAppiumProject.Core;
using System;
using Xunit;

namespace SimpleAppiumProject.Tests
{
    [Collection("My Test Collection")]
    public abstract class BaseTests: IDisposable
    {
        protected bool disposed = false;

        protected Waits waits = new();

        protected AppiumOptions options = new();

        public AppiumDriver<IWebElement> driver;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    DriverManager.GetInstance().Quit();
                }
                disposed = true;
            }
        }

        ~BaseTests()
        {
            Dispose(false);
        }
    }
}
