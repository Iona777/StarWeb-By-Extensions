using System;
using FluentAssertions;
using Star.Web.AutomatedUITests.Constants;
using Star.Web.AutomatedUITests.Framework.Configuration;
using Star.Web.AutomatedUITests.Framework.Utilities;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Models;
using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class LoginFeatureStepDefinitions
    {
        private static bool _isLoggedIn;

        private static Account _currentAccount;

        [Given("I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {
            LogOut();
        }

        [When(@"I log in with the username ""([^""]*)""")]
        public void WhenILogInWithTheUsername(string username)
        {
            GivenIHaveLoggedInWithTheUsername(username);
        }

        [When("I log in with an invalid account")]
        public void WhenILogInWithAnInvalidAccount()
        {
            GivenIHaveLoggedInWithTheUsername("InvalidAccount");

            _isLoggedIn = false;
        }

        [Given("I have navigated to the ecoi login page")]
        public void GivenIHaveNavigatedToTheEcoiLoginPage()
        {
            Browser.GoToPage(PagePaths.Login);
        }

        [Given("I have navigated to the ecoi support login page")]
        public void GivenIHaveNavigatedToTheEcoiSupportLoginPage()
        {
            Browser.GoToPage(PagePaths.SupportLogin);
        }

        [Given(@"I have logged in with the username ""([^""]*)""")]
        public void GivenIHaveLoggedInWithTheUsername(string standardUsername)
        {
            var loginAccount = typeof(LoginAccounts).GetField(standardUsername).GetValue(null) as Account;

            if (_currentAccount != loginAccount)
            {
                LogOut();
            }

            if (_isLoggedIn)
                return;

            if (loginAccount.IsSupportAccount)
            {
                GivenIHaveNavigatedToTheEcoiSupportLoginPage();
            }
            else
            {
                GivenIHaveNavigatedToTheEcoiLoginPage();
            }

            WhenILogInWithTheAccount(loginAccount);

            //Trying to do this with ExpectedConditons is troublesome. So, will keep this method
            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();
            
        }

        [Then("the profile button is shown")]
        public void ThenTheProfileButtonIsShown()
        {
            CommonPage.UserProfileButton.GetElementWithWait().Displayed.Should().BeTrue();
        }

        [Then("the logout button is shown")]
        public void ThenTheLogoutButtonIsShown()
        {
            CommonPage.LogoutButton.GetElementWithWait().Displayed.Should().BeTrue();
        }

        [Then("an error message is shown")]
        public void ThenAnErrorMessageIsShown()
        {
            if (Browser.GetCurrentUrl().Contains("auth0"))
            {
                LoginPage.OAuthErrorMessage.GetElementWithWait().Displayed.Should().BeTrue();
            }
            else
            {
                LoginPage.ErrorPanel.GetElementWithWait().Displayed.Should().BeTrue();
            }
        }

     
        private static void WhenILogInWithTheAccount(Account account)
        {
            if (Browser.GetCurrentUrl().Contains("auth0"))
            {  
                LoginPage.OAuthUsernameInput.EnterText(account.OAuthUsername, TimeSpan.FromMinutes(10));     
                LoginPage.OAuthPasswordInput.EnterText(account.OAuthPassword);
                LoginPage.OAuthContinueButton.ClickOnElement();
            }
            else
            {
                LoginPage.UserIdtext.EnterText(account.LegacyUsername, customTimeout: TimeSpan.FromMinutes(10));
                LoginPage.Passwordtext.EnterText(account.LegacyPassword);

                if (LoginPage.Reason.IsElementDisplayed(TimeSpan.FromSeconds(2)))
                {
                    LoginPage.Reason.EnterText($"Test Automation {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}");
                }

                LoginPage.LoginBtn.ClickOnElement();
            }

            _currentAccount = account;
            _isLoggedIn = true;
        }

        private static void LogOut()
        {
            SeleniumExecutor.DeleteAllCookies();
            _isLoggedIn = false;
        }
    }
}