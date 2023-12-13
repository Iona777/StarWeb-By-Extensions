using OpenQA.Selenium;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class BlackoutListPage
    {
        public static By CreateNewBlackoutSecurityButton = By.CssSelector("li[section='create']>h1");

        public static By BlackoutListSecuritiesAccordion = By.CssSelector("li[section='grid']>h1");

        public static By CreateNewBlackoutIssuerButton = By.CssSelector("li[section='createissuer']>h1");

        public static By BlackoutListsIssuerAccordion = By.CssSelector("li[section='issuergrid']>h1");
    }
}