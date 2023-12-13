using OpenQA.Selenium;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class GiftsAndEntertainmentPage
    {
        public static By GiftsBreadcrumb = By.XPath("//*[@id='breadcrumb']/li[6]");
        public static By DeclareGiftAccordionTitle = By.CssSelector("[class='accordion-title ']");
        public static By DeclareGiftAccordion = By.ClassName("accordion");
        public static By DeclareGiftAccordionExpander = By.ClassName("expander");
        public static By MasterMenuGift = By.XPath("//*[@id='mastermenu']/ul/div[6]/ul/li[1]/h1");
        public static By ColHeader = By.ClassName("colheader");
        public static By ViewNameDropdown = By.CssSelector("[title='Select Grid View']");
        public static By FrontFooter = By.ClassName("footer");
    }
}