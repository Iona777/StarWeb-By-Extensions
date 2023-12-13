using System;
using System.Threading;
using FluentAssertions;

using Star.Web.AutomatedUITests.ComponentHelper;
using Star.Web.AutomatedUITests.Constants;
using Star.Web.AutomatedUITests.Framework.Utilities;
using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class MenuNavigationStepDefinitions
    { 
        //[When(@"the user selects ""([^""]*)"" from the ""([^""]*)"" menu")]
        [StepDefinition(@"the user selects ""([^""]*)"" from the ""([^""]*)"" menu")]
        public static void WhenTheUserSelectsFromTheMenu(string subMenu, string menuName)
        {
                MenuHelper.OpenSubMenu(menuName, subMenu);
        }

        [Then(@"I am taken to the ""([^""]*)"" page")]
        public static void ThenIAmTakenToThePage(string page)
        {
            var pathRepository = typeof(PagePaths);
            var uri = new Uri(Browser.GetCurrentUrl());

            var pagePath = pathRepository.GetField($"{page.Replace(" ", "")}").GetValue(pathRepository);
            uri.AbsolutePath.Should().Be($"/{pagePath}");
        }

        [Given(@"I am on the ""([^""]*)"" page")]
        public static void GivenIAmOnThe(string pagePathName)
        {
            if (typeof(PagePaths).GetField(pagePathName.Replace(" ", "")).GetValue(null) is string value)
            {
                switch (pagePathName)
                {
                    case "UserAccountDetails":
                        value = value + EmployeesStepDefinitions.NewUserId;
                        break;
                    case "TradeRequestDetails":
                        value = value + TradingStepDefinitions.TradeRequestUUID;
                        break;
                    default:
                        break;
                }
                
                Browser.GoToUrl(value);              
            }
        }
    }
}