using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class OrdersPage
    {
        public static By OrdersBreadcrumb = By.XPath("//*[@id='breadcrumb']/li[6]");
        public static By OrdersAccordionTitle = By.CssSelector("[class='accordion-title ']");
        public static By OrdersAccordion = By.CssSelector("[class='accordion'] [section='create']");


        public static By BrokerAccountDropdown = By.CssSelector("[id='uc-create'] [key='sddlBrokerAccountId']");
        public static By Security = By.CssSelector("[id='uc-create'] [key='tbSearch'] [class='tb-box tb standard-input']");
        public static By TransactionTypeDropdown = By.CssSelector("[id='uc-create'] [key='sddlTransactionTypeId']");
        public static By OrderTypeDropdown = By.CssSelector("[id='uc-create'] [key='sddlOrderTypeId']");
        public static By DurationDropdown = By.CssSelector("[id='uc-create'] [key='sddlOrderTypeQualifierId']");

        //Not sure if we need this
        public static By OrderDatedWrapper = By.CssSelector("[key='dtpOrderDate']");

        public static By OrderDatedMMWrapper = By.CssSelector("[id='uc-create'] [key='dtpOrderDate'][class='datetimepicker dtp-small'] [key='MM']");

        public static By OrderDateMMInput = By.CssSelector("[id='uc-create'] [key='dtpOrderDate'][class='datetimepicker dtp-small'] [key='MM'] [class='tb-box tb standard-input']");

        public static By OrderDatedDDWrapper = By.CssSelector("[id='uc-create'] [key='DD']");
        public static By OrderDateDDInput = By.CssSelector("[id='uc-create'] [key='DD'] [class='tb-box tb standard-input']");
        public static By OrderDatedYYYYWrapper = By.CssSelector("[id='uc-create'] [key='YYYY']");
        public static By OrderDateYYYYInput = By.CssSelector("[id='uc-create'] [key='YYYY'] [class='tb-box tb standard-input']");

        public static By Quantity = By.CssSelector("[id='uc-create'] [key='numerictbOrderQuantity'] [class='tb-box tb standard-input']");

        public static By LimitPrice = By.CssSelector("[id='uc-create'] [key='mcpLimitPrice'] [class='tb-box tb standard-input']");

        public static By BrokerReference = By.CssSelector("[id='uc-create'] [key='tbBrokerReference'] [class='tb-box tb standard-input']");

        public static By Memo = By.CssSelector("[id='uc-create'] [key='taMemo'] [class='ta-inner standard-input']");

        public static By AmendmentTypeDropdown = By.CssSelector("[id='uc-create'] [key='sddlAmendmentOrCancellation']");


        public static By AmendmentOrderTypeDropdown = By.CssSelector("[id='uc-create'] [key='sddlAmendmentReasonId']");
        public static By AmendmentDurationDropdown = By.CssSelector("[id='uc-create'] [key='sddlAmendmentOrderTypeQualifierId']");

        public static By AmendmentOrderDatedMMWrapper = By.CssSelector("[id='uc-create'] [key='MM']");
        public static By AmendmentOrderDateMMInput = By.CssSelector("[id='uc-create'] [key='MM'] [class='tb-box tb standard-input']");



        public static By AmendmentOrderDatedDDWrapper = By.CssSelector("[id='uc-create'] [key='dtpAmendmentDateTime'][class='datetimepicker dtp-medium'] [key='MM']");
        public static By AmendmentOrderDateDDInput = By.CssSelector("[id='uc-create'] [key='DD'] [class='tb-box tb standard-input']");


        public static By AmendmentOrderDatedYYYYWrapper = By.CssSelector("[id='uc-create'] [key='YYYY']");
        public static By AmendmentOrderDateYYYYInput = By.CssSelector("[id='uc-create'] [key='YYYY'] [class='tb-box tb standard-input']");
    }
}
