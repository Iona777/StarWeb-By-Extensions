using System;

namespace Star.Web.AutomatedUITests.Framework.Configuration
{
    public class EnvironmentVariableProvider
    {
        private const string EnvironmentVariableName = "ASPNETCORE_ENVIRONMENT";

        private const string BrowserStackUserVariableName = "BROWSERSTACK_USER";

        private const string BrowserStackKeyVariableName = "BROWSERSTACK_KEY";

        public static string? GetEnvironment => Environment.GetEnvironmentVariable(EnvironmentVariableName);

        public static string? GetBrowserStackUser => Environment.GetEnvironmentVariable(BrowserStackUserVariableName);

        public static string? GetBrowserStackKey => Environment.GetEnvironmentVariable(BrowserStackKeyVariableName);
    }
}