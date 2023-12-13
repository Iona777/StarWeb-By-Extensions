using System.IO;
using System.Reflection;

namespace Star.Web.AutomatedUITests.Framework.Configuration.Helpers
{
    public class AssemblyHelper
    {
        public static string GetCurrentAssemblyLocation()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
        }
    }
}