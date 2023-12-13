using TechTalk.SpecFlow;

using FluentAssertions;

using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Locators.Compliance;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class BlackoutListsStepDefinitions
    {
        [Then(@"the blackout list page should load successfully")]
        public void ThenTheBlackoutListPageShouldLoadSuccessfully()
        {
            BlackoutListPage.CreateNewBlackoutSecurityButton.GetElement().Displayed.Should().BeTrue();
            BlackoutListPage.BlackoutListSecuritiesAccordion.GetElement().Displayed.Should().BeTrue();
            BlackoutListPage.CreateNewBlackoutIssuerButton.GetElement().Displayed.Should().BeTrue();
            BlackoutListPage.BlackoutListsIssuerAccordion.GetElement().Displayed.Should().BeTrue();
        }

        [When("the user expands all accordions on the Blackout List page")]
        public void WhenTheUserExpandsAllAccordionsOnTheBlackoutListPage()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Blackout List landing page loads successfully")]
        public void ThenTheUserIsLandedToTheBlackoutListLandingPageLoadsSuccessfully()
        {
            throw new PendingStepException();
        }

        [When("the user expands all accordions on the Open Order List page")]
        public void WhenTheUserExpandsAllAccordionsOnTheOpenOrderListPage()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Open Order List landing page loads successfully")]
        public void ThenTheUserIsLandedToTheOpenOrderListLandingPageLoadsSuccessfully()
        {
            throw new PendingStepException();
        }

        [When("the user expands all accordions on the Restricted List page")]
        public void WhenTheUserExpandsAllAccordionsOnTheRestrictedListPage()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Restricted List landing page loads successfully")]
        public void ThenTheUserIsLandedToTheRestrictedListLandingPageLoadsSuccessfully()
        {
            throw new PendingStepException();
        }

        [When("the user expands all accordions on the Proprietary Fund List page")]
        public void WhenTheUserExpandsAllAccordionsOnTheProprietaryFundListPage()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Proprietary Fund List landing page loads successfully")]
        public void ThenTheUserIsLandedToTheProprietaryFundListLandingPageLoadsSuccessfully()
        {
            throw new PendingStepException();
        }

        [When("the user expands all accordions on the Research List page")]
        public void WhenTheUserExpandsAllAccordionsOnTheResearchListPage()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Research List landing page loads successfully")]
        public void ThenTheUserIsLandedToTheResearchListLandingPageLoadsSuccessfully()
        {
            throw new PendingStepException();
        }

        [When("the user expands all accordions on the Legal List Submenu")]
        public void WhenTheUserExpandsAllAccordionsOnTheLegalListSubmenu()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Legal List landing page loads successfully")]
        public void ThenTheUserIsLandedToTheLegalListLandingPageLoadsSuccessfully()
        {
            throw new PendingStepException();
        }

        [When("the user exapnds all accordions on the Watch List page")]
        public void WhenTheUserExapndsAllAccordionsOnTheWatchListPage()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Watch List landing page loads successfully")]
        public void ThenTheUserIsLandedToTheWatchListLandingPageLoadsSuccessfully()
        {
            throw new PendingStepException();
        }

        [When("the user expands all accordions on the Custom List page")]
        public void WhenTheUserExpandsAllAccordionsOnTheCustomListPage()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Custom List landing page loads successfully")]
        public void ThenTheUserIsLandedToTheCustomListLandingPageLoadsSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}