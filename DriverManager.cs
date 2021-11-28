using System;

namespace Core
{
	public class DriverManager
	{
        private IWebDriver driver;
        string url = ConfigurationManager.AppSettings["URL"];

        private static readonly Lazy<DriverManager> lazy = new Lazy<DriverManager>(() => new DriverManager());

        public IWebDriver CurrentDriver => GetDriver();

        public IWebDriver GetDriver()
        {

            if (driver == null)
            {
                driver = new ChromeDriver();

                driver.Url = url;

                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static DriverWrapper GetInstance()
        {
            return lazy.Value;
        }

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
