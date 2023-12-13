using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using Star.Web.AutomatedUITests.StepDefinitions;
using System;
using System.Threading;

namespace Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers
{
    
    public static class OperateElements
    {
        /// <summary>
        /// Waits for element with given By to be clickable and then clicks on it
        /// <param name="elementLocator">elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// <param name="customTimeout">Optionally set the timeout</param>
        /// </summary>
        public static void ClickOnElement(this By elementLocator, TimeSpan? customTimeout=null, int noOfRetries=1)
        {
            elementLocator.GetClickableElement(customTimeout, noOfRetries).Click();
        }

        /// <summary>
        /// Waits for element with given By to be visible and then enters the given text
        /// <param name="elementLocator">elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// <param name="customTimeout">Optionally set the timeout</param>
        /// </summary>
        public static void EnterText(this By elementLocator, string text, TimeSpan? customTimeout=null, int noOfRetries=1)
        {
            GetElements.GetVisibleElement(elementLocator, customTimeout, noOfRetries).SendKeys(text);
                        
        }

        /// <summary>
        /// Waits for element with given By to be visible and then clears the value
        /// <param name="elementLocator">elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// <param name="customTimeout">Optionally set the timeout</param>
        /// </summary>
        public static void ClearValue(this By elementLocator, TimeSpan? customTimeout = null)
        {
            GetElements.GetVisibleElement(elementLocator, customTimeout).Clear();
        }

        /// <summary>
        /// Waits for element with given By to exist on DOM and then enters the given text
        /// <param name="elementLocator">elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// <param name="customTimeout">Optionally set the timeout</param>
        /// </summary>
        public static void EnterTextInNonVisibleElement(this By elementLocator, string text, TimeSpan? customTimeout = null)
        {
            GetElements.GetExistingElement(elementLocator, customTimeout).SendKeys(text);
        }

        /// <summary>
        /// Waits for element with given By to be visible and then enters the given text and presses the Enter key
        /// <param name="elementLocator">elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// <param name="customTimeout">Optionally set the timeout</param>
        /// </summary>
        public static void EnterTextAndPressEnter(this By elementLocator, string text, TimeSpan? customTimeout = null)
        {
            GetElements.GetVisibleElement(elementLocator, customTimeout).SendKeys(text);
            GetElements.GetVisibleElement(elementLocator, customTimeout).SendKeys(Keys.Return);
        }
    }
}
