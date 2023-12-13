using Star.Web.AutomatedUITests.Framework.Configuration.Enums;

namespace Star.Web.AutomatedUITests.Framework.Configuration.Sections
{
    public class WebDriverSettings
    {
        public BrowserType BrowserType { get; set; }

        public bool IsRemote { get; set; }

        public int WaitTimeout { get; set; }

        public string BrowserStackHubUrl { get; set; }
    }
}