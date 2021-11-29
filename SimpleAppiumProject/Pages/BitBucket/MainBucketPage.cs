using OpenQA.Selenium;

namespace SimpleAppiumProject.Pages.BitBucket
{
    public class MainBucketPage
    {
        public By LogInButton = By.XPath("(//*[contains(text(),'Log in')])[2]");
        public By ToggleNavbarMenu = By.CssSelector("button[id='jsToggleNavbarMenu']");
    }
}
