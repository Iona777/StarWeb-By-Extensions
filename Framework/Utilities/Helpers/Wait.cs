using System;
using System.Threading;

using OpenQA.Selenium;

using SeleniumExtras.WaitHelpers;

using Star.Web.AutomatedUITests.Framework.Configuration;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;

namespace Star.Web.AutomatedUITests.Framework.Utilities.Helpers
{
    public static class Wait
    {
        public static void ForJsJq()
        {
            var waitDriver = SeleniumExecutor.WaitDriver(0);

            try
            {
                waitDriver.Until(d => (bool)(d as IJavaScriptExecutor).ExecuteScript("return document.readyState === 'complete'"));
                waitDriver.Until(d => (bool)(d as IJavaScriptExecutor).ExecuteScript("return jQuery.active === 0"));
            }
            catch (Exception) { }
        }

        public static void ForElementText(By elementLocator, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(d => !string.IsNullOrEmpty(elementLocator.GetText()));
            }
            catch (WebDriverTimeoutException)
            {
                throw new WebDriverTimeoutException($"The text in element: '{elementLocator}' was either null or empty");
            }
        }

        public static void UntilElementPresence(By elementLocator, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(
                    d =>
                    {
                        try
                        {
                            d.FindElement(elementLocator);
                            return true;
                        }
                        catch (NoSuchElementException)
                        {
                            return false;
                        }
                    });
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element with locator: '{elementLocator}' could not be found within specified timeout limit", e);
            }
        }

        public static void UntilElementIsDisplayed(By elementLocator, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(d => elementLocator.IsDisplayed());
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element with locator: '{elementLocator}' wasn't visible within specified timeout limit", e);
            }
        }

        public static void UntilElementsAreDisplayed(By elementsLocator, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elementsLocator));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Elements with locator: '{elementsLocator}' weren't visible within specified timeout limit", e);
            }
        }

        public static void UntilElementIsDisplayed(IWebElement element, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(d => element.Displayed);
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException("Element wasn't visible within specified timeout limit", e);
            }
        }

        public static void UntilElementIsEnabled(By elementLocator, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(d => elementLocator.GetElement().Enabled);
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element with locator: '{elementLocator}' wasn't enabled within specified timeout limit", e);
            }
        }

        public static void UntilElementIsEnabled(IWebElement element, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(d => element.Enabled);
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException("Element wasn't enabled within specified timeout limit", e);
            }
        }

        public static void UntilElementIsClickable(By elementLocator, int customTimeout = 0)
        {
            UntilElementIsClickable(elementLocator.GetElement(), customTimeout);
        }

        public static void UntilElementIsClickable(IWebElement element, int customTimeout = 0)
        {
            var attempts = 0;
            var timeout = customTimeout == 0 ? ConfigurationProvider.GetConfiguration().WebDriverSettings.WaitTimeout : customTimeout;
            while (attempts < timeout)
            {
                try
                {
                    SeleniumExecutor.WaitDriver(1).Until(ExpectedConditions.ElementToBeClickable(element));
                    return;
                }
                catch (StaleElementReferenceException) { }
                catch (ElementClickInterceptedException) { }
                catch (WebDriverTimeoutException) { }

                attempts++;

                throw new WebDriverTimeoutException("Element wasn't clickable within timeout limit");
            }
        }

        public static void UntilElementIsNotDisplayed(By elementLocator, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(d => !elementLocator.IsDisplayed());
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element with locator: '{elementLocator}' didn't disappear within specified timeout limit", e);
            }
        }

        public static void UntilElementIsNotDisplayed(IWebElement element, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(d => !element.Displayed);
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException("Element didn't disappear within specified timeout limit", e);
            }
        }

        public static void UntilElementHasClass(By elementLocator, string className, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(d => elementLocator.HasClass(className));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element with locator: '{elementLocator}' didn't have expected class '{className}' within specified timeout limit", e);
            }
        }

        public static void UntilElementHasAttributesValue(By elementLocator, string attribute, string expectedValue, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(d => elementLocator.GetAttribute(attribute).Equals(expectedValue));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element with locator: '{elementLocator}' didn't have expected value '{expectedValue}' in '{attribute}' within specified timeout limit", e);
            }
        }

        public static void UntilElementHasAttributesValue(IWebElement element, string attribute, string expectedValue, TimeSpan? customTimeout = null)
        {
            try
            {
                SeleniumExecutor.WaitDriver(customTimeout).Until(d => element.GetAttribute(attribute).Equals(expectedValue));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element didn't have expected value '{expectedValue}' in '{attribute}' attribute within specified timeout limit", e);
            }
        }

        public static void Explicit(TimeSpan time)
        {
            Thread.Sleep(time);
        }

        public static void Explicit(int seconds)
        {
            Explicit(TimeSpan.FromSeconds(seconds));
        }
    }
}