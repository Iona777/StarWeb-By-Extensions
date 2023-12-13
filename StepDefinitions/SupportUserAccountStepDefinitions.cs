using FluentAssertions;

using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Locators.Compliance;

using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class SupportUserAccountStepDefinitions
    {
        [Then("the Support User Accounts page should load successfully")]
        public void ThenTheSupportUserAccountsPageShouldLoadSuccessfully()
        {
            CommonPage.PageHeader.GetElementWithWait().Text.Should().Be("Support User Accounts");
            SupportUserAccountsPage.SupportUserAccountsViewName.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.SupportUserAccountsCreateCustomerGridView.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.SupportUserAccountsExportBtn.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.SupportUserAccountsGrid.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.SupportUserAccountsFirstGrid.IsDisplayedAfterWait().Should().BeTrue();
        }

        [Then("the Create New Support User Account details load successfully")]
        public void ThenTheCreateNewSupportUserAccountDetailsLoadSuccessfully()
        {
            SupportUserAccountsPage.CreateNewSupportUserAccountAccordion.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.CreateNewSupportUserAccountPage.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.CreateNewSupportUserAccountPageUserName.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.CreateNewSupportUserAccountPageFName.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.CreateNewSupportUserAccountPageLName.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.CreateNewSupportUserAccountPagePassword.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.CreateNewSupportUserAccountPageConfirmPassword.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.CreateNewSupportUserAccountPageCancelBtn.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.CreateNewSupportUserAccountPageSaveBtn.IsDisplayedAfterWait().Should().BeTrue();
        }

        [When("the user clicks on the first row on the first grid")]
        public void GivenTheUserClicksOnTheFirstRowOnTheGrid()
        {
            SupportUserAccountsPage.SupportUserAccountsFirstGrid.ClickWithWait();
            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();
        }

        [Then("the Support Account Details page load successfully")]
        public void ThenTheSupportAccountDetailsPageLoadSuccessfully()
        {
            CommonPage.PageHeader.GetElementWithWait().Text.Should().Be("Details");
            SupportUserAccountsPage.SupportUserAccountDetailsAccordion.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.SupportUserAccountDetailsSection.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.SupportUserAccountDetailsChangePassBtn.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.SupportUserAccountDetailsDeactivateBtn.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.SupportUserAccountDetailsEditBtn.IsDisplayedAfterWait().Should().BeTrue();

            SupportUserAccountsPage.LoginHistoryAccordion.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.LoginHistoryExportBtn.IsDisplayedAfterWait().Should().BeTrue();
            SupportUserAccountsPage.LoginHistoryGrid.IsDisplayedAfterWait().Should().BeTrue();
        }
    }
}