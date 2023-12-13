using OpenQA.Selenium;
using Star.Web.AutomatedUITests.Framework.Configuration;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers
{
    public static class GetElements
    {
        /// <summary>
        /// Waits for, then returns, a visible element
        /// </summary>
        /// <param name="elementLocator">elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// <param name="customTimeout">Optionally set the timeout in seconds </param>
        /// <returns></returns>
        public static IWebElement GetVisibleElement(this By elementLocator, TimeSpan? customTimeout = null, int noOfRetries=1)
        {
            var wait = SeleniumExecutor.WaitDriver(customTimeout);

            return wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
        }

        public static bool WaitForElementByText(this IWebElement element, string textSearch, TimeSpan? customTimeout = null)
        {
            var wait = SeleniumExecutor.WaitDriver(customTimeout);

            return wait.Until(ExpectedConditions.TextToBePresentInElement(element,textSearch));
        }


        /// <summary>
        /// Waits for, then returns, an element that exist on the DOM
        /// </summary>
        /// <param name="elementLocator">elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// <param name="customTimeout">Optionally set the timeout in seconds </param>
        /// <returns></returns>
        public static IWebElement GetExistingElement(this By elementLocator, TimeSpan? customTimeout = null)
        {
            var wait = SeleniumExecutor.WaitDriver(customTimeout);

            return wait.Until(ExpectedConditions.ElementExists(elementLocator));

        }


        /// <summary>
        /// Waits for, then returns, a clickable element
        /// </summary>
        /// <param name="elementLocator">elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// <param name="customTimeout">Optionally set the timeout in seconds </param>
        /// <returns></returns>
        public static IWebElement GetClickableElement(this By elementLocator, TimeSpan ? customTimeout = null)
        {   
            var wait = SeleniumExecutor.WaitDriver(customTimeout);

            return wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));

        }

        /// <summary>
        /// Waits for, then returns, a visible element
        /// </summary>
        /// <param name="elementLocator">elementLocator">Used to locate the element, e.g. By.Id("xyz")</param>
        /// <param name="customTimeout">Optionally set the timeout in seconds </param>
        /// <returns></returns>
        public static IWebElement GetClickableElement(this By elementLocator, TimeSpan? customTimeout = null, int noOfRetries = 1)
        {
            var wait = SeleniumExecutor.WaitDriver(customTimeout);

            return wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));
        }

    }
}
