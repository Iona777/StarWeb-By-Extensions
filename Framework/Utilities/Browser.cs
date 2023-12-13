using System;
using System.Collections.ObjectModel;

using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

using Star.Web.AutomatedUITests.Framework.Configuration;
using Star.Web.AutomatedUITests.Framework.Configuration.Enums;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Framework.Utilities.Helpers;
using Star.Web.AutomatedUITests.Locators;

namespace Star.Web.AutomatedUITests.Framework.Utilities
{
    public static class Browser
    {
        public static void GoToUrl(string url)
        {
            var targetUrl = $"{SeleniumExecutor.BaseUrl}{url}";

            if (GetCurrentUrl() != targetUrl)
                SeleniumExecutor.Driver().Navigate().GoToUrl(targetUrl);

            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();
        }

        public static void GoToPage(string page, string queryString = "")
        {
            //var uri = new Uri(string.Concat(SeleniumExecutor.BaseUrl, page));
            var targetUrl = $"{SeleniumExecutor.BaseUrl}{page}{queryString}";

            try
            {
                SeleniumExecutor.Driver().Url = targetUrl;
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Webdriver could not reach specified URL within timeout limit. \n Target URL: {targetUrl} \n Actual URL: {SeleniumExecutor.Driver().Url} \n", e);
            }

            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();
        }

        public static void RefreshPage()
        {
            SeleniumExecutor.Driver().Navigate().Refresh();
        }

        public static void NavigateBack()
        {
            SeleniumExecutor.Driver().Navigate().Back();
        }

        public static void NavigateForward()
        {
            SeleniumExecutor.Driver().Navigate().Forward();
        }

        public static string GetCurrentUrl()
        {
            return SeleniumExecutor.Driver().Url;
        }

        public static string GetTitle()
        {
            return SeleniumExecutor.Driver().Title;
        }

        public static void AddCookie(Cookie cookie)
        {
            SeleniumExecutor.Driver().Manage().Cookies.AddCookie(cookie);
        }

        public static void DeleteCookie(Cookie cookie)
        {
            SeleniumExecutor.Driver().Manage().Cookies.DeleteCookie(cookie);
        }

        public static void DeleteCookies()
        {
            SeleniumExecutor.Driver().Manage().Cookies.DeleteAllCookies();
        }

        public static BrowserType GetBrowserType()
        {
            var capabilities = ((RemoteWebDriver)SeleniumExecutor.Driver()).Capabilities;
            var browserName = capabilities.GetCapability("BrowserName").ToString();

            return Enum.Parse<BrowserType>(browserName ?? BrowserType.Chrome.ToString());
        }

        public static void SwitchToWindowHandle(int window)
        {
            var windowHandles = GetWindowHandles();
            SeleniumExecutor.Driver().SwitchTo().Window(windowHandles[window]);
        }

        public static void SwitchToFrame(IWebElement frame)
        {
            SeleniumExecutor.Driver().SwitchTo().Frame(frame);
        }

        public static void SwitchToFrame(By frame)
        {
            SeleniumExecutor.Driver().SwitchTo().Frame(frame.GetElement());
        }

        public static void SwitchToFrameWithWait(By frame)
        {
            SeleniumExecutor.Driver().SwitchTo().Frame(frame.GetElementWithWait());
        }

        public static void SwitchToDefaultContent()
        {
            SeleniumExecutor.Driver().SwitchTo().DefaultContent();
        }

        public static IAlert SwitchToAlert()
        {
            return SeleniumExecutor.Driver().SwitchTo().Alert();
        }

        public static void SwitchToActiveElement()
        {
            SeleniumExecutor.Driver().SwitchTo().ActiveElement();
        }

        public static ReadOnlyCollection<string> GetWindowHandles()
        {
            return SeleniumExecutor.Driver().WindowHandles;
        }

        public static void AcceptAlert()
        {
            if (!IsAlertPresent()) return;
            var alert = SwitchToAlert();
            alert.Accept();
            Wait.ForJsJq();
        }

        public static void DismissAlert()
        {
            if (!IsAlertPresent())
            {
                return;
            }

            var alert = SwitchToAlert();
            alert.Dismiss();
            Wait.ForJsJq();
        }

        public static void ScrollIntoView(By elementLocator, bool alignToTop = true)
        {
            ScrollIntoView(elementLocator.GetElement(), alignToTop);
        }

        public static void ScrollIntoView(IWebElement element, bool alignToTop = true)
        {
            var scrollArgument = alignToTop.ToString().ToLower();
            try
            {
                SeleniumExecutor.JavaScriptExecutor.ExecuteScript($"arguments[0].scrollIntoView({scrollArgument});", element);
            }
            catch
            {
                //// ignore (because of occurring WebDriverTimeoutException)
            }
        }

        private static bool IsAlertPresent()
        {
            try
            {
                SwitchToAlert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
            catch (NoSuchWindowException)
            {
                return false;
            }
            catch (WebDriverException)
            {
                return false;
            }
        }
    }
}