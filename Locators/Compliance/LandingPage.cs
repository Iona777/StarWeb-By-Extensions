using OpenQA.Selenium;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class LandingPage
    {
        public static By LandingPageTxt = By.XPath(".//*[@id='qprompt-strip']/div/span");

        public static By ToReviewGrid = By.XPath("//tr//th//h3");
    }
}