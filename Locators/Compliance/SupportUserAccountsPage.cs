using OpenQA.Selenium;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class SupportUserAccountsPage
    {
        // Support User Accounts Page
        public static By CreateNewSupportUserAccountAccordion = By.CssSelector("li[section='create']>h1");

        public static By CreateNewSupportUserAccountPage = By.CssSelector("#uc-create");

        public static By CreateNewSupportUserAccountPageUserName = By.CssSelector("[key='tbUserName']");

        public static By CreateNewSupportUserAccountPageFName = By.CssSelector("[key='tbFirstName']");

        public static By CreateNewSupportUserAccountPageLName = By.CssSelector("[key='tbLastName']");

        public static By CreateNewSupportUserAccountPagePassword = By.CssSelector("[key='tbPassword']");

        public static By CreateNewSupportUserAccountPageConfirmPassword = By.CssSelector("[key='tbConfirmPassword']");

        public static By CreateNewSupportUserAccountPageCancelBtn = By.CssSelector("[key='btnCancel']");

        public static By CreateNewSupportUserAccountPageSaveBtn = By.CssSelector("[key='btnSave']");

        //Grid
        public static By SupportUserAccountsAccordion = By.CssSelector("li[section='grid']>h1");

        public static By SupportUserAccountsViewName = By.CssSelector("[key='sddlViews']");

        public static By SupportUserAccountsCreateCustomerGridView = By.CssSelector("#uc-grid a[key='btnEdit']");

        public static By SupportUserAccountsExportBtn = By.CssSelector("[key='exportBtn']");

        public static By SupportUserAccountsGrid = By.CssSelector("#uc-grid .cv-custom-grid");

        public static By SupportUserAccountsFirstGrid = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        //Support Account Details page
        public static By SupportUserAccountDetailsAccordion = By.CssSelector("li[section='details']>h1");

        public static By SupportUserAccountDetailsSection = By.CssSelector("#uc-details");

        public static By SupportUserAccountDetailsChangePassBtn = By.CssSelector("[action='changepassword']");

        public static By SupportUserAccountDetailsDeactivateBtn = By.CssSelector("[action='deactivate']");

        public static By SupportUserAccountDetailsEditBtn = By.CssSelector("[key='btnEdit']");

        public static By LoginHistoryAccordion = By.CssSelector("li[section='loginhistory']>h1");

        public static By LoginHistoryExportBtn = By.CssSelector("[key='exportBtn']");

        public static By LoginHistoryGrid = By.CssSelector("#uc-loginhistory .cv-custom-grid");
    }
}