using OpenQA.Selenium;

using Star.Web.AutomatedUITests.Constants;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    internal class MenuPage
    {
        // Review

        public static By MenuReview = By.CssSelector(".icon_review_24+h1");

        public static By SubMenuToReview = By.CssSelector(".childnodes li[section='Review']>h1");

        public static By SubMenuCases = By.CssSelector(".childnodes li[section='Case']>h1");

        public static By SubMenuOverrideReview = By.CssSelector(".childnodes li[section='OverrideReview']>h1");

        public static By SubMenuReviewLevels = By.CssSelector(".childnodes li[section='ReviewLevel']>h1");

        public static By SubMenuReviewDelegation = By.CssSelector(".childnodes li[section='ReviewDelegation']>h1");

        public static By PopupMenuToReview = By.CssSelector(".popoutmenu li[section='Review']>h1");

        public static By PopupMenuCases = By.CssSelector(".popoutmenu li[section='Case']>h1");

        public static By PopupMenuOverrideReview = By.CssSelector(".popoutmenu li[section='OverrideReview']>h1");

        public static By PopupMenuReviewLevels = By.CssSelector(".popoutmenu li[section='ReviewLevel']>h1");

        public static By PopupMenuReviewDelegation = By.CssSelector(".popoutmenu li[section='ReviewDelegation']>h1");

        // Employee

        public static By MenuEmployees = By.CssSelector(".icon_employees_24+h1");

        public static By SubMenuUserAccounts = By.CssSelector(".childnodes li[section='UserAccount']>h1");

        public static By SubMenuPersonalInformationManagement = By.CssSelector(".childnodes li[section='PersonalInformation']>h1");

        public static By SubMenuMyProfile = By.CssSelector(".childnodes li[section='UserDetails']>h1");

        public static By SubMenuUserGroups = By.CssSelector(".childnodes li[section='UserGroup']>h1");

        public static By SubMenuRelationships = By.CssSelector(".childnodes li[section='Relationship']>h1");

        public static By SubMenuRelationshipTypes = By.CssSelector(".childnodes li[section='RelationshipType']>h1");

        public static By SubMenuPermissions = By.CssSelector(".childnodes li[section='Permissions']>h1");

        public static By SubMenuRoleSets = By.CssSelector(".childnodes li[section='RoleSet']>h1");

        public static By SubMenuLineOfBusinessAndOffices = By.CssSelector(".childnodes li[section='LineofBusinessAndOffice']>h1");

        public static By SubMenuSystemBlockExemptions = By.CssSelector(".childnodes li[section='SystemBlockExemption']>h1");

        public static By PopupMenuUserAccounts = By.CssSelector(".popoutmenu li[section='UserAccount']>h1");

        public static By PopupMenuPersonalInformationManagement = By.CssSelector(".popoutmenu li[section='PersonalInformation']>h1");

        public static By PopupMenuMyProfile = By.CssSelector(".popoutmenu li[section='UserDetails']>h1");

        public static By PopupMenuUserGroups = By.CssSelector(".popoutmenu li[section='UserGroup']>h1");

        public static By PopupMenuRelationships = By.CssSelector(".popoutmenu li[section='Relationship']>h1");

        public static By PopupMenuRelationshipTypes = By.CssSelector(".popoutmenu li[section='RelationshipType']>h1");

        public static By PopupMenuPermissions = By.CssSelector(".popoutmenu li[section='Permissions']>h1");

        public static By PopupMenuRoleSets = By.CssSelector(".popoutmenu li[section='RoleSet']>h1");

        public static By PopupMenuLineOfBusinessAndOffices = By.CssSelector(".popoutmenu li[section='LineofBusinessAndOffice']>h1");

        public static By PopupMenuSystemBlockExemptions = By.CssSelector(".popoutmenu li[section='SystemBlockExemption']>h1");

        // Trading

        public static By MenuTrading = By.CssSelector(".icon_trading_24+h1");

        public static By SubMenuTradeRequests = By.CssSelector(".childnodes li[section='TradeRequest']>h1");

        public static By SubMenuOrders = By.CssSelector(".childnodes li[section='Order']>h1");

        public static By SubMenuTradeTransactions = By.CssSelector(".childnodes li[section='Transaction']>h1");

        public static By SubMenuHoldings = By.CssSelector(".childnodes li[section='Holding']>h1");

        public static By SubMenuMatching = By.CssSelector(".childnodes li[section='TransactionMatch']>h1");

        public static By SubMenuPortfolios = By.CssSelector(".childnodes li[section='Portfolio']>h1");

        public static By SubMenuTradeRequestProxies = By.CssSelector(".childnodes li[section='TradeRequestProxy']>h1");

        public static By SubMenuOrderProxies = By.CssSelector(".childnodes li[section='OrderProxy']>h1");

        public static By SubMenuTradingOptions = By.CssSelector(".childnodes li[section='TradingOptions']>h1");

        public static By PopupMenuTradeRequests = By.CssSelector(".popoutmenu li[section='TradeRequest']>h1");

        public static By PopupMenuOrders = By.CssSelector(".popoutmenu li[section='Order']>h1");

        public static By PopupMenuTradeTransactions = By.CssSelector(".popoutmenu li[section='Transaction']>h1");

        public static By PopupMenuHoldings = By.CssSelector(".popoutmenu li[section='Holding']>h1");

        public static By PopupMenuMatching = By.CssSelector(".popoutmenu li[section='TransactionMatch']>h1");

        public static By PopupMenuPortfolios = By.CssSelector(".popoutmenu li[section='Portfolio']>h1");

        public static By PopupMenuTradeRequestProxies = By.CssSelector(".popoutmenu li[section='TradeRequestProxy']>h1");

        public static By PopupMenuOrderProxies = By.CssSelector(".popoutmenu li[section='OrderProxy']>h1");

        public static By PopupMenuTradingOptions = By.CssSelector(".popoutmenu li[section='TradingOptions']>h1");

        // Conflict Search

        public static By MenuConflictSearch = By.CssSelector(".icon_conflictsearch_24+h1");

        public static By SubMenuConflictSearch = By.CssSelector(".childnodes li[section='ConflictSearch']>h1");

        public static By PopupMenuConflictSearch = By.CssSelector(".popoutmenu li[section='ConflictSearch']>h1");

        // Private Investment

        public static By MenuPrivateInvestment = By.CssSelector(".icon_admin_24+h1");

        public static By SubMenuPrivateInvestmentTransactions = By.CssSelector(".childnodes li[section='PrivateTransaction']>h1");

        public static By SubMenuInvestments = By.CssSelector(".childnodes li[section='PrivateInvestment']>h1");

        public static By SubMenuIssuers = By.CssSelector(".childnodes li[section='PrivateIssuer']>h1");

        public static By SubMenuPrivateInvestmentConfiguration = By.CssSelector(".childnodes li[section='PrivateInvestmentConfiguration']>h1");

        public static By SubMenuPrivateInvestmentProxies = By.CssSelector(".childnodes li[section='PrivateInvestmentProxy']>h1");

        public static By PopupMenuPrivateInvestmentTransactions = By.CssSelector(".popoutmenu li[section='PrivateTransaction']>h1");

        public static By PopupMenuInvestments = By.CssSelector(".popoutmenu li[section='PrivateInvestment']>h1");

        public static By PopupMenuIssuers = By.CssSelector(".popoutmenu li[section='PrivateIssuer']>h1");

        public static By PopupMenuPrivateInvestmentConfiguration = By.CssSelector(".popoutmenu li[section='PrivateInvestmentConfiguration']>h1");

        public static By PopupMenuPrivateInvestmentProxies = By.CssSelector(".popoutmenu li[section='PrivateInvestmentProxy']>h1");

        // Gifts And Entertainment

        public static By MenuGiftsAndEntertainment = By.CssSelector(".icon_gifts_24+h1");

        public static By SubMenuGifts = By.CssSelector(".childnodes li[section='Gift']>h1");

        public static By SubMenuEntertainment = By.CssSelector(".childnodes li[section='Entertainment']>h1");

        public static By SubMenuGiftProxies = By.CssSelector(".childnodes li[section='GiftProxy']>h1");

        public static By SubMenuEntertainmentProxies = By.CssSelector(".childnodes li[section='EntertainmentProxy']>h1");

        public static By SubMenuPurposes = By.CssSelector(".childnodes li[section='Purpose']>h1");

        public static By SubMenuTypes = By.CssSelector(".childnodes li[section='GiftAndEntertainmentType']>h1");

        public static By SubMenuGiftsAndEntertainmentConfiguration = By.CssSelector(".childnodes li[section='GiftsConfiguration']>h1");

        public static By SubMenuExpenseReconciliation = By.CssSelector(".childnodes li[section='ExpenseReconciliation']>h1");

        public static By SubMenuExpenseMappingConfiguration = By.CssSelector(".childnodes li[section='ExpenseMappingConfiguration']>h1");

        public static By PopupMenuGifts = By.CssSelector(".popoutmenu li[section='Gift']>h1");

        public static By PopupMenuEntertainment = By.CssSelector(".popoutmenu li[section='Entertainment']>h1");

        public static By PopupMenuGiftProxies = By.CssSelector(".popoutmenu li[section='GiftProxy']>h1");

        public static By PopupMenuEntertainmentProxies = By.CssSelector(".popoutmenu li[section='EntertainmentProxy']>h1");

        public static By PopupMenuPurposes = By.CssSelector(".popoutmenu li[section='Purpose']>h1");

        public static By PopupMenuTypes = By.CssSelector(".popoutmenu li[section='GiftAndEntertainmentType']>h1");

        public static By PopupMenuGiftsAndEntertainmentConfiguration = By.CssSelector(".popoutmenu li[section='GiftsConfiguration']>h1");

        public static By PopupMenuExpenseReconciliation = By.CssSelector(".popoutmenu li[section='ExpenseReconciliation']>h1");

        public static By PopupMenuExpenseMappingConfiguration = By.CssSelector(".popoutmenu li[section='ExpenseMappingConfiguration']>h1");

        // Political Activity

        public static By MenuPoliticalActivity = By.CssSelector(".icon_politicalactivity_24+h1");

        public static By SubMenuDeclarations = By.CssSelector(".childnodes li[section='PoliticalActivityDeclaration']>h1");

        public static By SubMenuPoliticalActivityConfiguration = By.CssSelector(".childnodes li[section='PoliticalActivityConfiguration']>h1");

        public static By SubMenuElections = By.CssSelector(".childnodes li[section='Election']>h1");

        public static By SubMenuBeneficiaries = By.CssSelector(".childnodes li[section='Beneficiary']>h1");

        public static By SubMenuJurisdictions = By.CssSelector(".childnodes li[section='Jurisdiction']>h1");

        public static By SubMenuProxies = By.CssSelector(".childnodes li[section='PoliticalActivityProxy']>h1");

        public static By SubMenuRestrictedEmployees = By.CssSelector(".childnodes li[section='RestrictedEmployee']>h1");

        public static By SubMenuReviewGroups = By.CssSelector(".childnodes li[section='ReviewGroup']>h1");

        public static By SubMenuDonationLimits = By.CssSelector(".childnodes li[section='DonationLimit']>h1");

        public static By SubMenuContributionSearch = By.CssSelector(".childnodes li[section='PoliticalActivityContribution']>h1");

        public static By PopupMenuDeclarations = By.CssSelector(".popoutmenu li[section='PoliticalActivityDeclaration']>h1");

        public static By PopupMenuPoliticalActivityConfiguration = By.CssSelector(".popoutmenu li[section='PoliticalActivityConfiguration']>h1");

        public static By PopupMenuElections = By.CssSelector(".popoutmenu li[section='Election']>h1");

        public static By PopupMenuBeneficiaries = By.CssSelector(".popoutmenu li[section='Beneficiary']>h1");

        public static By PopupMenuJurisdictions = By.CssSelector(".popoutmenu li[section='Jurisdiction']>h1");

        public static By PopupMenuProxies = By.CssSelector(".popoutmenu li[section='PoliticalActivityProxy']>h1");

        public static By PopupMenuRestrictedEmployees = By.CssSelector(".popoutmenu li[section='RestrictedEmployee']>h1");

        public static By PopupMenuReviewGroups = By.CssSelector(".popoutmenu li[section='ReviewGroup']>h1");

        public static By PopupMenuDonationLimits = By.CssSelector(".popoutmenu li[section='DonationLimit']>h1");

        public static By PopupMenuContributionSearch = By.CssSelector(".popoutmenu li[section='PoliticalActivityContribution']>h1");

        // Brokerage

        public static By MenuBrokerage = By.CssSelector(".icon_brokerage_24+h1");

        public static By SubMenuAccounts = By.CssSelector(".childnodes li[section='BrokerAccount']>h1");

        public static By SubMenuBrokerageFirms = By.CssSelector(".childnodes li[section='BrokerageFirm']>h1");

        public static By SubMenuReconciliation = By.CssSelector(".childnodes li[section='Reconciliation']>h1");

        public static By SubMenuAccountTypes = By.CssSelector(".childnodes li[section='BrokerAccountType']>h1");

        public static By SubMenuBrokerConfiguration = By.CssSelector(".childnodes li[section='BrokerAccountEventConfiguration']>h1");

        public static By SubMenuStatement = By.CssSelector(".childnodes li[section='Statement']>h1");

        public static By SubMenuFeedTracking = By.CssSelector(".childnodes li[section='BrokerFeedTracking']>h1");

        public static By SubMenuAccountTracking = By.CssSelector(".childnodes li[section='BrokerAccountTracking']>h1");

        public static By SubMenuBrokerConsent = By.CssSelector(".childnodes li[section='BrokerConsent']>h1");

        public static By SubMenuConsentConfiguration = By.CssSelector(".childnodes li[section='ConsentConfiguration']>h1");

        public static By SubMenuPersonalContact = By.CssSelector(".childnodes li[section='PersonalContact']>h1");

        public static By PopupMenuAccounts = By.CssSelector(".popoutmenu li[section='BrokerAccount']>h1");

        public static By PopupMenuBrokerageFirms = By.CssSelector(".popoutmenu li[section='BrokerageFirm']>h1");

        public static By PopupMenuReconciliation = By.CssSelector(".popoutmenu li[section='Reconciliation']>h1");

        public static By PopupMenuAccountTypes = By.CssSelector(".popoutmenu li[section='BrokerAccountType']>h1");

        public static By PopupMenuBrokerConfiguration = By.CssSelector(".popoutmenu li[section='BrokerAccountEventConfiguration']>h1");

        public static By PopupMenuStatement = By.CssSelector(".popoutmenu li[section='Statement']>h1");

        public static By PopupMenuFeedTracking = By.CssSelector(".popoutmenu li[section='BrokerFeedTracking']>h1");

        public static By PopupMenuAccountTracking = By.CssSelector(".popoutmenu li[section='BrokerAccountTracking']>h1");

        public static By PopupMenuBrokerConsent = By.CssSelector(".popoutmenu li[section='BrokerConsent']>h1");

        public static By PopupMenuConsentConfiguration = By.CssSelector(".popoutmenu li[section='ConsentConfiguration']>h1");

        public static By PopupMenuPersonalContact = By.CssSelector(".popoutmenu li[section='PersonalContact']>h1");

        // Lists

        public static By MenuLists = By.CssSelector(".icon_lists_24 + h1");

        public static By SubMenuBlackoutList = By.CssSelector(".childnodes li[section='BlackoutList'] > h1");

        public static By SubMenuOpenOrderList = By.CssSelector(".childnodes li[section='OpenOrderList'] > h1");

        public static By SubMenuRestrictedList = By.CssSelector(".childnodes li[section='RestrictedList'] > h1");

        public static By SubMenuProprietaryFundList = By.CssSelector(".childnodes li[section='ProprietaryFundList'] > h1");

        public static By SubMenuResearchList = By.CssSelector(".childnodes li[section='ResearchList'] > h1");

        public static By SubMenuLegalList = By.CssSelector(".childnodes li[section='LegalList'] > h1");

        public static By SubMenuWatchList = By.CssSelector(".childnodes li[section='WatchList'] > h1");

        public static By SubMenuCustomList = By.CssSelector(".childnodes li[section='CustomList'] > h1");

        public static By PopupMenuBlackoutList = By.CssSelector(".popoutmenu li[section='BlackoutList'] > h1");

        public static By PopupMenuOpenOrderList = By.CssSelector(".popoutmenu li[section='OpenOrderList'] > h1");

        public static By PopupMenuRestrictedList = By.CssSelector(".popoutmenu li[section='RestrictedList'] > h1");

        public static By PopupMenuProprietaryFundList = By.CssSelector(".popoutmenu li[section='ProprietaryFundList'] > h1");

        public static By PopupMenuResearchList = By.CssSelector(".popoutmenu li[section='ResearchList'] > h1");

        public static By PopupMenuLegalList = By.CssSelector(".popoutmenu li[section='LegalList'] > h1");

        public static By PopupMenuWatchList = By.CssSelector(".popoutmenu li[section='WatchList'] > h1");

        public static By PopupMenuCustomList = By.CssSelector(".popoutmenu li[section='CustomList'] > h1");

        // Insider Lists

        public static By MenuInsiderLists = By.CssSelector(".icon_insiderlists_24 + h1");

        public static By SubMenuInsiderLists = By.CssSelector(".childnodes li[section = 'InsiderLists'] > h1");

        public static By SubMenuInsiderListConfiguration = By.CssSelector(".childnodes li[section = 'InsiderListConfiguration'] > h1");

        public static By SubMenuInsiderListReporting = By.CssSelector(".childnodes li[section = 'InsiderListReporting'] > h1");

        public static By PopupMenuInsiderLists = By.CssSelector(".popoutmenu li[section = 'InsiderLists'] > h1");

        public static By PopupMenuInsiderListConfiguration = By.CssSelector(".popoutmenu li[section = 'InsiderListConfiguration'] > h1");

        public static By PopupMenuInsiderListReporting = By.CssSelector(".popoutmenu li[section = 'InsiderListReporting'] > h1");

        // Reference

        public static By MenuReference = By.CssSelector(".icon_reference_24 + h1");

        public static By SubMenuSecurities = By.CssSelector(".childnodes li[section='Security'] > h1");

        public static By SubMenuSecurityIssuers = By.CssSelector(".childnodes li[section='SecurityIssuer'] > h1");

        public static By SubMenuCompaniesAndContacts = By.CssSelector(".childnodes li[section='Company'] > h1");

        public static By SubMenuContactLists = By.CssSelector(".childnodes li[section='ContactList'] > h1");

        public static By SubMenuIndustries = By.CssSelector(".childnodes li[section='Industry'] > h1");

        public static By SubMenuSecurityTypes = By.CssSelector(".childnodes li[section='SecurityType'] > h1");

        public static By SubMenuMarkets = By.CssSelector(".childnodes li[section='Market'] > h1");

        public static By SubMenuCalendars = By.CssSelector(".childnodes li[section='Calendar'] > h1");

        public static By SubMenuCalendarEvents = By.CssSelector(".childnodes li[section='CalendarEvent'] > h1");

        public static By SubMenuTemplateStore = By.CssSelector(".childnodes li[section='TemplateStore'] > h1");

        public static By PopupMenuSecurities = By.CssSelector(".popoutmenu li[section='Security'] > h1");

        public static By PopupMenuSecurityIssuers = By.CssSelector(".popoutmenu li[section='SecurityIssuer'] > h1");

        public static By PopupMenuCompaniesAndContacts = By.CssSelector(".popoutmenu li[section='Company'] > h1");

        public static By PopupMenuContactLists = By.CssSelector(".popoutmenu li[section='ContactList'] > h1");

        public static By PopupMenuIndustries = By.CssSelector(".popoutmenu li[section='Industry'] > h1");

        public static By PopupMenuSecurityTypes = By.CssSelector(".popoutmenu li[section='SecurityType'] > h1");

        public static By PopupMenuMarkets = By.CssSelector(".popoutmenu li[section='Market'] > h1");

        public static By PopupMenuCalendars = By.CssSelector(".popoutmenu li[section='Calendar'] > h1");

        public static By PopupMenuCalendarEvents = By.CssSelector(".popoutmenu li[section='CalendarEvent'] > h1");

        public static By PopupMenuTemplateStore = By.CssSelector(".popoutmenu li[section='TemplateStore'] > h1");

        // Documents

        public static By MenuDocuments = By.CssSelector(".icon_documents_24+h1");

        public static By SubMenuDocumentRequests = By.CssSelector(".childnodes li[section='DocumentRequest'] > h1");

        public static By SubMenuDocumentManagement = By.CssSelector(".childnodes li[section='DocumentManagement'] > h1");

        public static By PopupMenuDocumentRequests = By.CssSelector(".popoutmenu li[section='DocumentRequest'] > h1");

        public static By PopupMenuDocumentManagement = By.CssSelector(".popoutmenu li[section='DocumentManagement'] > h1");

        // Reporting

        public static By MenuReporting = By.CssSelector(".icon_reporting_24 + h1");

        public static By SubMenuDataExport = By.CssSelector(".childnodes li[section='DataExport'] > h1");

        public static By SubmenuAPvsFirmReport = By.CssSelector(".childnodes li[section='APvsFirmReport'] > h1");

        public static By SubmenuChartDesigner = By.CssSelector(".childnodes li[section='ChartDesigner'] > h1");

        public static By SubmenuReportBuilder = By.CssSelector(".childnodes li[section='ReportBuilder'] > h1");

        public static By SubmenuReportsManager = By.CssSelector(".childnodes li[path*='/Reporting/Reports'] > h1");

        public static By SubmenuReportLibrary = By.CssSelector(".childnodes li[section='ReportLibrary'] > h1");

        public static By SubmenuSchedules = By.CssSelector(".childnodes li[section='ReportSchedule'] > h1");

        public static By SubmenuInsiderTradingEmployeeReport = By.CssSelector(".childnodes li[section='InsiderTradingEmployeeReport'] > h1");

        public static By SubmenuInsiderTradingFirmTradeReport = By.CssSelector(".childnodes li[section='InsiderTradingFirmTradeReport'] > h1");

        public static By SubmenuAnalyticGroupMappings = By.CssSelector($".childnodes li[path='/{PagePaths.AnalyticGroupMappings}'] > h1");

        public static By SubmenuAnalytics = By.CssSelector($".childnodes li[path='/{PagePaths.Analytics}'] > h1");

        public static By SubmenuExportConfiguration = By.CssSelector(".childnodes li[section='ExportConfiguration'] > h1");

        public static By SubmenuAdministration = By.CssSelector(".childnodes li[path='/Reporting/Administration'] > h1");

        public static By PopupMenuDataExport = By.CssSelector(".popoutmenu li[section='DataExport'] > h1");

        public static By PopupMenuAPvsFirmReport = By.CssSelector(".popoutmenu li[section='APvsFirmReport'] > h1");

        public static By PopupMenuChartDesigner = By.CssSelector(".popoutmenu li[section='ChartDesigner'] > h1");

        public static By PopupMenuReportBuilder = By.CssSelector(".popoutmenu li[section='ReportBuilder'] > h1");

        public static By PopupMenuReportsManager = By.CssSelector(".popoutmenu li[path*='/Reporting/Reports'] > h1");

        public static By PopupMenuReportLibrary = By.CssSelector(".popoutmenu li[section='ReportLibrary'] > h1");

        public static By PopupMenuSchedules = By.CssSelector(".popoutmenu li[section='ReportSchedule'] > h1");

        public static By PopupMenuInsiderTradingEmployeeReport = By.CssSelector(".popoutmenu li[section='InsiderTradingEmployeeReport'] > h1");

        public static By PopupMenuInsiderTradingFirmTradeReport = By.CssSelector(".popoutmenu li[section='InsiderTradingFirmTradeReport'] > h1");

        public static By PopupMenuAnalyticGroupMappings = By.CssSelector($".popoutmenu li[path='/{PagePaths.AnalyticGroupMappings}'] > h1");

        public static By PopupMenuAnalytics = By.CssSelector($".popoutmenu li[path='/{PagePaths.Analytics}'] > h1");

        public static By PopupMenuExportConfiguration = By.CssSelector(".popoutmenu li[section='ExportConfiguration'] > h1");

        public static By PopupMenuAdministration = By.CssSelector(".popoutmenu li[path='/Reporting/Administration'] > h1");

        // Administation

        public static By MenuAdministration = By.CssSelector(".icon_config_24+h1");

        public static By SubMenuDocumentConfiguration = By.CssSelector(".childnodes li[section='DocumentConfiguration']>h1");

        public static By SubMenuAlerts = By.CssSelector(".childnodes li[section='Alert']>h1");

        public static By SubMenuCustomViews = By.CssSelector(".childnodes li[section='CustomView']>h1");

        public static By SubMenuFileImports = By.CssSelector(".childnodes li[section='FileImport']>h1");

        public static By SubMenuHomePage = By.CssSelector(".childnodes li[section='HomePage']>h1");

        public static By SubMenuEmployeeMenuConfiguration = By.CssSelector(".childnodes li[section='EmployeeMenuConfiguration']>h1");

        public static By SubMenuHelp = By.CssSelector(".childnodes li[section='Help']>h1");

        public static By SubMenuSystemScriptManagement = By.CssSelector(".childnodes li[section='Script']>h1");

        public static By SubMenuSystemConfiguration = By.CssSelector(".childnodes li[path*='Administration/Admin']>h1");

        public static By SubMenuListManagement = By.CssSelector(".childnodes li[section='ListManagement']>h1");

        public static By SubMenuArchiving = By.CssSelector(".childnodes li[path='/Administration/Archive']>h1");

        public static By SubMenuSystemLanguages = By.CssSelector(".childnodes li[path*='/SystemLanguages']>h1");

        public static By SubMenuAuditLog = By.CssSelector(".childnodes li[path*='AuditLog']>h1");

        public static By SubMenuConnectionStringManagement = By.CssSelector(".childnodes li[section='ConnectionStringManagement']>h1");

        public static By SubMenuCustomAlerts = By.CssSelector(".childnodes li[section='CustomAlert']>h1");

        public static By SubMenuCustomAlertViews = By.CssSelector(".childnodes li[section='CustomAlertRecipientManagement']>h1");

        public static By SubMenuApiCustomViews = By.CssSelector(".childnodes li[section='ApiCustomView']>h1");

        public static By SubMenuQuickLinks = By.CssSelector(".childnodes li[path*='QuickLinks']>h1");

        public static By SubMenuCredentialManagement = By.CssSelector(".childnodes li[section='CredentialManagement']>h1");

        public static By SubMenuApplicationLinks = By.CssSelector(".childnodes li[section='ApplicationLinks']>h1");

        public static By PopupMenuDocumentConfiguration = By.CssSelector(".popoutmenu li[section='DocumentConfiguration']>h1");

        public static By PopupMenuAlerts = By.CssSelector(".popoutmenu li[section='Alert']>h1");

        public static By PopupMenuCustomViews = By.CssSelector(".popoutmenu li[section='CustomView']>h1");

        public static By PopupMenuFileImports = By.CssSelector(".popoutmenu li[section='FileImport']>h1");

        public static By PopupMenuHomePage = By.CssSelector(".popoutmenu li[section='HomePage']>h1");

        public static By PopupMenuEmployeeMenuConfiguration = By.CssSelector(".popoutmenu li[section='EmployeeMenuConfiguration']>h1");

        public static By PopupMenuHelp = By.CssSelector(".popoutmenu li[section='Help']>h1");

        public static By PopupMenuSystemScriptManagement = By.CssSelector(".popoutmenu li[section='Script']>h1");

        public static By PopupMenuSystemConfiguration = By.CssSelector(".popoutmenu li[path*='Administration/Admin']>h1");

        public static By PopupMenuListManagement = By.CssSelector(".popoutmenu li[section='ListManagement']>h1");

        public static By PopupMenuArchiving = By.CssSelector(".popoutmenu li[path='/Administration/Archive']>h1");

        public static By PopupMenuSystemLanguages = By.CssSelector(".popoutmenu li[path*='/SystemLanguages']>h1");

        public static By PopupMenuAuditLog = By.CssSelector(".popoutmenu li[path*='AuditLog']>h1");

        public static By PopupMenuConnectionStringManagement = By.CssSelector(".popoutmenu li[section='ConnectionStringManagement']>h1");

        public static By PopupMenuCustomAlerts = By.CssSelector(".popoutmenu li[section='CustomAlert']>h1");

        public static By PopupMenuCustomAlertViews = By.CssSelector(".popoutmenu li[section='CustomAlertRecipientManagement']>h1");

        public static By PopupMenuApiCustomViews = By.CssSelector(".popoutmenu li[section='ApiCustomView']>h1");

        public static By PopupMenuQuickLinks = By.CssSelector(".popoutmenu li[path*='QuickLinks']>h1");

        public static By PopupMenuCredentialManagement = By.CssSelector(".popoutmenu li[section='CredentialManagement']>h1");

        public static By PopupMenuApplicationLinks = By.CssSelector(".popoutmenu li[section='ApplicationLinks']>h1");

        // Rules

        public static By MenuRules = By.CssSelector(".icon_rules_24+h1");

        public static By SubMenuRuleSets = By.CssSelector(".childnodes li[section='RuleSet']>h1");

        public static By SubMenuSurveillanceDefinitions = By.CssSelector(".childnodes li[section='SurveillanceDefinition']>h1");

        public static By SubMenuSurveillanceRuns = By.CssSelector(".childnodes li[section='SurveillanceRun']>h1");

        public static By SubMenuCaseStatusDetails = By.CssSelector(".childnodes li[section='CaseStatusDetail']>h1");

        public static By SubMenuRuleSetResults = By.CssSelector(".childnodes li[section='RuleSetResult']>h1");

        public static By SubMenuReporting = By.CssSelector(".childnodes li[section='RuleSetReporting']>h1");

        public static By PopupMenuRuleSets = By.CssSelector(".popoutmenu li[section='RuleSet']>h1");

        public static By PopupMenuSurveillanceDefinitions = By.CssSelector(".popoutmenu li[section='SurveillanceDefinition']>h1");

        public static By PopupMenuSurveillanceRuns = By.CssSelector(".popoutmenu li[section='SurveillanceRun']>h1");

        public static By PopupMenuCaseStatusDetails = By.CssSelector(".popoutmenu li[section='CaseStatusDetail']>h1");

        public static By PopupMenuRuleSetResults = By.CssSelector(".popoutmenu li[section='RuleSetResult']>h1");

        public static By PopupMenuReporting = By.CssSelector(".popoutmenu li[section='RuleSetReporting']>h1");

        // Compliance Forms

        public static By MenuComplianceForms = By.CssSelector(".icon_complianceforms_24+h1");

        public static By SubMenuInbox = By.CssSelector(".childnodes li[section='Inbox']>h1");

        public static By SubMenuSubmitComplianceForm = By.CssSelector(".childnodes li[section='BusinessProcessSubmission']>h1");

        public static By SubMenuDocuments = By.CssSelector(".childnodes li[section='DocumentAdministration']>h1");

        public static By SubMenuBusinessProcessAdministration = By.CssSelector(".childnodes li[section='BusinessProcessAdministration']>h1");

        public static By SubMenuBusinessProcessWizard = By.CssSelector(".childnodes li[section='BusinessProcessWizard']>h1");

        public static By SubMenuFolderManagement = By.CssSelector(".childnodes li[section='BusinessProcessFolderManagement']>h1");

        public static By SubMenuComplianceDocumentRequests = By.CssSelector(".childnodes li[section='ComplianceDocumentRequests']>h1");

        public static By SubMenuGlobalFormSections = By.CssSelector(".childnodes li[section='GlobalFormSections']>h1");

        public static By SubMenuProxyManagement = By.CssSelector(".childnodes li[section='ProxyManagement']>h1");

        public static By SubMenuPersonaManagement = By.CssSelector(".childnodes li[section='PersonaManagement']>h1");

        public static By PopupMenuInbox = By.CssSelector(".popoutmenu li[section='Inbox']>h1");

        public static By PopupMenuSubmitComplianceForm = By.CssSelector(".popoutmenu li[section='BusinessProcessSubmission']>h1");

        public static By PopupMenuDocuments = By.CssSelector(".popoutmenu li[section='DocumentAdministration']>h1");

        public static By PopupMenuBusinessProcessAdministration = By.CssSelector(".popoutmenu li[section='BusinessProcessAdministration']>h1");

        public static By PopupMenuBusinessProcessWizard = By.CssSelector(".popoutmenu li[section='BusinessProcessWizard']>h1");

        public static By PopupMenuFolderManagement = By.CssSelector(".popoutmenu li[section='BusinessProcessFolderManagement']>h1");

        public static By PopupMenuComplianceDocumentRequests = By.CssSelector(".popoutmenu li[section='ComplianceDocumentRequests']>h1");

        public static By PopupMenuGlobalFormSections = By.CssSelector(".popoutmenu li[section='GlobalFormSections']>h1");

        public static By PopupMenuProxyManagement = By.CssSelector(".popoutmenu li[section='ProxyManagement']>h1");

        public static By PopupMenuPersonaManagement = By.CssSelector(".popoutmenu li[section='PersonaManagement']>h1");

        // DRAD

        public static By MenuDRAD = By.CssSelector(".icon_drad_24+h1");

        public static By SubMenuPolicyConfiguration = By.CssSelector(".childnodes li[section='DradConfiguration']>h1");

        public static By SubMenuBatches = By.CssSelector(".childnodes li[section='DradBatch']>h1");

        public static By SubMenuUserPolicyManagement = By.CssSelector(".childnodes li[section='UserDradPolicyManagement']>h1");

        public static By SubMenuArchive = By.CssSelector(".childnodes li[section='DradArchive']>h1");

        public static By SubMenuExclusions = By.CssSelector(".childnodes li[section='DradExclusion']>h1");

        public static By SubMenuSubjects = By.CssSelector(".childnodes li[section='DradSubject']>h1");

        public static By SubMenuDradAdministration = By.CssSelector(".childnodes li[section='DradService']>h1");

        public static By PopupMenuPolicyConfiguration = By.CssSelector(".popoutmenu li[section='DradConfiguration']>h1");

        public static By PopupMenuBatches = By.CssSelector(".popoutmenu li[section='DradBatch']>h1");

        public static By PopupMenuUserPolicyManagement = By.CssSelector(".popoutmenu li[section='UserDradPolicyManagement']>h1");

        public static By PopupMenuArchive = By.CssSelector(".popoutmenu li[section='DradArchive']>h1");

        public static By PopupMenuExclusions = By.CssSelector(".popoutmenu li[section='DradExclusion']>h1");

        public static By PopupMenuSubjects = By.CssSelector(".popoutmenu li[section='DradSubject']>h1");

        public static By PopupMenuDradAdministration = By.CssSelector(".popoutmenu li[section='DradService']>h1");

        // Mobile

        public static By MenuMobile = By.CssSelector(".icon_mobile_24+h1");

        public static By SubMenuUserAccess = By.CssSelector($".childnodes li[path='/{PagePaths.UserAccess}']>h1");

        public static By SubMenuConfiguration = By.CssSelector(".childnodes li[path='/Mobile/Configuration']>h1");

        public static By SubMenuDeviceManagement = By.CssSelector($".childnodes li[path='/{PagePaths.DeviceManagement}']>h1");

        public static By PopupMenuUserAccess = By.CssSelector($".popoutmenu li[path='/{PagePaths.UserAccess}']>h1");

        public static By PopupMenuConfiguration = By.CssSelector(".popoutmenu li[path='/Mobile/Configuration']>h1");

        public static By PopupMenuDeviceManagement = By.CssSelector($".popoutmenu li[path='/{PagePaths.DeviceManagement}']>h1");

        // Data Entry

        public static By MenuDataEntry = By.CssSelector(".icon_dataentry_24+h1");

        public static By SubMenuBrokerAccounts = By.CssSelector(".childnodes li[section='DataEntryBrokerAccount']>h1");

        public static By SubMenuDataEntryTradeRequests = By.CssSelector(".childnodes li[section='DataEntryTradeRequest']>h1");

        public static By SubMenuTransactions = By.CssSelector(".childnodes li[section='DataEntryTransaction']>h1");

        public static By SubMenuDataEntryHoldings = By.CssSelector(".childnodes li[section='DataEntryHolding']>h1");

        public static By SubMenuStatements = By.CssSelector(".childnodes li[section='DataEntryStatement']>h1");

        public static By SubMenuDataEntryOrders = By.CssSelector(".childnodes li[section='DataEntryOrder']>h1");

        public static By PopupMenuBrokerAccounts = By.CssSelector(".popoutmenu li[section='DataEntryBrokerAccount']>h1");

        public static By PopupMenuDataEntryTradeRequests = By.CssSelector(".popoutmenu li[section='DataEntryTradeRequest']>h1");

        public static By PopupMenuTransactions = By.CssSelector(".popoutmenu li[section='DataEntryTransaction']>h1");

        public static By PopupMenuDataEntryHoldings = By.CssSelector(".popoutmenu li[section='DataEntryHolding']>h1");

        public static By PopupMenuStatements = By.CssSelector(".popoutmenu li[section='DataEntryStatement']>h1");

        public static By PopupMenuDataEntryOrders = By.CssSelector(".popoutmenu li[section='DataEntryOrder']>h1");
    }
}