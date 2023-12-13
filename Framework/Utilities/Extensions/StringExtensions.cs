

namespace Star.Web.AutomatedUITests.Framework.Utilities.Extensions
{
    public static class StringExtensions
    {
        public static void GoToUrl(this string url)
        {
            Browser.GoToUrl(url);
        }
    }
}