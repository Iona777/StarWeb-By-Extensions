using OpenQA.Selenium;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class RulesPage
    {
        public static By PageHeader = By.CssSelector("h1.pageheader");

        public static By RulesSetViewNameDropdown = By.CssSelector("#uc-grid div[key='sddlViews']");

        public static By RulesSetGrid = By.CssSelector("#uc-grid table.grid");

        public static By RulesSetExportBtn = By.CssSelector("#uc-grid [key='exportBtn']");

        public static By RulesSetCustomGridView = By.CssSelector(".cv-container [key='btnEdit']");

        public static By FirstRulesSetRowID = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        public static By CreateRuleSetAccordion = By.CssSelector("[section='create']>h1");

        public static By CreateRuleName = By.CssSelector("#uc-create div[key='tbName']");

        public static By CreateRuleDescription = By.CssSelector("#uc-create div[key='taDescription']");

        public static By CreateRuleRank = By.CssSelector("#uc-create div[key='numerictbRank']");

        public static By CreateRuleUserGroups = By.CssSelector("#uc-create div[key='efUserGroupIds']");

        public static By CreateRuleRulesSetType = By.CssSelector("#uc-create div[key='sddlRuleSetType']");

        public static By CreateRuleCancelButton = By.CssSelector("#uc-create a[key='btnCancel']");

        public static By CreateRuleCreateButton = By.CssSelector("#uc-create a[key='btnSave']");

        public static By UserAccountEntityPicker = By.CssSelector("[key='btnadv']");

        public static By VisiblePopupHeader = By.CssSelector("div.popup-open .title");

        public static By VisiblePopupGrid = By.CssSelector("div.popup-open table.grid");

        public static By CreateRuleNameField = By.CssSelector("#uc-create div[key='tbName']>input[class='tb-box tb standard-input']");

        public static By CreateRuleDescriptionField = By.CssSelector("#uc-create div[key='taDescription']>textarea[class='ta-inner standard-input']");

        public static By CreateRuleRankField = By.CssSelector("#uc-create div[key='numerictbRank']>input[class='tb-box tb standard-input']");

        public static By Breadcrumb = By.CssSelector("#breadcrumb");

        public static By ViewRuleSetAccordion = By.CssSelector("[section='rulesetdetails']>h1");

        public static By CollapseAllButton = By.CssSelector(".expandcollapse-container a[key='btnCollapse']");

        public static By ViewRuleSetSection = By.CssSelector("[section='rulesetdetails']>h1");

        public static By ViewRuleSetEditBtn = By.CssSelector("[section='rulesetdetails']>h1");

        public static By ViewRuleSetDeleteBtn = By.CssSelector("[section='rulesetdetails']>h1");

        public static By CreateNewRuleSetVersionAccordion = By.CssSelector("[section='createversion']>h1");

        public static By CreateNewRuleSetVersionSection = By.CssSelector("#uc-createversion");

        public static By CreateNewRuleSetVersionCancelBtn = By.CssSelector("#uc-createversion [key='btnCancel']");

        public static By CreateNewRuleSetVersionCreateBtn = By.CssSelector("#uc-createversion [key='btnSave']");

        public static By RuleSetVersionAccordion = By.CssSelector("[section='rulesetversions']>h1");

        public static By RuleSetVersionViewNameDropdown = By.CssSelector("#uc-rulesetversions div[key='sddlViews']");

        public static By RuleSetVersionGrid = By.CssSelector("#uc-rulesetversions table.grid");

        public static By RuleSetVersionExportBtn = By.CssSelector("#uc-rulesetversions [key='exportBtn']");

        public static By RuleSetVersionCustomGridView = By.CssSelector(".cv-container [key='btnEdit']");

        public static By FirstRuleSetVersionRowID = By.CssSelector("#uc-rulesetversions .body-scroller >tr:first-of-type>td:first-of-type");

        public static By RuleSetVersionsAccordion = By.XPath("//span[text()='Rule Set Versions']");
    }
}