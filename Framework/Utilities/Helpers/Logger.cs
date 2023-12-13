using Serilog;

namespace Star.Web.AutomatedUITests.Framework.Utilities.Helpers
{
    public static class Logger
    {
        private static readonly Serilog.Core.Logger logger;

        static Logger()
        {
            logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        }

        public static void LogErrorMessage(string message)
        {
            logger.Error($"ERROR MESSAGE - {message}");
        }

        public static void LogPlainText(string text)
        {
            logger.Information(text);
        }
    }
}