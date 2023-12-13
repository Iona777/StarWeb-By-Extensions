using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Framework.Utilities.Extensions.ByExtensionsHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Star.Web.AutomatedUITests.ComponentHelper
{
    public class NotificationHelper
    {
        /// <summary>
        ///  Gets the text from a notification element
        /// </summary>
        /// <returns>string</returns>
        public static string GetNotificationText()
        {
            if (CommonPage.NotificationMessage.GetElementText(TimeSpan.FromSeconds(30)).Length == 0)
            {
                Thread.Sleep(500);
            }

            return CommonPage.NotificationMessage.GetElementText(TimeSpan.FromSeconds(30));
        }
    }
}
