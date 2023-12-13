using OpenQA.Selenium;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class UserAccountsPage
    {
        public static By UserAccountsBreadcrrumb = By.XPath("//*[@id='breadcrumb']/li[6]");
        public static By UserAccountAccordionTitle = By.CssSelector("[class='accordion-title ']");
        public static By UserAccountsAccordion = By.CssSelector("[class='accordion'] [section='create']");
        public static By UserAccountsAccordionExpander = By.ClassName("expander");


        //Create New User Account Fields
        public static By FirstName = By.CssSelector("[id='uc-create'] [key='tbFirstName'] [class='tb-box tb standard-input']");

        // [id='uc-create'] [key='btnSave'] [class='tb-box tb standard-input']

        public static By MiddleName = By.CssSelector("[id='uc-create'] [key='tbMiddleName'] [class='tb-box tb standard-input']");
        public static By LastName = By.CssSelector("[id='uc-create'] [key='tbLastName'] [class='tb-box tb standard-input']");
        public static By UserName = By.CssSelector("[id='uc-create'] [key='tbUserName'] [class='tb-box tb standard-input']");
        public static By JobTitle = By.CssSelector("[id='uc-create'] [key='tbJobTitle'] [class='tb-box tb standard-input']");
        public static By EmployeCode = By.CssSelector("[id='uc-create'] [key='tbEmployeeCode'] [class='tb-box tb standard-input']");
        public static By OfficeNameDropDown = By.CssSelector("[id='uc-create'] [key='sddlOfficeId']");
        public static By OfficeNameInputBox = By.CssSelector("[id='uc-create'] [key='sddlOfficeId'] [class='tb-box tb standard-input']");
        public static By PhoneNumber =      By.CssSelector("[id='uc-create'] [key='tbPhoneNumber'] [class='tb-box tb standard-input']");
        public static By EmailAddress = By.CssSelector("[id='uc-create'] [key='tbEmail']");
        public static By EmailAddressMasked = By.CssSelector("[id='uc-create'] [key='tbEmail'] [class='tb-wrapper tb-auto tb-masked']");
        public static By EmailAddressInputBox = By.CssSelector("[id='uc-create'] [key='tbEmail'] [class='tb-box tb standard-input']");

        public static By EmailDescription = By.CssSelector("[id='uc-create'] [key='tbDescription']");
        public static By EmailDescriptionInputBox = By.CssSelector("[id='uc-create'] [key='tbDescription'] [class='tb-box tb standard-input']");
        public static By EnableStandardAuthentication = By.CssSelector("[id='uc-create'] [key='btnbarEnableStandardAuthentication'] [title='Yes']");

        public static By DisableStandardAuthentication = By.CssSelector("[id='uc-create'] [key='btnbarEnableStandardAuthentication'] [title='No']");
        public static By EnableSingleSignOn = By.CssSelector("[id='uc-create'] [key='btnbarEnableCustomAuthentication'] [title='Yes']");
        public static By DisableSingleSignOn = By.CssSelector("[id='uc-create'] [key='btnbarEnableCustomAuthentication'] [title='No']");

        public static By SingleSignOnCredentials = By.CssSelector("[id='uc-create'] [key='tbCustomAuthenticationCredentials'] [class='tb-box tb standard-input']");
        public static By CustKey = By.CssSelector("[id='uc-create'] [key='tbCustKey'] [class='tb-box tb standard-input']");

        public static By ReviewDateMMWrapper = By.CssSelector("[id='uc-create'] [key='MM']");
        public static By ReviewDatedMMInput = By.CssSelector("[id='uc-create'] [key='MM'] [class='tb-box tb standard-input']");

        public static By ReviewDateDDWrapper = By.CssSelector("[id='uc-create'] [key='DD']");
        public static By ReviewDatedDDInput = By.CssSelector("[id='uc-create'] [key='DD'] [class='tb-box tb standard-input']");

        public static By ReviewDateYYYYWrapper = By.CssSelector("[id='uc-create'] [key='YYYY']");
        public static By ReviewDatedYYYYInput = By.CssSelector("[id='uc-create'] [key='YYYY'] [class='tb-box tb standard-input']");

        public static By NoteSummary = By.CssSelector("[id='uc-create'] [key='tbexpropnotesummary'] [class='tb-box tb standard-input']");
        public static By TravelRate = By.CssSelector("[id='uc-create'] [key='numerictbexproptravelrate'] [class='tb-box tb standard-input']");
        public static By FreeformNotes = By.CssSelector("[id='uc-create'] [key='taexpropfreeformnotes'] [class='ta-inner standard-input']");

        public static By SatisfieldTradRequirementsYes = By.CssSelector("[id='uc-create'] [key='btnbarexpropsatisfiedtraderequirements'] [title='Yes']");
        public static By SatisfieldTradRequirementsNo = By.CssSelector("[id='uc-create'] [key='btnbarexpropsatisfiedtraderequirements'] [title='No']");
        public static By LegacyEmployeeNumber = By.CssSelector("[id='uc-create'] [key='numerictbexproplegacyemployeenumber'] [class='tb-box tb standard-input']");

        public static By CancelButton = By.CssSelector("[id='uc-create'] [key='btnCancel']");
        public static By CreateButton = By.CssSelector("[id='uc-create'] [key='btnSave']");









    }
}
