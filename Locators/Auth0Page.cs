using OpenQA.Selenium;
using Star.Web.AutomatedUITests.Framework.Configuration;

namespace Star.Web.AutomatedUITests.Locators
{
    public class Auth0Page
    {
        public static By Username = By.Id("username");
        public static By Password = By.Id("password");
        public static By Continuebtn = By.CssSelector("button[data-action-button-primary=true]");
        public static string Url = ConfigurationProvider.GetConfiguration().BaseUrl;
    }
}
