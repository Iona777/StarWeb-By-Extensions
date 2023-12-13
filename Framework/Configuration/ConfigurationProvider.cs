using System;

using Microsoft.Extensions.Configuration;

using Star.Web.AutomatedUITests.Framework.Configuration.Helpers;
using Star.Web.AutomatedUITests.Framework.Configuration.Sections;

namespace Star.Web.AutomatedUITests.Framework.Configuration
{
    public static class ConfigurationProvider
    {
        private static string RunningEnvironment => EnvironmentVariableProvider.GetEnvironment ?? "LOCAL";

        private static readonly Lazy<IConfiguration> LazyConfiguration = new(BuildConfiguration);

        public static TestConfiguration GetConfiguration()
        {
            var configuration = new TestConfiguration();
            LazyConfiguration.Value.GetSection(nameof(TestConfiguration)).Bind(configuration);
            return configuration;
        }

        public static bool IsRemoteDriverInUse()
        {
            return GetConfiguration().WebDriverSettings.IsRemote;
        }

        private static IConfiguration BuildConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();

            return configurationBuilder
                .AddJsonFile($"{AssemblyHelper.GetCurrentAssemblyLocation()}/appsettings.{RunningEnvironment}.json", true)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}