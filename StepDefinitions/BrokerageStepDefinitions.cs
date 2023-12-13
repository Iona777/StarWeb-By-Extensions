using FluentAssertions;
using FluentAssertions.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.Debugger;
using Star.Web.AutomatedUITests.ComponentHelper;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Locators.Compliance;
using Star.Web.AutomatedUITests.Models;
using System;
using System.Xml.Serialization;
using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{

    [Binding]
    public class BrokerageStepDefinitions
    {
        string PrimaryOwnerSurname = null;
        string AccountNumber = null;
        string PrimaryOwnerOfCreatedAccount = null;
        bool BrokerAccountCreated = false;

        [StepDefinition(@"the user searches for user account ""([^""]*)""")]
        public static void ThenTheUserSearchesForUserAccount(string userAccount)
        {
            BrokerAccountsPage.UserAccountSearchWrapper.ClickOnElement(TimeSpan.FromSeconds(60));
            BrokerAccountsPage.UserAccountSearch.EnterText(userAccount,TimeSpan.FromSeconds(60));
            CommonStepDefinitions.ClickOnSearchResults(userAccount);
        }

        [Given(@"the new broker data entry fields are displayed for primary owner ""([^""]*)""")]
        public void ThenTheNewBrokerDataEntryFieldsAreDisplayedForPrimaryOwner(string primaryOwner)
        {
            PrimaryOwnerSurname = primaryOwner.Substring(1);
            char.ToUpper(primaryOwner[0]);
            PrimaryOwnerSurname= char.ToUpper(PrimaryOwnerSurname[0]) + PrimaryOwnerSurname.Substring(1);

            PrimaryOwnerOfCreatedAccount = primaryOwner;

            BrokerAccountsPage.PrimaryOwner.GetVisibleElement().Text.Should().Contain(primaryOwner);
            BrokerAccountsPage.AccountTitle.IsElementDisplayed().Should().BeTrue();
            BrokerAccountsPage.AccountNumber.IsElementDisplayed().Should().BeTrue() ;
            BrokerAccountsPage.BrokerOfficeSearchWrapper.IsElementDisplayed().Should().BeTrue() ;                        
            BrokerAccountsPage.DateOpenedWrapper.IsElementDisplayed().Should().BeTrue();
            BrokerAccountsPage.AccountTypeSearchWrapper.IsElementDisplayed().Should().BeTrue();
            BrokerAccountsPage.DefaultAccountButtonBar.IsElementDisplayed().Should().BeTrue();
            BrokerAccountsPage.ReportingMethodWrapper.IsElementDisplayed().Should().BeTrue();
            BrokerAccountsPage.OverwriteReportingFrequencyButtonBar.IsElementDisplayed().Should().BeTrue();
                        
        }

        [When(@"the user enters default values for new broker account")]
        public void WhenTheUserEntersDefaultValuesForNewBrokerAccount()
        {
            AccountNumber = DefaultBroker.AccountNumber;

            BrokerAccountsPage.AccountTitle.EnterText(DefaultBroker.AccountTitle);
            BrokerAccountsPage.AccountNumber.EnterText(AccountNumber);
            BrokerAccountsPage.BrokerOfficeSearchWrapper.ClickOnElement();
            BrokerAccountsPage.BrokerOfficeSearch.EnterText(DefaultBroker.BrokerOffice);
            CommonStepDefinitions.ClickOnSearchResults(DefaultBroker.BrokerOffice);
            BrokerAccountsPage.DateOpenedMMWrapper.ClickOnElement();
            BrokerAccountsPage.DateOpenedMMInput.EnterText(DefaultBroker.DateOpenedMM);
            BrokerAccountsPage.DateOpenedDDWrapper.ClickOnElement();
            BrokerAccountsPage.DateOpenedDDInput.EnterText(DefaultBroker.DateOpenedDD);
            BrokerAccountsPage.DateOpenedYYWrapper.ClickOnElement();
            BrokerAccountsPage.DateOpenedYYYYInput.EnterText(DefaultBroker.DateOpenedYYYY);            
            BrokerAccountsPage.AccountTypeSearchWrapper.ClickOnElement();
            BrokerAccountsPage.AccountTypeSearch.EnterText(DefaultBroker.AccountType);
            CommonStepDefinitions.ClickOnSearchResults(DefaultBroker.AccountType);
            BrokerAccountsPage.ReportingMethodWrapper.ClickOnElement();
            BrokerAccountsPage.ReportingMethodValueElectronicFeed.ClickOnElement();
            BrokerAccountsPage.OverwriteReportingFrequencyYesButton.ClickOnElement();
            BrokerAccountsPage.ReportingFrequencyDaysOverwriteInput.EnterText("99");
        }

        [Then(@"the Broker Account is created successfully")]
        public void ThenTheBrokerAccountIsCreatedSuccessfully()
        {
            CommonStepDefinitions.ThenTheNotificationShouldAppearAndThenDisappear();

            try
            {
                CommonPage.LoadingOverlay.WaitUntilElementIsDisplayed(TimeSpan.FromSeconds(2));
            }
            catch (Exception e)
            {
                //The element did not appear, just continue
            }
            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();

            BrokerAccountsPage.accountOwnerFilter.ClearValue();
            BrokerAccountsPage.accountNumberFilter.ClearValue();
            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();
            BrokerAccountsPage.accountNumberFilter.EnterText(AccountNumber);
            //Make sure the overlay has been and gone
            CommonPage.LoadingOverlay.WaitUntilElementIsDisplayed();
            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();

            //This filters the table on the account number
            var row = TableElements.WaitForNthColOfNthRowToContainText(table: BrokerAccountsPage.BrokerAccountsTable, rowNo: 2, columnNo: 2, searchText: AccountNumber);

            TableElements.GetRowNthColumn(row, 1).Text.Should().Contain(PrimaryOwnerSurname);
            TableElements.GetRowNthColumn(row, 2).Text.Should().Be(AccountNumber);
            TableElements.GetRowNthColumn(row, 3).Text.Should().Be(DefaultBroker.BrokerOffice);
            TableElements.GetRowNthColumn(row, 4).Text.Should().Be(DefaultBroker.AccountType);
            TableElements.GetRowNthColumn(row, 7).Text.Should().Be(DefaultBroker.AccountStatus);

            BrokerAccountCreated = true;
        }

        [Given(@"I have created a broker account for primary owner ""([^""]*)""")]
        public void GivenIHaveCreatedABrokerAccountForPrimaryOwner(string requiredPrimaryOwner)
        {
            if (PrimaryOwnerOfCreatedAccount != requiredPrimaryOwner || BrokerAccountCreated == false)
            {
                CreateBrokerAccount();
            }
        }

        public void CreateBrokerAccount()
        {
            string subMenu = "Accounts";
            string menuName = "Brokerage";
            string accordionName = "BROKER ACCOUNTS";
            string page = "Broker Accounts";
            string area = "Compliance";
            //User account and primary owner use same value
            string primaryOwner = "abron";

            MenuNavigationStepDefinitions.WhenTheUserSelectsFromTheMenu(subMenu, menuName);
            AccordionHelper.OpenAccordionByName(accordionName, page, area);

            By accordion = AccordionHelper.GetAccordionElementByName(accordionName, page, area);
            AccordionHelper.IsTheAccordionElementOpen(accordion).Should().BeTrue();

            ThenTheUserSearchesForUserAccount(primaryOwner);
            ThenTheNewBrokerDataEntryFieldsAreDisplayedForPrimaryOwner(primaryOwner);
            WhenTheUserEntersDefaultValuesForNewBrokerAccount();
            CommonStepDefinitions.WhenTheUserClicksOnTheSaveButton();
            ThenTheBrokerAccountIsCreatedSuccessfully();
            CommonStepDefinitions.ThenTheNotificationShouldAppearAndThenDisappear();
        }


    }
}