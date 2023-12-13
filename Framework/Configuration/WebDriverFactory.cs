using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;

using Star.Web.AutomatedUITests.Framework.Configuration.Enums;
using Star.Web.AutomatedUITests.Framework.Configuration.Helpers;

namespace Star.Web.AutomatedUITests.Framework.Configuration
{
    public static class WebDriverFactory
    {
        private const string OsKey = "os";

        private const string OsVersionKey = "os_version";

        private const string BrowserKey = "browser";

        private const string BrowserVersionKey = "browser_version";

        private const string ResolutionKey = "resolution";

        private const string ProjectKey = "project";

        private const string BuildKey = "build";

        private const string NameKey = "name";

        private const string BrowserStackSeleniumVersionKey = "browserstack.selenium_version";

        private const string BrowserStackUserKey = "browserstack.user";

        private const string BrowserStackKeyKey = "browserstack.key";

        private const string AcceptUntrustedCertsKey = "acceptUntrustedCerts";

        private const string DeviceKey = "device";

        private const string RealMobileKey = "real_mobile";

        private const string OsWindowsValue = "Windows";

        private const string OsWindowsVersionValue = "10";

        private const string BrowserChromeValue = "Chrome";

        private const string BrowserFireFoxValue = "FireFox";

        private const string BrowserEdgeValue = "Edge";

        private const string BrowserVersionValue = "latest";

        private const string ResolutionValue = "1920x1080";

        private const string ProjectValue = "YourProjectName";

        private const string BrowserStackSeleniumVersionValue = "3.141.59";

        private const string OsMacValue = "OS X";

        private const string OsMacVersionValue = "Big Sur";

        private const string BrowserSafariValue = "Safari";

        private const string BrowserSafariVersionValue = "14.1";

        private const string OsiOSVersionValue = "14";

        private const string DeviceiOSVersion = "iPhone 12";

        private const string OsVersionAndroidValue = "10.0";

        private const string DeviceAndroidValue = "Samsung Galaxy S20";

        public static IWebDriver InitializeDriver(BrowserType browser, string testName = "")
        {
            if (ConfigurationProvider.IsRemoteDriverInUse())
                return GetRemoteWebDriver(browser, testName);

            switch (browser)
            {
                case BrowserType.Chrome: return new ChromeDriver(AssemblyHelper.GetCurrentAssemblyLocation(), GetChromeOptions(), TimeSpan.FromMinutes(10));
                case BrowserType.ChromeHeadless: return new ChromeDriver(AssemblyHelper.GetCurrentAssemblyLocation(), GetChromeHeadlessOptions(), TimeSpan.FromMinutes(10));
                case BrowserType.Firefox: return new FirefoxDriver(AssemblyHelper.GetCurrentAssemblyLocation(), GetFirefoxOptions());
                case BrowserType.SamsungGalaxyS20:
                case BrowserType.Safari:
                case BrowserType.Iphone12:
                case BrowserType.Edge:
                default:
                    throw new ArgumentException("Invalid browser type chosen");
            }
        }

        private static ChromeOptions GetChromeOptions()
        {
            var chromeOptions = new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            return chromeOptions;
        }

        private static ChromeOptions GetChromeHeadlessOptions()
        {
            var chromeOptions = new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            chromeOptions.AddArguments("--headless", "window-size=1920,1080", "--no-sandbox", "--disable-dev-shm-usage");
            return chromeOptions;
        }

        private static FirefoxOptions GetFirefoxOptions()
        {
            var firefoxOptions = new FirefoxOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            return firefoxOptions;
        }

        private static RemoteWebDriver GetRemoteWebDriver(BrowserType browser, string testName)
        {
            var commandExecutor = new HttpCommandExecutor(
                new Uri(ConfigurationProvider.GetConfiguration().WebDriverSettings.BrowserStackHubUrl),
                TimeSpan.FromSeconds(ConfigurationProvider.GetConfiguration().WebDriverSettings.WaitTimeout));

            switch (browser)
            {
                case BrowserType.Chrome:
                    var remoteChromeDriver = new RemoteWebDriver(commandExecutor, ConfigureRemoteChromeOption(testName));
                    return ConfigureRemoteDriver(remoteChromeDriver);

                case BrowserType.Firefox:
                    var remoteFirefoxDriver = new RemoteWebDriver(commandExecutor, ConfigureRemoteFirefoxOption(testName));
                    return ConfigureRemoteDriver(remoteFirefoxDriver);

                case BrowserType.Edge:
                    var remoteEdgeDriver = new RemoteWebDriver(commandExecutor, ConfigureRemoteEdgeOption(testName));
                    return ConfigureRemoteDriver(remoteEdgeDriver);

                case BrowserType.Safari:
                    var remoteSafariDriver = new RemoteWebDriver(commandExecutor, ConfigureRemoteSafariOption(testName));
                    return ConfigureRemoteDriver(remoteSafariDriver);

                case BrowserType.Iphone12:
                    var remoteIphoneDriver = new RemoteWebDriver(commandExecutor, ConfigureRemoteIphoneOption(testName));
                    return ConfigureRemoteDriver(remoteIphoneDriver);

                case BrowserType.SamsungGalaxyS20:
                    var remoteSamsungDriver = new RemoteWebDriver(commandExecutor, ConfigureRemoteSamsungGalaxyS20Option(testName));
                    return ConfigureRemoteDriver(remoteSamsungDriver);

                case BrowserType.ChromeHeadless:
                default:
                    throw new ArgumentException("Invalid browser type chosen");
            }
        }

        private static ICapabilities ConfigureRemoteChromeOption(string testName)
        {
            var options = new ChromeOptions();
            options.AddAdditionalOption(OsKey, OsWindowsValue);
            options.AddAdditionalOption(OsVersionKey, OsWindowsVersionValue);
            options.AddAdditionalOption(BrowserKey, BrowserChromeValue);
            options.AddAdditionalOption(BrowserVersionKey, BrowserVersionValue);
            options.AddAdditionalOption(ResolutionKey, ResolutionValue);
            SetCommonOptions(testName, options, "Chrome");
            return options.ToCapabilities();
        }

        private static ICapabilities ConfigureRemoteFirefoxOption(string testName)
        {
            var options = new FirefoxOptions();
            options.AddAdditionalOption(OsKey, OsWindowsValue);
            options.AddAdditionalOption(OsVersionKey, OsWindowsVersionValue);
            options.AddAdditionalOption(BrowserKey, BrowserFireFoxValue);
            options.AddAdditionalOption(BrowserVersionKey, BrowserVersionValue);
            options.AddAdditionalOption(ResolutionKey, ResolutionValue);
            SetCommonOptions(testName, options, "FireFox");
            options.SetPreference(AcceptUntrustedCertsKey, true);

            return options.ToCapabilities();
        }

        private static ICapabilities ConfigureRemoteEdgeOption(string testName)
        {
            var options = new EdgeOptions();
            options.AddAdditionalOption(OsKey, OsWindowsValue);
            options.AddAdditionalOption(OsVersionKey, OsWindowsVersionValue);
            options.AddAdditionalOption(BrowserKey, BrowserEdgeValue);
            options.AddAdditionalOption(BrowserVersionKey, BrowserVersionValue);
            options.AddAdditionalOption(ResolutionKey, ResolutionValue);
            SetCommonOptions(testName, options, "Edge");
            return options.ToCapabilities();
        }

        private static ICapabilities ConfigureRemoteSafariOption(string testName)
        {
            var options = new SafariOptions();
            options.AddAdditionalOption(OsKey, OsMacValue);
            options.AddAdditionalOption(OsVersionKey, OsMacVersionValue);
            options.AddAdditionalOption(BrowserKey, BrowserSafariValue);
            options.AddAdditionalOption(BrowserVersionKey, BrowserSafariVersionValue);
            options.AddAdditionalOption(ResolutionKey, ResolutionValue);
            SetCommonOptions(testName, options, "Safari");

            return options.ToCapabilities();
        }

        private static ICapabilities ConfigureRemoteIphoneOption(string testName)
        {
            var options = new SafariOptions();
            options.AddAdditionalOption(OsVersionKey, OsiOSVersionValue);
            options.AddAdditionalOption(DeviceKey, DeviceiOSVersion);
            options.AddAdditionalOption(RealMobileKey, "true");
            SetCommonOptions(testName, options, "iOS");

            return options.ToCapabilities();
        }

        private static ICapabilities ConfigureRemoteSamsungGalaxyS20Option(string testName)
        {
            var options = new ChromeOptions();
            options.AddAdditionalOption(OsVersionKey, OsVersionAndroidValue);
            options.AddAdditionalOption(DeviceKey, DeviceAndroidValue);
            options.AddAdditionalOption(RealMobileKey, "true");
            SetCommonOptions(testName, options, "Android");
            return options.ToCapabilities();
        }

        private static void SetCommonOptions(string testName, DriverOptions options, string deviceType)
        {
            options.AddAdditionalOption(ProjectKey, ProjectValue);
            options.AddAdditionalOption(BuildKey, $"{EnvironmentVariableProvider.GetEnvironment} Test Run - {deviceType}: {DateTime.Now:dd/MM/yyyy}");
            options.AddAdditionalOption(NameKey, testName);
            options.AddAdditionalOption(BrowserStackSeleniumVersionKey, BrowserStackSeleniumVersionValue);
            options.AddAdditionalOption(BrowserStackUserKey, EnvironmentVariableProvider.GetBrowserStackUser);
            options.AddAdditionalOption(BrowserStackKeyKey, EnvironmentVariableProvider.GetBrowserStackKey);
        }

        private static RemoteWebDriver ConfigureRemoteDriver(RemoteWebDriver driver)
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            return driver;
        }
    }
}