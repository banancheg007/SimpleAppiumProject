using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SimpleAppiumProject.Core
{
    public class Waits
    {
        public IWebElement ElementIsVisible(By locator, IWebDriver driver)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(20));
            IWebElement searchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            return searchResult;
        }

        public IWebElement ElementIsClickable(By locator, IWebDriver driver)
        {
            DefaultWait<IWebDriver> fluentWait = new(driver)
            {
                Timeout = TimeSpan.FromSeconds(20),
                PollingInterval = TimeSpan.FromMilliseconds(250)
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return fluentWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
