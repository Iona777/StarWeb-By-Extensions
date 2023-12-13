using OpenQA.Selenium;
using System;

namespace Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers
{
    public static class ExamineElements
    {

        /// <summary>
        /// Checks if an element is visible on the page. Visibility means that the element
        /// is not only displayed but also has a height and width that is greater than 0.
        /// </summary>
        /// <param name="elementLocator"></param>
        /// <param name="customTimeout">Optionally set the timeout </param>
        /// <returns>bool</returns>
        public static bool IsElementDisplayed(this By elementLocator, TimeSpan? customTimeout= null)
        {
            try
            {
                var element = elementLocator.GetVisibleElement(customTimeout);
                return element.Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }

        }


        /// <summary>
        /// Returns the text of the element found by the given elementLocator
        /// </summary>
        /// <param name="elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// /// <param name="customTimeout">Optionally set the timeout </param>
        /// <returns>string</returns>
        public static string GetElementText(this By elementLocator, TimeSpan? customTimeout=null)
        {
            return elementLocator.GetVisibleElement(customTimeout).Text;
        }

    }
    
}
