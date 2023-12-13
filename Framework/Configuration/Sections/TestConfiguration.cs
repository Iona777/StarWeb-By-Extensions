using System.Collections.Generic;
using System.Security.Policy;

namespace Star.Web.AutomatedUITests.Framework.Configuration.Sections
{
    public class TestConfiguration
    {
        public WebDriverSettings WebDriverSettings { get; set; }

        public List<Url> Urls { get; set; }

        public string BaseUrl { get; set; }
    }
}