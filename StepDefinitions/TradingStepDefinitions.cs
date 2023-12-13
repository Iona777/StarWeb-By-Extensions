using FluentAssertions;
using OpenQA.Selenium;
using Star.Web.AutomatedUITests.ComponentHelper;
using Star.Web.AutomatedUITests.Framework.Utilities;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Locators.Compliance;
using Star.Web.AutomatedUITests.Models;
using System;
using System.Globalization;
using System.Threading;
using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class TradingStepDefinitions
    {
        public static bool TradeRequestSubmittedForUser = false;
        public static string UserTradeRequestSubmittedFor = null;
        public static string TradeRequestUUID = null;

        [When(@"the user submits a default ""([^""]*)"" trade")]
        public void WhenTheUserSubmitsADefaultTrade(string transactionType)
        {             
            TradeRequestsPage.SecuritySearch.EnterText(DefaultTradeRequest.securitySymbol, TimeSpan.FromSeconds(45));
            ClickOnSecuritySearchResults(DefaultTradeRequest.securitySymbol);

            TradeRequestsPage.TransactionTypeDropdown.ClickOnElement();
            SelectATransactionType(transactionType);

            TradeRequestsPage.BrokerAccountDropdown.ClickOnElement();
            SelectABrokerAccount(DefaultTradeRequest.brokerAccount);
                                
            TradeRequestsPage.NumberOfSharesInput.EnterText(DefaultTradeRequest.numberOfShares);               

            TradeRequestsPage.MarketPriceInput.EnterText(DefaultTradeRequest.marketPrice);

            //Can maybe change this to wait for the wrapper to not be visible, like the email address, although this one so far seems stable with just the click
            TradeRequestsPage.CurrencyWrapper.ClickOnElement();
            TradeRequestsPage.CurrencyInput.EnterTextAndPressEnter(DefaultTradeRequest.currency);
                     
            TradeRequestsPage.MemoInput.EnterText(DefaultTradeRequest.memoText);

            //Can maybe use the common page save button here? If so, can remove this line and replace with the 'user clicks on save button' step
            TradeRequestsPage.SubmitButton.ClickOnElement();

            //Perhaps check for appearance & disappearance of notification here

        }

        [Then(@"the request has a status of APPROVED")]
        public void ThenTheRequestHasAStatusOfAPPROVED()
        {
            TradeRequestDetailsPage.ApprovedLabel.IsElementDisplayed().Should().BeTrue();
            TradeRequestDetailsPage.ApprovedLabel.GetElementText().Should().Be("APPROVED");

        }

        [Then(@"the trade request ""([^""]*)"" details are correct for user account ""([^""]*)""")]
        public void ThenTheTradeRequestDetailsAreCorrectForUserAccount(string tradeType, string userAccount)
        {
            decimal expectedTotal;
            string expectedTotalFormatted;
            string numberOfSharesFormatted = String.Format("{0:0.0000}", Decimal.Parse(DefaultTradeRequest.numberOfShares));
            string marketPriceFormatted = String.Format("{0:0.00000}", Decimal.Parse(DefaultTradeRequest.marketPrice));

            try
            {
                expectedTotal = Decimal.Parse(DefaultTradeRequest.numberOfShares) *
                                Decimal.Parse(DefaultTradeRequest.marketPrice);
            }
            catch (FormatException)
            {
                throw;
            }

            expectedTotalFormatted = String.Format("{0:0.00}", expectedTotal);
            
            TradeRequestDetailsPage.UserAccount.GetElementText().Should().Contain(userAccount.ToLower());
            TradeRequestDetailsPage.createdBy.GetElementText().Should().Contain(userAccount);
            TradeRequestDetailsPage.brokerAccountTitle.GetElementText().Should().Be(DefaultTradeRequest.brokeAccountTitle);
            TradeRequestDetailsPage.brokerAccountNumber.GetElementText().Should().Be(DefaultTradeRequest.brokeAccountNumber);
            TradeRequestDetailsPage.brokerAccountOffice.GetElementText().Should().Be(DefaultTradeRequest.brokeOffice);
            TradeRequestDetailsPage.securitySymbol.GetElementText().Should().Be(DefaultTradeRequest.securitySymbol);
            TradeRequestDetailsPage.tradeRequestStatus.GetElementText().Should().Be("Approved");
            TradeRequestDetailsPage.transactionType.GetElementText().ToLower().Should().Be(tradeType.ToLower());
            TradeRequestDetailsPage.numberOfShares.GetElementText().Should().Be(numberOfSharesFormatted);
            TradeRequestDetailsPage.marketPrice.GetElementText().Should().Be(marketPriceFormatted);
            TradeRequestDetailsPage.totalAmount.GetElementText().Should().Contain(expectedTotalFormatted);
            TradeRequestDetailsPage.totalAmount.GetElementText().Should().Contain(DefaultTradeRequest.currency);

            TradeRequestSubmittedForUser = true;
            UserTradeRequestSubmittedFor = userAccount;

            String currentURL = Browser.GetCurrentUrl();
            TradeRequestUUID = currentURL.Substring(currentURL.Length - 32);
        }

        [Given(@"I have submitted a ""([^""]*)"" trade for for user account ""([^""]*)""")]
        public void GivenIHaveSubmittedATradeForForUserAccount(string transactionType, string userAccount)
        {
            
            if (!TradeRequestSubmittedForUser || UserTradeRequestSubmittedFor == userAccount )
            {
                submitTradeRequest(transactionType,userAccount);
            }
        }

        private void submitTradeRequest(string transactionType, string userAccount)
        {
            string tradingMenuName= "Trading";
            string tradingSubMenu = "Trade Requests";

            string tradingDetailsMenuName = "Trading";
            string tradingDetailsSubMenu = "Trade Requests";


            string tradeRequestsAccordionName = "TRADE REQUESTS";
            string tradeRequestsPage = "Trade Requests";

            string tradeDetailsOverviewAccordionName = "TRADE REQUEST DETAILS OVERVIEW";
            string tradeDetailsAccordionName = "TRADE REQUEST DETAILS REQUEST DETAILS";
            string tradeDetailsPage = "Trade Request Details";

            string area = "Compliance";

            MenuHelper.OpenSubMenu(tradingMenuName, tradingSubMenu);
            CommonStepDefinitions.WhenTheUserExpandsAccordionOnThePageInTheArea(tradeRequestsAccordionName,tradeRequestsPage, area);

            BrokerageStepDefinitions.ThenTheUserSearchesForUserAccount(userAccount);
            WhenTheUserSubmitsADefaultTrade(transactionType);

            CommonStepDefinitions.WhenTheUserExpandsAccordionOnThePageInTheArea(tradeDetailsOverviewAccordionName, tradeDetailsPage, area);
            ThenTheRequestHasAStatusOfAPPROVED();

            CommonStepDefinitions.WhenTheUserExpandsAccordionOnThePageInTheArea(tradeDetailsAccordionName, tradeDetailsPage, area);
            ThenTheTradeRequestDetailsAreCorrectForUserAccount(transactionType, userAccount);

        }

        [Then(@"the Trade Request is executed successfully")]
        public void ThenTheTradeRequestIsExecutedSuccessfully()
        {
            TradeRequestDetailsPage.ExecuteTradeButton.ClickOnElement();
            ExecuteTradeRequestPage.ExecuteButton.ClickOnElement();

            NotificationHelper.GetNotificationText().Should().Contain("The transaction has been executed with a reference code of") ;
        }

        public static void SelectABrokerAccount(string searchString)
        {
            string cssString = $"[title='{searchString}']";
            By optionLocator = By.CssSelector(cssString);
                        optionLocator.ClickOnElement();
        }

        public static void SelectATransactionType(string transactionType)
        {
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            transactionType = textInfo.ToTitleCase(transactionType);

            string cssString = $"[title='{transactionType}']";
            By optionLocator = By.CssSelector(cssString);

            optionLocator.ClickOnElement();
        }

        public static void ClickOnSecuritySearchResults(string searchString)
        {
            string cssString = $"tr[identifier='{searchString.ToUpper()}']";
            By searchResultsLocator = By.CssSelector(cssString);

            searchResultsLocator.ClickOnElement(TimeSpan.FromSeconds(45));
        }

    }
}