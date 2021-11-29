using OpenQA.Selenium;

namespace SimpleAppiumProject.Pages.BitBucket
{
    public class PersonalPage
    {
        public By YourWorkButton = By.XPath("//*[contains(text(),'Your work')]");
        public By PullRequestsButton = By.XPath("//*[contains(text(),'Pull requests')]");
    }
}
