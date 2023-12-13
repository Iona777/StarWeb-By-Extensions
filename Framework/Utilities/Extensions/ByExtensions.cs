using System;
using System.Collections.Generic;
using System.Linq;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using Star.Web.AutomatedUITests.Framework.Configuration;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers;
using Star.Web.AutomatedUITests.Framework.Utilities.Helpers;

namespace Star.Web.AutomatedUITests.Framework.Utilities.Extensions
{
    public static class ByExtensions
    {
        public static IWebElement GetElement(this By elementLocator)
        {
            return SeleniumExecutor.SearchContext.FindElement(elementLocator);
        }

        public static IWebElement GetHiddenElementWithWait(this By elementLocator, TimeSpan? customTimeout = null)
        {
            Wait.UntilElementPresence(elementLocator, customTimeout);
            return SeleniumExecutor.SearchContext.FindElement(elementLocator);
        }

        public static IWebElement GetElementWithWait(this By elementLocator, TimeSpan? customTimeout = null, bool alignToTop = true)
        {
            WaitUntilElementIsDisplayed(elementLocator, customTimeout, alignToTop);
            return elementLocator.GetElement();
        }

        public static void WaitUntilElementIsDisplayed(this By elementLocator, TimeSpan? customTimeout = null, bool alignToTop = true)
        {
            elementLocator.ScrollIntoElement(customTimeout, alignToTop);
            Wait.UntilElementIsDisplayed(elementLocator, customTimeout);
        }

        public static void WaitUntilElementIsNotDisplayed(this By elementLocator, TimeSpan? customTimeout = null)
        {
            Wait.UntilElementIsNotDisplayed(elementLocator, customTimeout);
        }     

        public static void Click(this By elementLocator)
        {
            elementLocator.GetElement().Click();
        }

        public static void ClickWithWait(this By elementLocator, TimeSpan? customTimeout = null, bool allignToTop = true)
        {
            elementLocator.GetElementWithWait(customTimeout, allignToTop).Click();
        }

        public static void JsClick(this By elementLocator)
        {
            elementLocator.JsClick();
        }

        
        public static void SendKeys(this By elementLocator, string text)
        {
            elementLocator.GetElement().SendKeys(text);
        }

        public static void SendKeysWithWait(this By elementLocator, string text, TimeSpan? customTimeout = null, bool allignToTop = true)
        {
            elementLocator.GetElementWithWait(customTimeout, allignToTop).SendKeys(text);
        }

        public static void ScrollIntoElement(this By elementLocator, TimeSpan? customTimeout = null, bool allignToTop = true)
        {
            Wait.UntilElementPresence(elementLocator, customTimeout);
            Browser.ScrollIntoView(elementLocator, allignToTop);
        }

        public static string GetAttribute(this By elementLocator, string attribute)
        {
            return elementLocator.GetElement().GetAttribute(attribute);
        }

        public static string GetText(this By elementLocator)
        {
            return elementLocator.GetElement().Text;
        }

        public static string GetTextWithWait(this By elementLocator, TimeSpan? customTimeout = null, bool allignToTop = true)
        {
            return elementLocator.GetElementWithWait(customTimeout, allignToTop).Text;
        }

        public static bool IsDisplayed(this By elementLocator)
        {
            try
            {
                var element = elementLocator.GetElement();
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
        }

        public static bool IsDisplayedAfterWait(this By elementLocator, TimeSpan? customTimeout = null, bool allignToTop = true)
        {
            try
            {
                return elementLocator.GetElementWithWait(customTimeout, allignToTop).Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public static bool HasClass(this By elementLocator, string className)
        {
            return elementLocator.GetAttribute("class").Contains(className);
        }

        
        public static bool IsHiddenElementPresent(this By elementLocator, TimeSpan? customTimeout = null)
        {
            try
            {
                elementLocator.GetHiddenElementWithWait(customTimeout);
                return true;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
        }

      
    }
}