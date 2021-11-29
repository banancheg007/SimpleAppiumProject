using OpenQA.Selenium;

namespace SimpleAppiumProject.Pages.BitBucket
{
    public class LoginPage
    {
        public By EmailField = By.XPath("//*[@placeholder='Enter email']");
        public By PasswordField = By.XPath("//*[@name='password']");
        public By ContinueButton = By.XPath("//*[@id='login-submit']");
    }
}
