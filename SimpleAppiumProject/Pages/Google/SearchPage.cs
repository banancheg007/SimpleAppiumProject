using OpenQA.Selenium;

namespace SimpleAppiumProject.Pages.Google
{
    public class SearchPage
    {
        public By SearchField = By.CssSelector("input[name = 'q']");
        public By FirstResultReference = By.XPath("(//*[contains(text(),'Search Results')]/following::div[1]//descendant::*[@role='text'])[1]");
    }
}
