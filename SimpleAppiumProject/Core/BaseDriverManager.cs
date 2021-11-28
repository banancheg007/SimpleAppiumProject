using OpenQA.Selenium;

namespace SimpleAppiumProject.Core
{
    abstract public class BaseDriverManager
    {
        protected IWebDriver driver;
        public IWebDriver CurrentDriver => GetDriver();
        public abstract IWebDriver GetDriver();
        public string GetUrl()
        {
            return driver.Url;
        }

        public void Quit()
        {

            if (driver == null)
                return;

            else
            {
                driver.Quit();
                driver = null;
            }

        }
    }
}
