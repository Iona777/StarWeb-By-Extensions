using OpenQA.Selenium;

namespace Star.Web.AutomatedUITests.Locators
{
    public class CommonPage
    {
        public static By AccordionExpander = By.CssSelector("[class='expander']");
              
        public static By NotificationMessage = By.CssSelector(".noty_message.info-notification");

        public static By NotificationContainer = By.Id("noty_bottom_layout_container");

        public static By LogoutButton = By.Id("btnLogout");

        public static By ConfirmLogoutOK = By.CssSelector("[class='btns'] [key='btnok']");


        public static By SaveButton = By.CssSelector("[key='btnSave'][class='btn btn-submit']");
        public static By CancelButton = By.CssSelector("[key='btnCancel'][class='btn btn-cancel btn-secondary']");

        //Selectors under this comment have not be verified

        public static By PageHeader = By.CssSelector("h1.pageheader");

        public static By LoadingOverlay = By.CssSelector(".panel-loading");

        public static By LoginLoading = By.CssSelector(".loading-panel panel-loading");

        public static By AccordionBtn = By.CssSelector("[section='create']>h1");

        public static By ExpandAllbBtn = By.CssSelector("[key='btnExpand']>span");

        public static By CollapseAllbBtn = By.CssSelector("[key='btnCollapse']>span");

        public static By AccordionLoadingSpinner = By.CssSelector(".loading-message");

        public static By UserProfileButton = By.Id("btnProfile");

        public static By SupportButton = By.Id("btnSupport");

        

        public static By LogoutPopupOKButton = By.Id("btn_10");

        public static By EmployeeButton = By.Id("btnEmployee");

        public static By MenuExpandBtn = By.XPath("//div[@class='icon icon_navbig_24 icon24 hover left']"); //NOT VERIFIED

        public static By MenuCollapseBtn = By.XPath("//div[@class='icon icon_navsml_24 icon24 hover right']"); //NOT VERIFIED

        public static By MasterMenu = By.CssSelector("div.master-menu"); //NOT VERIFIED

        public static By AllClosedAccordionHeaders = By.CssSelector(".accordion h1:is(.accordion-title):not(.accordion-title-open)");

        public static By FirstRowFromUserGroupsPopup = By.CssSelector("div[popuptitle='User Groups'] table[class='grid gridhover gridselect'] tr:nth-child(1)>td:nth-child(2)");

        public static By OkButtonUserGroupsPopup = By.XPath("//ul[@class='popup-footer']//a[@key='btnSubmit']//span[text()='OK']");
    }
}