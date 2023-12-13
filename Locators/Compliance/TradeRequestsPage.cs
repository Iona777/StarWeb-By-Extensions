using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class TradeRequestsPage
    {
        public static By TradeRequestsBreadcrumb = By.XPath("//*[@id='breadcrumb']/li[6]");
        public static By TradeRequestsAccordionTitle = By.CssSelector("[class='accordion-title ']");
        public static By TradeRequestsAccordion = By.CssSelector("[class='accordion'] [section='create']");

                
        public static By SecuritySearch = By.CssSelector("[id='uc-create'] [key='tbSearch'] [class='tb-box tb standard-input']");
        public static By TransactionTypeDropdown = By.CssSelector("[id='uc-create'] [key='sddlTransactionTypeId']");
        public static By BrokerAccountDropdown = By.CssSelector("[id='uc-create'] [key='sddlBrokerAccountId']");                
        public static By NumberOfSharesInput = By.CssSelector  ("[id='uc-create'] [key='numerictbQuantity'] [class='tb-box tb standard-input']");
        public static By MarketPriceInput = By.CssSelector("[id='uc-create'] [key='tbAmount'] [class='tb-box tb standard-input']");
        public static By CurrencyWrapper = By.CssSelector("[id='uc-create'] [key='sddlCurrency']");
        public static By CurrencyInput = By.CssSelector("[id='uc-create'] [key='sddlCurrency'] [title='Filter List'] [class='tb-box tb standard-input']"); 
        public static By MemoInput = By.CssSelector("[id='uc-create'] [key='taMemo'] [class='ta-inner standard-input']");

        public static By SubmitButton = By.CssSelector("[id='uc-create'] [key='btnSave']");
        public static By CancelButton = By.CssSelector("[id='uc-create'] [key='btnCancel']");

        
    }
}
