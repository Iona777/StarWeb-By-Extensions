using FluentAssertions;
using Star.Web.AutomatedUITests.ComponentHelper;
using Star.Web.AutomatedUITests.Framework.Configuration;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers;
using Star.Web.AutomatedUITests.Locators.Compliance;
using System.Threading;
using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class GiftsAndEntertainmentStepDefinitions
    {
        [Then(@"the ""(.*)"" page is loaded successfully without error")]
        public void ThenThePageIsLoadedSuccessfullyWithoutError(string Gifts)
        {   
            SeleniumExecutor.GetPageTitle().Should().Be("Gifts");
            GiftsAndEntertainmentPage.GiftsBreadcrumb.GetElementText().Should().Be("Gifts");
            GiftsAndEntertainmentPage.DeclareGiftAccordionTitle.GetElementText().Should().Be("DECLARE GIFT ");
            GiftsAndEntertainmentPage.ColHeader.IsElementDisplayed().Should().BeTrue();
            GiftsAndEntertainmentPage.ViewNameDropdown.IsElementDisplayed().Should().BeTrue();
            GiftsAndEntertainmentPage.FrontFooter.IsElementDisplayed().Should().BeTrue();
        }

        [When(@"the user expands ""(.*)"" accordion on the Gift page")]
        public void WhenTheUserExpandsAccordionOnTheGiftPage(string p0)
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Gift Declaration page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToGiftDeclarationPage()
        {
            throw new PendingStepException();
        }

        [Then("the Details accordion details should appear sucessfully on Gift Declaration page")]
        public void ThenTheDetailsAccordionDetailsShouldAppearSucessfullyOnGiftDeclarationPage()
        {
            throw new PendingStepException();
        }

        [Then("the Preclearance accordion details should appear sucessfully on Gift Declaration page")]
        public void ThenThePreclearanceAccordionDetailsShouldAppearSucessfullyOnGiftDeclarationPage()
        {
            throw new PendingStepException();
        }

        [Then("the Surveillance accordion details should appear sucessfully on Gift Declaration page")]
        public void ThenTheSurveillanceAccordionDetailsShouldAppearSucessfullyOnGiftDeclarationPage()
        {
            throw new PendingStepException();
        }

        [Then("the Gift Declaration Notes and Attachments Existing Notes Tab details should appear sucessfully")]
        public void ThenTheGiftDeclarationNotesAndAttachmentsExistingNotesTabDetailsShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [Given(@"the user expands ""([^""]*)"" accordions on the Gifts And Entertainment page")]
        public void GivenTheUserExpandsAccordionsOnTheGiftsAndEntertainmentPage(string p0)
        {
            throw new PendingStepException();
        }

        [When("the user clicks the Create tab within the Gift Declaration page Notes and Attachments section")]
        public void WhenTheUserClicksTheCreateTabWithinTheGiftDeclarationPageNotesAndAttachmentsSection()
        {
            throw new PendingStepException();
        }

        [Then("the Gift Declaration Notes and Attachments Create tab elements display without error")]
        public void ThenTheGiftDeclarationNotesAndAttachmentsCreateTabElementsDisplayWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the Further Questions accordion details should appear sucessfully on Gift Declaration page")]
        public void ThenTheFurtherQuestionsAccordionDetailsShouldAppearSucessfullyOnGiftDeclarationPage()
        {
            throw new PendingStepException();
        }

        [Then("the Entertainments section loads without error")]
        public void ThenTheEntertainmentsSectionLoadsWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the Declare Entertainment accordion opens without error")]
        public void ThenTheDeclareEntertainmentAccordionOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Entertainment Declaration page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToEntertainmentDeclarationPage()
        {
            throw new PendingStepException();
        }

        [Then("the Details accordion details should appear sucessfully on Entertainment Declaration page")]
        public void ThenTheDetailsAccordionDetailsShouldAppearSucessfullyOnEntertainmentDeclarationPage()
        {
            throw new PendingStepException();
        }

        [Then("the Preclearance accordion details should appear sucessfully on Entertainment Declaration page")]
        public void ThenThePreclearanceAccordionDetailsShouldAppearSucessfullyOnEntertainmentDeclarationPage()
        {
            throw new PendingStepException();
        }

        [Then("the surveillance accordion details should appear sucessfully on Entertainment Declaration page")]
        public void ThenTheSurveillanceAccordionDetailsShouldAppearSucessfullyOnEntertainmentDeclarationPage()
        {
            throw new PendingStepException();
        }

        [Then("the Entertainment Declaration Notes and Attachments Existing Notes Tab details should appear sucessfully")]
        public void ThenTheEntertainmentDeclarationNotesAndAttachmentsExistingNotesTabDetailsShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [When("the user clicks the Create tab within the Entertainment Declaration page Notes and Attachments section")]
        public void WhenTheUserClicksTheCreateTabWithinTheEntertainmentDeclarationPageNotesAndAttachmentsSection()
        {
            throw new PendingStepException();
        }

        [Then("the Entertainment Declaration Notes and Attachments Create tab elements display without error")]
        public void ThenTheEntertainmentDeclarationNotesAndAttachmentsCreateTabElementsDisplayWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the Further Questions accordion details should appear sucessfully on Entertainment Declaration page")]
        public void ThenTheFurtherQuestionsAccordionDetailsShouldAppearSucessfullyOnEntertainmentDeclarationPage()
        {
            throw new PendingStepException();
        }

        [Then("the Add New Gift Proxy Relationships accordion opens")]
        public void ThenTheAddNewGiftProxyRelationshipsAccordionOpens()
        {
            throw new PendingStepException();
        }

        [Then("the Gift Proxy Submitters page opens without error")]
        public void ThenTheGiftProxySubmittersPageOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Gift Proxy Submitters grid")]
        public void WhenTheUserClickOnFirstPlusSignOnTheGiftProxySubmittersGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Gift Proxy Submitters details should appear sucessfully on Proxys Submitters page")]
        public void ThenTheGiftProxySubmittersDetailsShouldAppearSucessfullyOnProxysSubmittersPage()
        {
            throw new PendingStepException();
        }

        [Then("the Add New Entertainment Proxy Relationships accordion opens")]
        public void ThenTheAddNewEntertainmentProxyRelationshipsAccordionOpens()
        {
            throw new PendingStepException();
        }

        [Then("the Entertainment Proxy Submitters page opens without error")]
        public void ThenTheEntertainmentProxySubmittersPageOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Entertainment Proxy Submitters grid")]
        public void WhenTheUserClickOnFirstPlusSignOnTheEntertainmentProxySubmittersGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Entertainment Proxy Submitters details opens without error")]
        public void ThenTheEntertainmentProxySubmittersDetailsOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the Create New Gift And Entertainment Purpose accordion opens")]
        public void ThenTheCreateNewGiftAndEntertainmentPurposeAccordionOpens()
        {
            throw new PendingStepException();
        }

        [Then("the Purposes page opens without error")]
        public void ThenThePurposesPageOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Purposes Description grid")]
        public void WhenTheUserClickOnFirstPlusSignOnThePurposesDescriptionGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Purposes Description details opens without error")]
        public void ThenThePurposesDescriptionDetailsOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the Create New Gifts And Entertainment Type accordion opens")]
        public void ThenTheCreateNewGiftsAndEntertainmentTypeAccordionOpens()
        {
            throw new PendingStepException();
        }

        [Then("the Gift and Entertainment Types accordion details open without error")]
        public void ThenTheGiftAndEntertainmentTypesAccordionDetailsOpenWithoutError()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Gift and Entertainment Types Description grid")]
        public void WhenTheUserClickOnFirstPlusSignOnTheGiftAndEntertainmentTypesDescriptionGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Gift and Entertainment Types details opens without error")]
        public void ThenTheGiftAndEntertainmentTypesDetailsOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the Configuration page opens without error")]
        public void ThenTheConfigurationPageOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the Expense Reconciliation page opens without error")]
        public void ThenTheExpenseReconciliationPageOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the Confirm And Convert Expenses accordion opens")]
        public void ThenTheConfirmAndConvertExpensesAccordionOpens()
        {
            throw new PendingStepException();
        }

        [Then("the Complete And Convert Expenses accordion opens")]
        public void ThenTheCompleteAndConvertExpensesAccordionOpens()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Complete and Convert Expenses")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToCompleteAndConvertExpenses()
        {
            throw new PendingStepException();
        }

        [Then("the Expense accordion details should appear sucessfully on Complete and Convert Expenses page")]
        public void ThenTheExpenseAccordionDetailsShouldAppearSucessfullyOnCompleteAndConvertExpensesPage()
        {
            throw new PendingStepException();
        }

        [Then("the Ignored Expenses accordion opens")]
        public void ThenTheIgnoredExpensesAccordionOpens()
        {
            throw new PendingStepException();
        }

        [Then("the Ignored User Accounts accordion opens")]
        public void ThenTheIgnoredUserAccountsAccordionOpens()
        {
            throw new PendingStepException();
        }

        [Then("the Expense Mapping Configuration page opens without error")]
        public void ThenTheExpenseMappingConfigurationPageOpensWithoutError()
        {
            throw new PendingStepException();
        }
    }
}