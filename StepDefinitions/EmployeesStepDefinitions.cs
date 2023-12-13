using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using Star.Web.AutomatedUITests.ComponentHelper;
using Star.Web.AutomatedUITests.Framework.Utilities;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Locators.Compliance;
using Star.Web.AutomatedUITests.Models;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class EmployeesStepDefinitions
    {
        public string NewUserName = null;
        public static bool NewUserCreated = false;
        public static bool NewUserActivated = false;
        public static bool NewUserPasswordChanged = false;
        public static string NewUserId = null;

        [Given(@"the user enters default values for new user account")]
        public void GivenTheUserEntersDefaultValuesForNewUserAccount()
        {
            EnterDefaultValuesForNewUserAccount();
        }

        private void EnterDefaultValuesForNewUserAccount()
        {
            NewUserName = DefaultUser.UserName;

            UserAccountsPage.FirstName.EnterText(DefaultUser.FirstName);
            UserAccountsPage.MiddleName.EnterText(DefaultUser.MiddleName);
            UserAccountsPage.LastName.EnterText(DefaultUser.LastName);
            UserAccountsPage.UserName.EnterText(NewUserName);
            UserAccountsPage.JobTitle.EnterText(DefaultUser.JobTitle);
            UserAccountsPage.EmployeCode.EnterText(DefaultUser.EmployeeCode);
            UserAccountsPage.OfficeNameDropDown.ClickOnElement();
            UserAccountsPage.OfficeNameInputBox.EnterTextAndPressEnter(DefaultUser.OfficeName);
            UserAccountsPage.PhoneNumber.EnterText(DefaultUser.PhoneNumer);
            enterDefaultEmailAddress();
            UserAccountsPage.EmailDescription.ClickOnElement();
            UserAccountsPage.EmailDescriptionInputBox.EnterText(DefaultUser.EmailDescription);
            UserAccountsPage.EnableStandardAuthentication.ClickOnElement();
            
        }

      

        public static void enterDefaultEmailAddress()
        {
            UserAccountsPage.EmailAddress.ClickOnElement();
            UserAccountsPage.EmailAddressMasked.WaitUntilElementIsNotDisplayed();
            UserAccountsPage.EmailAddressInputBox.EnterText(DefaultUser.EmailAddress);
        }

        [Then(@"the User Account is created successfully")]
        public void ThenTheUserAccountIsCreatedSuccessfully()
        {
            var UserNameRow = UserAccountDetailsPage.DetailsTable.GetTableNthRow(0);
            var statusRow = UserAccountDetailsPage.DetailsTable.GetTableNthRow(1);

            TableElements.GetRowNthColumn(UserNameRow,1).Text.Should().Be(NewUserName);
            TableElements.GetRowNthColumn(statusRow, 1).Text.Should().Be("Pending Active");

            NewUserCreated = true;
            String currentURL = Browser.GetCurrentUrl();

            NewUserId = currentURL.Substring(currentURL.Length-32);
        }
                
                
        [When(@"the user clicks Activate on the UserAccountDetails page")]
        public void WhenTheUserClicksActivateOnTheUserAccountDetailsPage()
        {
            UserAccountDetailsPage.ActivateButton.ClickOnElement();
        }


        [When(@"the user fills in a comment for activate user and clicks on the Save button")]
        public void WhenTheUserFillsInACommentForActivateUserAndClicksOnTheSaveButton()
        {
            UserAccountDetailsPage.CommentField.EnterText("Creating a new user");
            UserAccountDetailsPage.ActivateUserSaveButton.ClickOnElement();
        }


       

        [Then(@"the new user has been activated")]
        public void ThenTheNewUserHasBeenActivated()
        {
            //Gets the first row of the DetailsTable
            var UserNameRowActive = UserAccountDetailsPage.DetailsTable.GetTableNthRow(0);
            IWebElement StatusRowActive = null;

            //Checks that the text of the 2nd column of the UserNameRowActive row equals value of NewUserName
            TableElements.GetRowNthColumn(UserNameRowActive, 1).Text.Should().Be(NewUserName);

            //Gets the second row of the DetailsTable
            StatusRowActive = UserAccountDetailsPage.DetailsTable.GetTableNthRow(1);

            //Checks that the text of the 2nd column of the StatusRowActive row equals Active
            TableElements.GetRowNthColumn(StatusRowActive, 1).WaitForElementByText("Active").Should().BeTrue();

            NewUserActivated = true;
        }                    

        [When(@"the user clicks on the Change Password button")]
        public void WhenTheUserClicksOnTheChangePasswordButton()
        {
            CommonStepDefinitions.CheckNotificationsNotDisplayed();
            UserAccountDetailsPage.ChangePasswordButton.ClickOnElement();
        }

     

        [When(@"the user enters new a password and confirmation")]
        public void WhenTheUserEntersNewAPasswordAndConfirmation()
        {
            UserAccountDetailsPage.NewPasswordField.EnterText(DefaultUser.Password);
            UserAccountDetailsPage.ConfirmPasswordField.EnterText(DefaultUser.Password);
        }


        [Then(@"the new password popup has disappeared")]
        public void ThenTheNewPasswordPopupHasDisappeared()
        {
            UserAccountDetailsPage.ChangePasswordFormPopup.WaitUntilElementIsNotDisplayed();
        }


        [Then(@"new user account password has been changed")]
        public void ThenNewUserAccountPasswordHasBeenChanged()
        {
            NewUserPasswordChanged = true;
        }


        //Can remove this later
        [StepDefinition(@"the new user is activated")]
        public void WhenTheNewUserIsActivatedAndThePasswordUpdated()
        {
            UserAccountDetailsPage.ActivateButton.ClickOnElement();
            UserAccountDetailsPage.CommentField.EnterText("Creating a new user");
            UserAccountDetailsPage.ActivateUserSaveButton.ClickOnElement();

            var UserNameRowActive = UserAccountDetailsPage.DetailsTable.GetTableNthRow(0);
            IWebElement StatusRowActive = null;
                        
            TableElements.GetRowNthColumn(UserNameRowActive, 1).Text.Should().Be(NewUserName);        

            StatusRowActive = UserAccountDetailsPage.DetailsTable.GetTableNthRow(1);
            TableElements.GetRowNthColumn(StatusRowActive, 1).WaitForElementByText("Active").Should().BeTrue();
                         
        }

        [StepDefinition(@"the activate popup has disappeared")]
        public void TheActivatePopupHasDisappeared()
        {
            UserAccountDetailsPage.ActiveUserFormPopup.WaitUntilElementIsNotDisplayed();
        }

        [Then(@"I click on the Change Password button")]
        public void WhenIClickOnTheChangePasswordButton()
        {
            CommonStepDefinitions.CheckNotificationsNotDisplayed();
            UserAccountDetailsPage.ChangePasswordButton.ClickOnElement(TimeSpan.FromSeconds(5), 5);
        }



        [Given(@"a new user has been created successfully")]
        public void GivenANewUserHasBeenCreatedSuccessfully()
        {
            if (NewUserCreated ==false)
            {
                CreateNewUser();
            }
        }


        [Given(@"a new user account has been activated")]
        public void GivenANewUserAccountHasBeenActivated()
        {
            if (NewUserActivated == false)
            {
                ActivateNewUser();
            }
           
        }

        [Given(@"a new user account password has been changed")]
        public void GivenANewUserAccountPasswordHasBeenChanged()
        {
            if (NewUserPasswordChanged ==false)
            {
                ChangeNewUserPassword();
            }
        }

        [Then(@"the new user can login with new user default credentials")]
        public void ThenTheNewUserCanLoginWithNewCredentials()
        {         
            LoginPage.UserIdtext.EnterText(NewUserName, customTimeout: TimeSpan.FromSeconds(60));
            LoginPage.Passwordtext.EnterText(DefaultUser.Password);

            if (LoginPage.Reason.IsElementDisplayed(TimeSpan.FromSeconds(2)))
            {
                LoginPage.Reason.EnterText($"Test Automation {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}");
            }

            LoginPage.LoginBtn.ClickOnElement();
            LoginPage.NewPasswordtext.EnterText(DefaultUser.NewPassword);
            LoginPage.NewPasswordtextConfirmation.EnterText(DefaultUser.NewPassword);
            LoginPage.SubmitBtn.ClickOnElement();
            LoginPage.CloseSuccessfullyChangedPasswordPopup.ClickOnElement();

            CommonPage.UserProfileButton.GetElementText().Should().Be(NewUserName);
            CommonPage.LogoutButton.ClickOnElement();
            CommonPage.ConfirmLogoutOK.ClickOnElement();
        }

        public void CreateNewUser()
        {
            string subMenu = "User Accounts";
            string menuName = "Employees";
            string userAccountAccordionName = "USER ACCOUNTS";
            string userAccountAccordionDetailsName = "USER ACCOUNT DETAILS";
            string userAccountPage = "User Accounts";
            string userAccountDetailsPage = "User Account Details";
            string area = "Compliance";
                                    
            MenuHelper.OpenSubMenu(menuName, subMenu);
            AccordionHelper.OpenAccordionByName(userAccountAccordionName, userAccountPage, area);
            By userAccountAccordion = AccordionHelper.GetAccordionElementByName(userAccountAccordionName, userAccountPage, area);
            AccordionHelper.IsTheAccordionElementOpen(userAccountAccordion).Should().BeTrue();
                        
            EnterDefaultValuesForNewUserAccount();
            CommonStepDefinitions.WhenTheUserClicksOnTheSaveButton(); 
            
            AccordionHelper.OpenAccordionByName(userAccountAccordionDetailsName, userAccountDetailsPage, area);
            By userAccountDetailsAccordion = AccordionHelper.GetAccordionElementByName(userAccountAccordionDetailsName, userAccountDetailsPage, area);
            AccordionHelper.IsTheAccordionElementOpen(userAccountDetailsAccordion).Should().BeTrue();

            ThenTheUserAccountIsCreatedSuccessfully();
        }


        public void ActivateNewUser()
        {
            GivenANewUserHasBeenCreatedSuccessfully();
            MenuNavigationStepDefinitions.GivenIAmOnThe("UserAccountDetails");
            WhenTheUserClicksActivateOnTheUserAccountDetailsPage();
            WhenTheUserFillsInACommentForActivateUserAndClicksOnTheSaveButton();
            TheActivatePopupHasDisappeared();
            CommonStepDefinitions.ThenTheNotificationShouldAppearAndThenDisappear();
            ThenTheNewUserHasBeenActivated();
        }

        public void ChangeNewUserPassword()
        {
            GivenANewUserHasBeenCreatedSuccessfully();
            MenuNavigationStepDefinitions.GivenIAmOnThe("UserAccountDetails");
            WhenTheUserClicksOnTheChangePasswordButton();
            WhenTheUserEntersNewAPasswordAndConfirmation();
            CommonStepDefinitions.WhenTheUserClicksOnTheSaveButton();
            ThenTheNewPasswordPopupHasDisappeared();
            CommonStepDefinitions.ThenTheNotificationShouldAppearAndThenDisappear();
            ThenNewUserAccountPasswordHasBeenChanged();
        }
    }

    


}