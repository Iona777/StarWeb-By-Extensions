using FluentAssertions;

using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Locators.Employee;

using TechTalk.SpecFlow;

using OutsideBusinessActivitiesPage = Star.Web.AutomatedUITests.Locators.Compliance.OutsideBusinessActivitiesPage;

namespace Star.Web.AutomatedUITests.StepDefinitions
{
    [Binding]
    public class OutsideBusinessActivities2StepDefinitions
    {
        [Given(@"I log in with the username ""(.*)""")]
        public void GivenILogInWithTheUsername(string usernamevalue)
        {
            Auth0Page.Url.GoToUrl();
            Auth0Page.Username.SendKeysWithWait(usernamevalue);
        }

        [Given(@"The password ""(.*)""")]
        public void GivenThePassword(string passwordvalue)
        {
            Auth0Page.Password.SendKeys(passwordvalue);
        }

        [Given(@"I click on the Continue button")]
        public void GivenIClickOnTheContinueButton()
        {
            Auth0Page.Continuebtn.Click();
        }

        [Given(@"I click on the Employee button")]
        public void GivenIClickOnTheEmployeeButton()
        {
            CommonPage.EmployeeButton.ClickWithWait();
        }

        [When(@"I click on the OBA tile")]
        public void WhenIClickOnTheOBATile()
        {
            Tiles.OutsideActivity2.ClickWithWait();
        }

        [Then(@"the Outside Business Activity module is opened")]
        public void ThenTheOutsideBusinessActivityModuleIsOpened()
        {
            Locators.Employee.OutsideBusinessActivitiesPage.OutsideBusinessActivitesModal.IsHiddenElementPresent().Should().Be(true);
        }

        [Then(@"the Outside Business Activity page loads successfully")]
        public void ThenTheOutsideBusinessActivityPageLoadsSuccessfully()
        {
            OutsideBusinessActivitiesPage.OutsideBusinessActivitesApp.IsHiddenElementPresent().Should().Be(true);
        }
    }
}
