using System;
using System.Globalization;
using OpenQA.Selenium;

using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers;
using Star.Web.AutomatedUITests.Locators;

namespace Star.Web.AutomatedUITests.ComponentHelper
{
    public class AccordionHelper
    {
        /// <summary>
        /// Returns the By for the accordion for the given name and details
        /// </summary>
        /// <param name="accordionName">Name of the accordion</param>
        /// <param name="pageName">Page object name the acorrdion element belongs to</param>
        /// <param name="area">Area, either compliance or support</param>
        /// <returns></returns>
        public static By GetAccordionElementByName(string accordionName, string pageName, string area)
        {
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            var parsedName = textInfo.ToTitleCase(accordionName.ToLower());

            //In this case, baseType is the page object that we are looking at.
            var baseType = Type.GetType($"Star.Web.AutomatedUITests.Locators.{area}.{pageName.Replace(" ", "")}Page");

            //This will Get the value of the fieldname , e.g. "DeclareGiftAccordion"
            var accordion = baseType.GetField($"{parsedName.Replace(" ", "")}Accordion").GetValue(null);
                        
            if (accordion != null)
                return (By)accordion;
            else
                return null;
        }


        /// <summary>
        /// Opens an accordion by the given name and details
        /// </summary>
        /// <param name="accordionName"></param>
        /// <param name="pageName"></param>
        /// <param name="pageArea"></param>
        public static void OpenAccordionByName(string accordionName, string pageName, string pageArea)
        {
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            var parsedName = textInfo.ToTitleCase(accordionName.ToLower());

            //In this case, baseType is the page object that we are looking at.
            var baseType = Type.GetType($"Star.Web.AutomatedUITests.Locators.{pageArea}.{pageName.Replace(" ", "")}Page");

            //This will Get the value of the fieldname
            var accordion = baseType.GetField($"{parsedName.Replace(" ", "")}Accordion").GetValue(null);

            //Will take the given By, if not null, and open the accordian element
            if (accordion != null)
                ExpandAccordionByName((By)accordion);
        }

       
        /// <summary>
        /// Takes in an accordon By and clicks on its associated Expander element
        /// </summary>
        /// <param name="accordionElement">The accordion to expand</param>
        private static void ExpandAccordionByName(By accordionElement)
        {
            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();

            if (!IsTheAccordionElementOpen(accordionElement))
            {
                var AccordionElement = accordionElement.GetVisibleElement();
                ClickOnExpander(AccordionElement);   
            }             

            CommonPage.AccordionLoadingSpinner.WaitUntilElementIsNotDisplayed();
        }


        /// <summary>
        /// Clicks on the expander element associated with the given accordion element
        /// </summary>
        /// <param name="accordionElement">Accordion that the expander is associated with</param>
        private static void ClickOnExpander(IWebElement accordionElement)
        {
            IWebElement expander = accordionElement.FindElement(CommonPage.AccordionExpander);
            expander.Click();
        }


        /// <summary>
        /// Checks to see if the given accordion is open
        /// </summary>
        /// <param name="accordionBy">Locator for the accordion</param>
        /// <returns></returns>
        public static bool IsTheAccordionElementOpen(By accordionBy)
        {
            bool isAccordionOpen = false;
            IWebElement accordion = GetElements.GetVisibleElement(accordionBy);
                        
            if (accordion.GetAttribute("class").Contains("accordion-open"))
                isAccordionOpen = true;

            return isAccordionOpen;
        }

    }
}