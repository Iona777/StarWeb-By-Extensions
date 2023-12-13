using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Star.Web.AutomatedUITests.Framework.Configuration.Enums;
using OpenQA.Selenium.Support.Extensions;

namespace Star.Web.AutomatedUITests.Framework.Configuration
{
    public static class SeleniumExecutor
    {
        private static IWebDriver? _webDriver;

        public static ISearchContext SearchContext => Driver();

        public static IJavaScriptExecutor? JavaScriptExecutor => Driver() as IJavaScriptExecutor;

        public static Actions Actions => new(Driver());

        internal static string BaseUrl = GetBaseUrlFromConfig();

        public static IWebDriver Driver()
        {
            return _webDriver ?? Initialize(string.Empty);
        }

        public static IWebDriver Initialize(string testName)
        {
            _webDriver = WebDriverFactory.InitializeDriver(ConfigurationProvider.GetConfiguration().WebDriverSettings.BrowserType, testName);

            if (ConfigurationProvider.GetConfiguration().WebDriverSettings.BrowserType != BrowserType.Iphone12 &&
                ConfigurationProvider.GetConfiguration().WebDriverSettings.BrowserType != BrowserType.SamsungGalaxyS20)
            {
                _webDriver.Manage().Window.Maximize();
            }

            return _webDriver;
        }

        public static string GetRemoteSessionId()
        {
            var remoteDriver = (RemoteWebDriver)Driver();
            return remoteDriver.SessionId.ToString();
        }

        public static WebDriverWait WaitDriver(int customTimeout = 0, Type[]? exceptionsToIgnore = null)
        {
            var waitTimeout = customTimeout == 0 ? ConfigurationProvider.GetConfiguration().WebDriverSettings.WaitTimeout : customTimeout;
            var waitDriver = new WebDriverWait(Driver(), TimeSpan.FromSeconds(waitTimeout));
            if (exceptionsToIgnore == null)
            {
                return waitDriver;
            }

            foreach (var type in exceptionsToIgnore)
            {
                waitDriver.IgnoreExceptionTypes(type);
            }

            return waitDriver;
        }

        public static WebDriverWait WaitDriver(TimeSpan? customTimeout = null, Type[]? exceptionsToIgnore = null)
        {
            var waitTimeout = customTimeout ?? TimeSpan.FromSeconds(ConfigurationProvider.GetConfiguration().WebDriverSettings.WaitTimeout);
            var waitDriver = new WebDriverWait(Driver(), waitTimeout);
            if (exceptionsToIgnore == null)
            {
                return waitDriver;
            }

            foreach (var type in exceptionsToIgnore)
            {
                waitDriver.IgnoreExceptionTypes(type);
            }

            return waitDriver;
        }

        private static string GetBaseUrlFromConfig()
        {
            return ConfigurationProvider.GetConfiguration().BaseUrl;
        }

        /// <summary>
        /// Returns the value of title of the current browser window
        /// </summary>
        /// <returns>string</returns>
        public static string GetPageTitle()
        {
            return _webDriver.Title;
        }

        public static void DeleteAllCookies()
        {
            SeleniumExecutor.Driver().Manage().Cookies.DeleteAllCookies();
        }

        public static void Close()
        {
            _webDriver.Dispose();
            _webDriver.Quit();
        }
    }
}