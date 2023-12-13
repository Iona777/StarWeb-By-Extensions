using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.HeapProfiler;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class UserAccountDetailsPage
    {
        public static By UserAccountDetailsAccordion = By.CssSelector("[class='accordion'] [section='details']");
        public static By UserAccountDetailsAccordionExpander = By.ClassName("expander");


        // [id='uc-details'] [action='activate'] [class='card-details']
        public static By DetailsTable = By.CssSelector("[id='uc-details'] [key='createuseraccount'] [class='card-details'] table");
        public static By ActivateButton = By.CssSelector("[id='uc-details'] [action='activate']");
        public static By ChangePasswordButton = By.CssSelector("[id='uc-details'] [action='changepassword']");

        public static By CommentField = By.CssSelector("[key='activateuserform'] [key='taComment'] [class='ta-inner standard-input']");
        public static By ActivateUserSaveButton = By.CssSelector("[key='activateuserform'] [key='btnSave'][class='btn btn-submit']");

        public static By NewPasswordField = By.CssSelector("[key='changepasswordform'] [key='tbNewPassword'] [class='tb-box tb standard-input']");
        public static By ConfirmPasswordField = By.CssSelector("[key='changepasswordform'] [key='tbConfirmPassword'] [class='tb-box tb standard-input']");
        //Note: only has the last class once it is enabled after the password field populated
        public static By PasswordSaveButton = By.CssSelector("[key='changepasswordform'] [key='btnSave'][class='btn btn-submit']");

        //public static By Overlay = By.CssSelector("[id='uc-details'] [class='pnl-loading']");
        public static By Overlay = By.CssSelector("[class='pnl-loading']");
        public static By PanelOverlay = By.CssSelector("[id='uc-details'] [class='panel-overlay']");
        public static By PanelOverlaySpinner = By.CssSelector("[class='loading loading-large']");
        public static By ActiveUserFormPopup = By.ClassName("activateuser-form");
        public static By ChangePasswordFormPopup = By.ClassName("password-form");

        //public static By ActivateUserSuccessNotification = By.Id("noty_bottom_layout_container");

    }
}
