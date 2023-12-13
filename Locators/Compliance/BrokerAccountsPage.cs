using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class BrokerAccountsPage
    {
        public static By BrokerAccountsBreadcrrumb = By.XPath("//*[@id='breadcrumb']/li[6]");
        public static By BrokerAccountsAccordionTitle = By.CssSelector("[class='accordion-title ']");
        public static By BrokerAccountsAccordion = By.CssSelector("[class='accordion'] [section='create']");
        
        public static By UserAccountSearchWrapper = By.XPath("//*[@key='finder']");
        public static By UserAccountSearch = By.XPath("//*[@key='finder']/input");
        public static By PrimaryOwner = By.CssSelector("[key='rotPrimaryOwner']");
             
        public static By AccountTitle = By.CssSelector("[id='uc-create'] [key='tbAccountName'] [class='tb-box tb standard-input']");
        public static By AccountNumber = By.CssSelector("[id='uc-create'] [key='tbAccountNumber'] [class='tb-box tb standard-input']");

        public static By BrokerOfficeSearchWrapper = By.CssSelector("[id='uc-create'] [key='sefBrokerOfficeId'] [key='finder']");
        public static By BrokerOfficeSearch = By.CssSelector("[id='uc-create'] [key='sefBrokerOfficeId'] [key='finder'] [class='tb-box tb standard-input']");

        public static By DateOpenedWrapper = By.CssSelector("[key='dpDateOpened']");
        public static By DateOpenedMMWrapper = By.CssSelector("[id='uc-create'] [key='MM']");
        public static By DateOpenedMMInput = By.CssSelector("[id='uc-create'] [key='MM'] [class='tb-box tb standard-input']");

        public static By DateOpenedDDWrapper = By.CssSelector("[id='uc-create'] [key='DD']");
        public static By DateOpenedDDInput = By.CssSelector("[id='uc-create'] [key='DD'] [class='tb-box tb standard-input']");

        public static By DateOpenedYYWrapper = By.CssSelector("[id='uc-create'] [key='YYYY']");
        public static By DateOpenedYYYYInput = By.CssSelector("[id='uc-create'] [key='YYYY'] [class='tb-box tb standard-input']");

        public static By AccountTypeSearchWrapper = By.CssSelector("[id='uc-create'] [key='sefAccountTypeId'] [key='finder']");
        public static By AccountTypeSearch = By.CssSelector("[id='uc-create'] [key='sefAccountTypeId'] [key='finder'] [class='tb-box tb standard-input']");
        
        public static By DefaultAccountButtonBar = By.CssSelector("[key='btnbarIsDefaultAccount']");
        public static By DefaultAccountYesButton = By.CssSelector("[id='uc-create'] [key='btnbarIsDefaultAccount'] [title='Yes']");
        public static By DefaultAccountNoButton = By.CssSelector("[id='uc-create'] [key='btnbarIsDefaultAccount'] [title='No']");

        public static By ReportingMethodWrapper = By.CssSelector("[id='uc-create'] [key='sddlBrokerAccountReportingMethod']");
        public static By ReportingMethodValueElectronicFeed = By.CssSelector("[val='ElectronicFeed']");

        public static By OverwriteReportingFrequencyButtonBar = By.CssSelector("[key='btnbarOverwriteStatementExpectedDays']");

        public static By OverwriteReportingFrequencyYesButton = By.CssSelector("[id='uc-create'] [key='btnbarOverwriteStatementExpectedDays'] [title='Yes']");
        
        public static By OverwriteReportingFrequencyNoButton = By.CssSelector("[id='uc-create'] [key='btnbarOverwriteStatementExpectedDays'] [title='No']");
                
        public static By ReportingFrequencyDaysOverwriteInput = By.CssSelector("[id='uc-create'] [key='numerictbStatementExpectedDaysOverwrite'] [class='tb-box tb standard-input']");

        public static By BrokerAccountsTable = By.CssSelector("[id='uc-grid'] [class='grid gridhover gridselect gridclick']");
        public static By accountNumberFilter = By.CssSelector("[id='uc-grid'] [key='tbSearch_AccountNumber'] [class='tb-box tb standard-input']");
        public static By accountOwnerFilter = By.CssSelector("[id='uc-grid'] [key='tbSearch_AccountOwner'] [class='tb-box tb standard-input']");


    }
}
