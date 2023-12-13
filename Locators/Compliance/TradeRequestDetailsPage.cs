using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class TradeRequestDetailsPage
    {
        public static By TradeRequestDetailsBreadcrrumb = By.XPath("//*[@id='breadcrumb']/li[8]");
        public static By TradeRequestDetailsAccordionTitle = By.CssSelector("[class='accordion-title ']");
        public static By TradeRequestDetailsOverviewAccordion = By.CssSelector("[class='accordion'] [section='overview']");
        public static By TradeRequestDetailsRequestDetailsAccordion = By.CssSelector("[class='accordion'] [section='traderequestdetails']");
        public static By TradeRequestDetailsFormAccordion = By.CssSelector("[class='accordion'] [section='form']");
        

        public static By TradeRequestDetailsOverviewAccordionExpander 
            = By.CssSelector("[section='overview'] [class='expander']");

        public static By TradeRequestDetailsRequestDetailsAccordionExpander
            = By.CssSelector("[section='traderequestdetails'] [class='expander']");

        public static By ApprovedLabel = By.CssSelector(".status-label.approved");
        public static By TradeRequestId = By.CssSelector("[key='rotReferenceCode']");
        public static By UserAccount = By.CssSelector("[key='rotUserAccount']");
        public static By createdBy = By.CssSelector("[key='rotCreatedBy']");
        public static By brokerOffice = By.CssSelector("[key='rotBrokerAccountOfficeName']");
        public static By tradeRequestStatus = By.CssSelector("[key='rotStatus']");
        public static By brokerAccountTitle = By.CssSelector("[key='rotBrokerAccountName']");
        public static By brokerAccountNumber = By.CssSelector("[key='rotBrokerAccountNumber']");
        public static By brokerAccountOffice = By.CssSelector("[key='rotBrokerAccountOfficeName']");
        public static By securitySymbol = By.CssSelector("[key='rotSymbol']");
        public static By transactionType = By.CssSelector("[key='rotTransactionType']");
        public static By numberOfShares = By.CssSelector("[key='rotQuantity']");
        public static By marketPrice = By.CssSelector("[key='rotPrice']");
        public static By totalAmount = By.CssSelector("[key='rotPrincipalAmount']");

        public static By ExecuteTradeButton = By.CssSelector("[action='execute']");

    }
}
