using FluentAssertions;

using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Locators.Compliance;

using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class ReviewStepDefinitions
    {
        [Then("the To Review page displays correctly")]
        public void ThenTheToReviewPageDisplaysCorrectly()
        {
            ReviewPage.PageHeader.GetElementWithWait().Text.Should().Be("To Review");
            ReviewPage.MyItemsFilterButtonBar.GetElementWithWait().Displayed.Should().BeTrue();
            ReviewPage.UnavailableItemsButtonBar.GetElementWithWait().Displayed.Should().BeTrue();
            ReviewPage.AvailableItemsButtonBar.GetElementWithWait().Displayed.Should().BeTrue();

            ReviewPage.TradeRequestAccordion.GetElementWithWait().Displayed.Should().BeTrue();
            ReviewPage.PrivateTransactionsAccordion.GetElementWithWait().Displayed.Should().BeTrue();
            ReviewPage.DocumentsAccordion.GetElementWithWait().Displayed.Should().BeTrue();
            ReviewPage.GiftsAccordion.GetElementWithWait().Displayed.Should().BeTrue();
            ReviewPage.EntertainmentAccordion.GetElementWithWait().Displayed.Should().BeTrue();
            ReviewPage.OutsideActivityAccordion.GetElementWithWait().Displayed.Should().BeTrue();
            ReviewPage.PoliticalActivityAccordion.GetElementWithWait().Displayed.Should().BeTrue();
            ReviewPage.PoliticalBeneficiaryAccordion.GetElementWithWait().Displayed.Should().BeTrue();
            ReviewPage.BrokerAccountStatementsAccordion.GetElementWithWait().Displayed.Should().BeTrue();
        }

        [When("the user expands all accordions on the Review page")]
        public void WhenTheUserExpandsAllAccordionsOnTheReviewPage()
        {
            throw new PendingStepException();
        }

        [Given(@"the user expands ""([^""]*)"" accordion on the Review page")]
        public void GivenTheUserExpandsAccordionOnTheReviewPage(string p0)
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the Political Beneficiary grid and navigate to Political Activity Declaration Details page")]
        public void GivenTheUserClickOnFirstRowOnThePoliticalBeneficiaryGridAndNavigateToPoliticalActivityDeclarationDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Political Activity Declaration Details Page should appear sucessfully")]
        public void ThenThePoliticalActivityDeclarationDetailsPageShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Cases page displays correctly")]
        public void ThenTheCasesPageDisplaysCorrectly()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Trade Request Case Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToTradeRequestCaseDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Trade Request Case Details page displays correctly")]
        public void ThenTheTradeRequestCaseDetailsPageDisplaysCorrectly()
        {
            throw new PendingStepException();
        }

        [When(@"the user expands ""([^""]*)"" accordion on the Review page")]
        public void WhenTheUserExpandsAccordionOnTheReviewPage(string p0)
        {
            throw new PendingStepException();
        }

        [Then("the Notes and Attachments section should appear sucessfully on Case Details Page")]
        public void ThenTheNotesAndAttachmentsSectionShouldAppearSucessfullyOnCaseDetailsPage()
        {
            throw new PendingStepException();
        }

        [When("the user clicks the Create tab within NOTES AND ATTACHMENTS section to Review page")]
        public void WhenTheUserClicksTheCreateTabWithinNOTESANDATTACHMENTSSectionToReviewPage()
        {
            throw new PendingStepException();
        }

        [Then("the NOTES AND ATTACHMENTS Create tab elements display without error on Review Page")]
        public void ThenTheNOTESANDATTACHMENTSCreateTabElementsDisplayWithoutErrorOnReviewPage()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Order Case Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToOrderCaseDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Order Case Details page displays correctly")]
        public void ThenTheOrderCaseDetailsPageDisplaysCorrectly()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Security Transaction Case Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToSecurityTransactionCaseDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Security Transaction Case Details page displays correctly")]
        public void ThenTheSecurityTransactionCaseDetailsPageDisplaysCorrectly()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Private Transaction Confirmation Case Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToPrivateTransactionConfirmationCaseDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Private Transaction Confirmation Case Details page displays correctly")]
        public void ThenThePrivateTransactionConfirmationCaseDetailsPageDisplaysCorrectly()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Document Case Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToDocumentCaseDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Document Case Details page displays correctly")]
        public void ThenTheDocumentCaseDetailsPageDisplaysCorrectly()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Manually Raised Case Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToManuallyRaisedCaseDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Manually Raised Case Details page displays correctly")]
        public void ThenTheManuallyRaisedCaseDetailsPageDisplaysCorrectly()
        {
            throw new PendingStepException();
        }

        [When(@"the user click on ""([^""]*)"" link on the Review page")]
        public void WhenTheUserClickOnLinkOnTheReviewPage(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the ""([^""]*)"" Details page displays correctly")]
        public void ThenTheDetailsPageDisplaysCorrectly(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the user click on ""([^""]*)"" link on the Review page")]
        public void GivenTheUserClickOnLinkOnTheReviewPage(string p0)
        {
            throw new PendingStepException();
        }

        [Then("the Create Manually Raised Case Details page displays correctly")]
        public void ThenTheCreateManuallyRaisedCaseDetailsPageDisplaysCorrectly()
        {
            throw new PendingStepException();
        }

        [When("the user opens the entity picker from the Review Module")]
        public void WhenTheUserOpensTheEntityPickerFromTheReviewModule()
        {
            throw new PendingStepException();
        }

        [Then(@"the entity picker popup window contains ""([^""]*)"" header and grid should appear sucessfully on Review Page")]
        public void ThenTheEntityPickerPopupWindowContainsHeaderAndGridShouldAppearSucessfullyOnReviewPage(string p0)
        {
            throw new PendingStepException();
        }

        [Then("the Override Review page displays correctly")]
        public void ThenTheOverrideReviewPageDisplaysCorrectly()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Override Review Trade Request Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToOverrideReviewTradeRequestDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then(@"the ""([^""]*)"" Details Page should appear sucessfully")]
        public void ThenTheDetailsPageShouldAppearSucessfully(string p0)
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Override Review Private Transaction Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToOverrideReviewPrivateTransactionDetailsPage()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Override Review Document Instance Version Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToOverrideReviewDocumentInstanceVersionDetailsPage()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Override Review Gift Version Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToOverrideReviewGiftVersionDetailsPage()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Override Review Outside Activity Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToOverrideReviewOutsideActivityDetailsPage()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Political Activity Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToPoliticalActivityDetailsPage()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Override Broker Accounts Statements Review Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToOverrideBrokerAccountsStatementsReviewDetailsPage()
        {
            throw new PendingStepException();
        }

        [When("the user expands following accordions on the Review page")]
        public void WhenTheUserExpandsFollowingAccordionsOnTheReviewPage(Table table)
        {
            throw new PendingStepException();
        }

        [Then("the Review Levels Details Page should appear sucessfully")]
        public void ThenTheReviewLevelsDetailsPageShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Review Level Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToReviewLevelDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Review Level Details Page should appear sucessfully")]
        public void ThenTheReviewLevelDetailsPageShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [When("the user click on first row on the grid and navigate to User Account Details page")]
        public void WhenTheUserClickOnFirstRowOnTheGridAndNavigateToUserAccountDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the User Account Details Page should appear sucessfully")]
        public void ThenTheUserAccountDetailsPageShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [When("the user opens the Review Delegation entity picker from the Review Module")]
        public void WhenTheUserOpensTheReviewDelegationEntityPickerFromTheReviewModule()
        {
            throw new PendingStepException();
        }

        [Then("the Review Delegation page displays correctly")]
        public void ThenTheReviewDelegationPageDisplaysCorrectly()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Review Delegation grid")]
        public void WhenTheUserClickOnFirstPlusSignOnTheReviewDelegationGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Primary Reviewer details should appear sucessfully on the page")]
        public void ThenThePrimaryReviewerDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }
    }
}