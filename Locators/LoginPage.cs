using OpenQA.Selenium;

namespace Star.Web.AutomatedUITests.Locators
{
    public class LoginPage
    {
        public static By StarLogo = By.CssSelector(".logo");

        public static By UserIdtext = By.Id("tbUsername_tb");

        public static By Passwordtext = By.Id("tbPassword_tb");

        public static By OAuthUsernameInput = By.Id("username");

        public static By OAuthPasswordInput = By.Id("password");

        public static By OAuthContinueButton = By.CssSelector("button[data-action-button-primary=true]");

        public static By OAuthErrorMessage = By.Id("error-element-password");

        public static By Reason = By.Id("tbReasonForLogin_tb");

        public static By LoginBtn = By.Id("btnLogin");

        public static By EcoiHeaderTxt = By.CssSelector("#review-strip > div > span");

        public static By ErrorPanel = By.CssSelector(".error-panel");

        public static By BackToApplication = By.XPath(".//*[@id='redirect']/span/span[1]");

        public static By LogOutBtn = By.Id("logout");

        public static By SubmitBtn = By.Id("submit");

        public static By ResetPasswordUserNameIdtext = By.Id("username_tb");

        public static By NewPasswordtext = By.Id("new-password_tb");

        public static By NewPasswordtextConfirmation = By.Id("new-password-confirmation_tb");

        public static By CloseSuccessfullyChangedPasswordPopup = By.CssSelector("a[key='btnclose']");


    }
}