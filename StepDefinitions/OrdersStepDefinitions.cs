using OpenQA.Selenium;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers;
using Star.Web.AutomatedUITests.Locators.Compliance;
using Star.Web.AutomatedUITests.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class OrdersStepDefinitions
    {

        [When(@"the user enters default values to declare and amended order")]
        public void WhenTheUserEntersDefaultValuesToDeclareAndAmendedOrder()
        {
            OrdersPage.BrokerAccountDropdown.ClickOnElement();
            SelectABrokerAccount(DefaultAmendedOrder.brokerAccount);



            OrdersPage.Security.EnterText(DefaultAmendedOrder.securitySymbol);
            ClickOnSecuritySearchResults(DefaultAmendedOrder.securitySymbol);    

            //CommonStepDefinitions.ClickOnSearchResults(DefaultAmendedOrder.securitySymbol);

            

            OrdersPage.TransactionTypeDropdown.ClickOnElement();
            SelectAGenericType(DefaultAmendedOrder.transactionType);

            OrdersPage.OrderTypeDropdown.ClickOnElement();
            SelectAGenericType(DefaultAmendedOrder.orderType);

            OrdersPage.DurationDropdown.ClickOnElement();
            
            //This one won't work with generic type
            SelectADurationType(DefaultAmendedOrder.duration);

            OrdersPage.OrderDatedMMWrapper.ClickOnElement();
            OrdersPage.OrderDateMMInput.EnterText(DefaultAmendedOrder.OrderDateMM);

            OrdersPage.OrderDatedDDWrapper.ClickOnElement();
            OrdersPage.OrderDateDDInput.EnterText(DefaultAmendedOrder.OrderDateDD);

            OrdersPage.OrderDatedYYYYWrapper.ClickOnElement();
            OrdersPage.OrderDateYYYYInput.EnterText(DefaultAmendedOrder.OrderDateYYYY);

            OrdersPage.Quantity.ClearValue();
            OrdersPage.Quantity.EnterText(DefaultAmendedOrder.quantity);

            //If you use an order typer other than Limit, this will not be displayed
            if (OrdersPage.LimitPrice.IsElementDisplayed())
            {
                OrdersPage.LimitPrice.EnterText(DefaultAmendedOrder.LimitPrice);
            }
            

            OrdersPage.BrokerReference.EnterText(DefaultAmendedOrder.brokerReference);
            OrdersPage.Memo.EnterText(DefaultAmendedOrder.memoText);
            
            OrdersPage.AmendmentTypeDropdown.ClickOnElement();
            SelectAGenericType(DefaultAmendedOrder.amendmentType);

        }

        //Consider making this a common method
        public static void SelectABrokerAccount(string searchString)
        {
            string cssString = $"[title='{searchString}']";
            By optionLocator = By.CssSelector(cssString);
            optionLocator.ClickOnElement();
        }

        //Consider making this a common method
        public static void ClickOnSecuritySearchResults(string searchString)
        {
            string cssString = $"tr[identifier='{searchString.ToUpper()}']";
            By searchResultsLocator = By.CssSelector(cssString);

            searchResultsLocator.ClickOnElement(TimeSpan.FromSeconds(45));
        }

       
         public static void SelectADurationType(string durationType)
        {
            //NOTE: need to be sure that the durationType has the correct case or it will not be found
            string cssString = $"[title='{durationType}']";
            By optionLocator = By.CssSelector(cssString);

            optionLocator.ClickOnElement();
        }


        //Consider makeing this a common method
        public static void SelectAGenericType(string type)
        {
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            type = textInfo.ToTitleCase(type);

            string cssString = $"[title='{type}']";
            By optionLocator = By.CssSelector(cssString);

            optionLocator.ClickOnElement();
        }
    }
}
