using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.LayerTree;
using Star.Web.AutomatedUITests.ComponentHelper;
using Star.Web.AutomatedUITests.Framework.Configuration;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Locators.Compliance;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class CommonStepDefinitions
    {
        private static readonly Random random = new Random();

        [When("the user expands all accordions on the page")]
        public void WhenTheUserExpandsAllAccordionsOnThePage()
        {
            while (CommonPage.AllClosedAccordionHeaders.IsDisplayed())
            {
                CommonPage.AllClosedAccordionHeaders.ClickWithWait();
                CommonPage.AccordionLoadingSpinner.WaitUntilElementIsNotDisplayed();
            }
        }
                      
        [StepDefinition(@"the user expands ""([^""]*)"" accordion on the ""([^""]*)"" page in the ""([^""]*)"" area")]
        public static void WhenTheUserExpandsAccordionOnThePageInTheArea(string accordionName, string page, string area)
        {
            AccordionHelper.OpenAccordionByName(accordionName, page, area);
        }

        [StepDefinition(@"the ""([^""]*)"" accordion on the ""([^""]*)"" page in the ""([^""]*)"" area opens without error")]
        public static void ThenTheAccordionOnThePageInTheAreaOpensWithoutError(string accordionName, string page, string area)
        {
            By accordion = AccordionHelper.GetAccordionElementByName(accordionName, page, area);
            
            AccordionHelper.IsTheAccordionElementOpen(accordion).Should().BeTrue();
        }


        [Then(@"the notification should appear and then disappear")]
        public static void ThenTheNotificationShouldAppearAndThenDisappear()
        {
            //There is a risk with this check that the notification will have disappeared before
            //we can check for its appearance.
            CommonStepDefinitions.CheckNotificationIsDisplayed();
            CommonStepDefinitions.CheckNotificationsNotDisplayed();
        }

        [StepDefinition(@"the user clicks on the Save button")]
        public static void WhenTheUserClicksOnTheSaveButton()
        {
            CommonPage.SaveButton.ClickOnElement();
            CommonPage.NotificationMessage.WaitUntilElementIsNotDisplayed();
        }


        [When(@"the user selects first row from User Groups popup")]
        public static void UserSelectsFirstRowFromUserGroup()
        {
            CommonPage.FirstRowFromUserGroupsPopup.Click();
            CommonPage.OkButtonUserGroupsPopup.Click();
        }

        public static void ClickOnSearchResults(string searchString)
        {
            string cssString = $"tr[title*='{searchString}']";
            By searchResultsLocator = By.CssSelector(cssString);

            searchResultsLocator.ClickOnElement(TimeSpan.FromSeconds(30));
        }

        public static int GenerateRandomNumber()
        {   
            //int randomNumber = random.Next(1000);
            int randomNumber = random.Next(1000,9999);

            return randomNumber;
        }

        public static void CheckNotificationIsDisplayed()
        {
            CommonPage.NotificationContainer.GetVisibleElement();
        }

        public static void CheckNotificationsNotDisplayed()
        {
            CommonPage.NotificationContainer.WaitUntilElementIsNotDisplayed();
        }

    }
}