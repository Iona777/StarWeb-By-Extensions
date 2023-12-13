using OpenQA.Selenium;

using Star.Web.AutomatedUITests.Framework.Utilities.Extensions;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.Locators.Compliance;

namespace Star.Web.AutomatedUITests.ComponentHelper
{
    public class MenuHelper
    {
        public static void OpenSubMenu(string menuName, string subMenuName, bool isExpandedMenu = false)
        {
            var baseType = typeof(MenuPage);

            var fieldPrefix = isExpandedMenu
                ? "SubMenu"
                : "PopupMenu";

            var mainMenu = baseType.GetField($"Menu{menuName.Replace(" ", "")}").GetValue(baseType);
            var submenu = baseType.GetField($"{fieldPrefix}{subMenuName.Replace(" ", "")}").GetValue(baseType);

            if (mainMenu != null && submenu != null)
            {
                OpenSubMenu((By)mainMenu, (By)submenu);
            }
        }

        private static void OpenSubMenu(By mainMenu, By subMenu)
        {
            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();

            mainMenu.GetElementWithWait().Click();
            subMenu.GetElementWithWait().Click();

            CommonPage.LoadingOverlay.WaitUntilElementIsNotDisplayed();
        }
    }
}