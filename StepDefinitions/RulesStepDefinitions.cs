using FluentAssertions;

using Star.Web.AutomatedUITests.ComponentHelper;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Locators.Compliance;

using System;
using System.Collections.Generic;
using System.Linq;

using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class RulesStepDefinitions
    {
        Random random = new Random();

        string ruleName = Guid.NewGuid().ToString()[..20];

        string ruleDescription = Guid.NewGuid().ToString()[..30];

        [Then(@"the ""([^""]*)"" page is loaded successfully")]
        public void ThenTheUserIsLandedToTheRulesPageSuccessfully(string pageName)
        {
            RulesPage.PageHeader.GetTextWithWait().Should().Be(pageName);
            RulesPage.RulesSetViewNameDropdown.GetElement().Displayed.Should().BeTrue();
            RulesPage.RulesSetGrid.GetElement().Displayed.Should().BeTrue();
            RulesPage.RulesSetExportBtn.GetElement().Displayed.Should().BeTrue();
            RulesPage.RulesSetCustomGridView.GetElement().Displayed.Should().BeTrue();
            RulesPage.FirstRulesSetRowID.GetElement().Displayed.Should().BeTrue();
        }

        [Then("the Create Rule Set Details section displayed corrently")]
        public void ThenTheCreateRuleSetDetailsSectionShouldAppearedSuccessfully()
        {
            RulesPage.CreateRuleSetAccordion.IsDisplayedAfterWait().Should().BeTrue();
            RulesPage.CreateRuleName.IsDisplayedAfterWait().Should().BeTrue();
            RulesPage.CreateRuleDescription.IsDisplayedAfterWait().Should().BeTrue();
            RulesPage.CreateRuleRank.IsDisplayedAfterWait().Should().BeTrue();
            RulesPage.CreateRuleUserGroups.IsDisplayedAfterWait().Should().BeTrue();
            RulesPage.CreateRuleRulesSetType.IsDisplayedAfterWait().Should().BeTrue();
            RulesPage.CreateRuleCancelButton.IsDisplayedAfterWait().Should().BeTrue();
            RulesPage.CreateRuleCreateButton.IsDisplayedAfterWait().Should().BeTrue();
        }

        [When("the user fills all required fields")]
        public void WhenTheUserFillsAllRequiredFields()
        {
            int ruleRank = random.Next(1, 99);
            RulesPage.CreateRuleNameField.SendKeysWithWait(ruleName);
            RulesPage.CreateRuleDescriptionField.SendKeys(ruleDescription);
            RulesPage.CreateRuleRankField.SendKeys(ruleRank.ToString());
        }

        [Given(@"the user expands ""([^""]*)"" accordion on the Rules page")]
        public void GivenTheUserExpandsAccordionOnTheRulesPage(string p0)
        {
            throw new PendingStepException();
        }

        [When("the user opens the entity picker from the Rules page")]
        public void WhenTheUserOpensTheEntityPickerFromTheRulesPage()
        {
            RulesPage.UserAccountEntityPicker.ClickWithWait();
        }

        [When(@"the entity picker popup window contains ""([^""]*)"" header and grid should appear successfully on Rules Page")]
        public void WhenTheEntityPickerPopupWindowContainsHeaderAndGridShouldAppearSucessfullyOnRulesPage(string userGroupPopup)
        {
            RulesPage.VisiblePopupHeader.GetText().Should().Be(userGroupPopup.ToUpper());
            RulesPage.VisiblePopupGrid.IsDisplayedAfterWait().Should().BeTrue();
        }

        [When(@"the user clicks on create button")]
        public void WhenTheUserClicksOnSaveRule()
        {
            RulesPage.CreateRuleCreateButton.ClickWithWait();
        }

        [Then(@"the ""([^""]*)"" details should be displayed successfully")]
        public void ThenTheRuleSetDetailsShouldDisplayed(string detailsPageName)
        {
            RulesPage.CreateRuleCreateButton.WaitUntilElementIsNotDisplayed();
            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();
            RulesPage.PageHeader.GetTextWithWait().Should().Be($"{detailsPageName} : {ruleName}");
        }

        [Given("the user clicks on first row on the grid and navigate to Rule Set Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToRuleSetDetailsPage()
        {
            RulesPage.FirstRulesSetRowID.ClickWithWait();
            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();
        }

        [Then("the Rule Set Details section should appear sucessfully")]
        public void ThenTheRuleSetDetailsSectionShouldAppearSucessfully()
        {
            RulesPage.Breadcrumb.GetText().Contains("Rule Set Details");
            RulesPage.ViewRuleSetAccordion.IsDisplayed().Should().BeTrue();
            RulesPage.ViewRuleSetSection.IsDisplayed().Should().BeTrue();
            RulesPage.ViewRuleSetEditBtn.IsDisplayed().Should().BeTrue();
            RulesPage.ViewRuleSetDeleteBtn.IsDisplayed().Should().BeTrue();
            RulesPage.CreateNewRuleSetVersionAccordion.IsDisplayed().Should().BeTrue();
            RulesPage.CreateNewRuleSetVersionSection.IsDisplayed().Should().BeTrue();
            RulesPage.CreateNewRuleSetVersionCancelBtn.IsDisplayed().Should().BeTrue();
            RulesPage.CreateNewRuleSetVersionCreateBtn.IsDisplayed().Should().BeTrue();
            RulesPage.RuleSetVersionAccordion.IsDisplayed().Should().BeTrue();
            RulesPage.RuleSetVersionViewNameDropdown.IsDisplayedAfterWait().Should().BeTrue();
            RulesPage.RuleSetVersionGrid.IsDisplayed().Should().BeTrue();
            RulesPage.RuleSetVersionExportBtn.IsDisplayed().Should().BeTrue();
            RulesPage.RuleSetVersionCustomGridView.IsDisplayed().Should().BeTrue();
            RulesPage.FirstRuleSetVersionRowID.IsDisplayed().Should().BeTrue();
        }

        [Given("the user click on first row on the grid and navigate to Rule Set Version Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToRuleSetVersionDetailsPage()
        {
            throw new PendingStepException();
        }

        [When("the user expands all accordions on the Rules page")]
        public void WhenTheUserExpandsAllAccordionsOnTheRulesPage()
        {
            throw new PendingStepException();
        }

        [Then("the Rule Set Version Details section should appear sucessfully")]
        public void ThenTheRuleSetVersionDetailsSectionShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Surveillance Definitions page successfully")]
        public void ThenTheUserIsLandedToTheSurveillanceDefinitionsPageSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Create New Surveillance Definition section should appear sucessfully")]
        public void ThenTheCreateNewSurveillanceDefinitionSectionShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [When("the user opens the Rule Set entity picker from the Rules page")]
        public void WhenTheUserOpensTheRuleSetEntityPickerFromTheRulesPage()
        {
            throw new PendingStepException();
        }

        [When("the user opens the Line of Business entity picker from the Rules page")]
        public void WhenTheUserOpensTheLineOfBusinessEntityPickerFromTheRulesPage()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Surveillance Definition Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToSurveillanceDefinitionDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Surveillance Definition Details section should appear sucessfully")]
        public void ThenTheSurveillanceDefinitionDetailsSectionShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [When("the user clicks the Create tab within the Surveillance Definition Details NOTES AND ATTACHMENTS section")]
        public void WhenTheUserClicksTheCreateTabWithinTheSurveillanceDefinitionDetailsNOTESANDATTACHMENTSSection()
        {
            throw new PendingStepException();
        }

        [Then("the Surveillance Definition Details NOTES AND ATTACHMENTS Create tab elements display without error")]
        public void ThenTheSurveillanceDefinitionDetailsNOTESANDATTACHMENTSCreateTabElementsDisplayWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Surveillance Runs page successfully")]
        public void ThenTheUserIsLandedToTheSurveillanceRunsPageSuccessfully()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the grid and navigate to Surveillance Run Details page")]
        public void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToSurveillanceRunDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Surveillance Run Details section should appear sucessfully")]
        public void ThenTheSurveillanceRunDetailsSectionShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Case Status Details Page successfully")]
        public void ThenTheUserIsLandedToTheCaseStatusDetailsPageSuccessfully()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Case Status Details grid")]
        public void WhenTheUserClickOnFirstPlusSignOnTheCaseStatusDetailsGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Case Status Details Details should appear sucessfully on the page")]
        public void ThenTheCaseStatusDetailsDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Rule Set Results Page successfully")]
        public void ThenTheUserIsLandedToTheRuleSetResultsPageSuccessfully()
        {
            throw new PendingStepException();
        }

        [When("the user click on first row on the grid and navigate to Rule Set Result Details page")]
        public void WhenTheUserClickOnFirstRowOnTheGridAndNavigateToRuleSetResultDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Rule Set Result Details Page should appear sucessfully")]
        public void ThenTheRuleSetResultDetailsPageShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Rule Set Reporting Page should appear sucessfully")]
        public void ThenTheRuleSetReportingPageShouldAppearSucessfully()
        {
            throw new PendingStepException();
        }
    }
}