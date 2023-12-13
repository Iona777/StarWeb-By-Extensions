using FluentAssertions;

using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Locators.Compliance;

using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class AdministrationStepDefinitions
    {
        [Then("the Document Configuration page displays correctly")]
        public static void DocumentConfigDisplaysCorrectly()
        {
            AdministrationPage.PageHeader.GetElementWithWait().Text.Should().Be("Document Configuration");
        }

        [Then("the Create Document Descriptor accordion opens without error")]
        public static void CreateDocumentDescriptorAccordionOpens()
        {
            AdministrationPage.CreateDocumentContainer.GetElementWithWait().Displayed.Should().BeTrue();

            AdministrationPage.CreateDocumentCancelButton.GetElementWithWait().Displayed.Should().BeTrue();
            AdministrationPage.CreateDocumentCreateButton.GetElementWithWait().Displayed.Should().BeTrue();
            AdministrationPage.DocumentDescriptionInputField.GetElementWithWait().Displayed.Should().BeTrue();
            AdministrationPage.DocumentDescriptionTextField.GetElementWithWait().Displayed.Should().BeTrue();
            AdministrationPage.DocumentTypeDropDown.GetElementWithWait().Displayed.Should().BeTrue();
        }

        [Then("the Create Document Description accordion opens without error")]
        public static void ThenTheCreateDocumentDescriptionAccordionOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the default grid view column names are")]
        public static void ThenTheDefaultGridViewColumnNamesAre(Table accordions)
        {
            throw new PendingStepException();
        }

        [Given(@"the user click on first row on the ""([^""]*)"" grid and navigate to Details page")]
        public static void GivenTheUserClickOnFirstRowOnTheGridAndNavigateToDetailsPage(string p0)
        {
            throw new PendingStepException();
        }

        [When("the user expands following accordions on the Administration page")]
        public static void WhenTheUserExpandsFollowingAccordionsOnTheAdministrationPage(Table table)
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Document Descriptor Details page successfully")]
        public static void ThenTheUserIsLandedToTheDocumentDescriptorDetailsPageSuccessfully()
        {
            throw new PendingStepException();
        }

        [Given(@"the user expands ""([^""]*)"" accordion on the Administration page")]
        public static void GivenTheUserExpandsAccordionOnTheAdministrationPage(string p0)
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Document Set Details page successfully")]
        public static void ThenTheUserIsLandedToTheDocumentSetDetailsPageSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Document Configuration Details Update Document Set Configuration successfully")]
        public static void ThenTheUserIsLandedToTheDocumentConfigurationDetailsUpdateDocumentSetConfigurationSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Document Configuration Details Update Document Set Configuration page successfully")]
        public static void ThenTheUserIsLandedToTheDocumentConfigurationDetailsUpdateDocumentSetConfigurationPageSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Alert page opens without error")]
        public static void ThenTheAlertPageOpensWithoutError()
        {
            throw new PendingStepException();
        }

        [Then("the Custom Views page opens successfully")]
        public static void ThenTheCustomViewsPageOpensSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Custom View Details page successfully")]
        public static void ThenTheUserIsLandedToTheCustomViewDetailsPageSuccessfully()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the Views grid and navigate to View Details page")]
        public static void GivenTheUserClickOnFirstRowOnTheViewsGridAndNavigateToViewDetailsPage()
        {
            throw new PendingStepException();
        }

        [When("the user expands all accordions on the Administration page")]
        public static void WhenTheUserExpandsAllAccordionsOnTheAdministrationPage()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the Administration Custom View Details page successfully")]
        public static void ThenTheUserIsLandedToTheAdministrationCustomViewDetailsPageSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then("the File Imports page loads successfully")]
        public static void ThenTheFileImportsPageLoadsSuccessfully()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the File Imports grid and navigate to File Import Details page")]
        public static void GivenTheUserClickOnFirstRowOnTheFILEIMPORTSGridAndNavigateToFileImportDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the File Imports Details page loads without error")]
        public static void ThenTheFileImportsDetailsPageLoadsWithoutError()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the File Import Configuration grid and navigate to File Import Configuration Details page")]
        public static void GivenTheUserClickOnFirstRowOnTheFileImportConfigurationGridAndNavigateToFileImportConfigurationDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the File Import Configuration Details page loads without error")]
        public static void ThenTheFileImportConfigurationDetailsPageLoadsWithoutError()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the File Import Configuration Details Lookups grid")]
        public static void WhenTheUserClickOnFirstPlusSignOnTheFileImportConfigurationDetailsLookupsGrid()
        {
            throw new PendingStepException();
        }

        [Then("the File Import Configuration Details Lookups Details should appear sucessfully on the page")]
        public static void ThenTheFileImportConfigurationDetailsLookupsDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Custom Columns Details Lookups grid")]
        public static void WhenTheUserClickOnFirstPlusSignOnTheCustomColumnsDetailsLookupsGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Custom Columns Details Lookups Details should appear sucessfully on the page")]
        public static void ThenTheCustomColumnsDetailsLookupsDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the Home Page Configuration should appear sucessfully on the page")]
        public static void ThenTheHomePageConfigurationShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [When(@"the user opens the ""([^""]*)"" entity picker from the Administration page")]
        public static void WhenTheUserOpensTheEntityPickerFromTheAdministrationPage(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the entity picker popup window contains ""([^""]*)"" header and grid should appear sucessfully on Administration Page")]
        public static void ThenTheEntityPickerPopupWindowContainsHeaderAndGridShouldAppearSucessfullyOnAdministrationPage(string p0)
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Home Page Configurations grid")]
        public static void WhenTheUserClickOnFirstPlusSignOnTheHomePageConfigurationsGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Home Page Configurations Details should appear sucessfully on the page")]
        public static void ThenTheHomePageConfigurationsDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the Employee Menu Configurations page should appear sucessfully on the page")]
        public static void ThenTheEmployeeMenuConfigurationsPageShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [When(@"the user click on first row on the ""([^""]*)"" grid and navigate to Details page")]
        public static void WhenTheUserClickOnFirstRowOnTheGridAndNavigateToDetailsPage(string p0)
        {
            throw new PendingStepException();
        }

        [Then("the Configuration Details page should appear sucessfully on the page")]
        public static void ThenTheConfigurationDetailsPageShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the Help page should appear sucessfully on the page")]
        public static void ThenTheHelpPageShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Help page grid")]
        public static void WhenTheUserClickOnFirstPlusSignOnTheHelpPageGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Help Details should appear sucessfully on the page")]
        public static void ThenTheHelpDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the System Script Management should appear sucessfully on the page")]
        public static void ThenTheSystemScriptManagementShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the System Script Details should appear sucessfully on the page")]
        public static void ThenTheSystemScriptDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the System Script Schedule Details should appear sucessfully on the page")]
        public static void ThenTheSystemScriptScheduleDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the user is landed to the System Configuration page successfully")]
        public static void ThenTheUserIsLandedToTheSystemConfigurationPageSuccessfully()
        {
            throw new PendingStepException();
        }

        [Then("the List Management page elements load sucessfully")]
        public static void ThenTheListManagementPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the List Management Details should appear sucessfully on the page")]
        public static void ThenTheListManagementDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the List Details List Items grid")]
        public static void WhenTheUserClickOnFirstPlusSignOnTheListDetailsListItemsGrid()
        {
            throw new PendingStepException();
        }

        [Then("the List Details List Items should appear sucessfully on the page")]
        public static void ThenTheListDetailsListItemsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the Archiving page elements load sucessfully")]
        public static void ThenTheArchivingPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the System Languages page elements load sucessfully")]
        public static void ThenTheSystemLanguagesPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Audit Log page elements load sucessfully")]
        public static void ThenTheAuditLogPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Connection String Management page elements load sucessfully")]
        public static void ThenTheConnectionStringManagementPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Connection String Management Details page elements load sucessfully")]
        public static void ThenTheConnectionStringManagementDetailsPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Custom Alerts page elements load sucessfully")]
        public static void ThenTheCustomAlertsPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Custom Alert Details page elements load sucessfully")]
        public static void ThenTheCustomAlertDetailsPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Custom Alerts Views page elements load sucessfully")]
        public static void ThenTheCustomAlertsViewsPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Custom Alert View Details page elements load sucessfully")]
        public static void ThenTheCustomAlertViewDetailsPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Api Custom Views page elements load sucessfully")]
        public static void ThenTheApiCustomViewsPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Api Custom View Details page elements load sucessfully")]
        public static void ThenTheApiCustomViewDetailsPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Given("the user click on first row on the Api Custom View Details VIEWS grid and navigate to Details page")]
        public static void GivenTheUserClickOnFirstRowOnTheApiCustomViewDetailsVIEWSGridAndNavigateToDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then("the Api Custom View Details Item page elements load sucessfully")]
        public static void ThenTheApiCustomViewDetailsItemPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [Then("the Quick Links page elements load sucessfully")]
        public static void ThenTheQuickLinksPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Quick Links grid")]
        public static void WhenTheUserClickOnFirstPlusSignOnTheQuickLinksGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Quick Links details should appear sucessfully on the page")]
        public static void ThenTheQuickLinksDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the Credential Management page elements load sucessfully")]
        public static void ThenTheCredentialManagementPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Credential Management grid")]
        public static void WhenTheUserClickOnFirstPlusSignOnTheCredentialManagementGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Credential Management details should appear sucessfully on the page")]
        public static void ThenTheCredentialManagementDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }

        [Then("the Application Links page elements load sucessfully")]
        public static void ThenTheApplicationLinksPageElementsLoadSucessfully()
        {
            throw new PendingStepException();
        }

        [When("the user click on first plus sign on the Application Links grid")]
        public static void WhenTheUserClickOnFirstPlusSignOnTheApplicationLinksGrid()
        {
            throw new PendingStepException();
        }

        [Then("the Application Links details should appear sucessfully on the page")]
        public static void ThenTheApplicationLinksDetailsShouldAppearSucessfullyOnThePage()
        {
            throw new PendingStepException();
        }
    }
}