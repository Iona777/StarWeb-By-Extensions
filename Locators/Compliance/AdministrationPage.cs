using OpenQA.Selenium;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class AdministrationPage
    {
        //General Page Components
        public static readonly By PageHeader = By.CssSelector("h1.pageheader");

        public static readonly By Breadcrumb = By.CssSelector("#breadcrumb");

        public static readonly By VisiblePopupHeader = By.CssSelector("div.popup-open .title");

        public static readonly By VisiblePopupGrid = By.CssSelector("div.popup-open table.grid");

        //Grid Components
        public static readonly By ViewNamesDropDown = By.CssSelector("div[key='sddlViews']");

        public static readonly By Grid = By.CssSelector("table.grid");

        public static readonly By ExportBtn = By.CssSelector("[key='exportBtn']");

        public static readonly By CreateCustomGridView = By.CssSelector(".cv-container [key='btnEdit']");

        public static readonly By FirstGridRow = By.CssSelector(".body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By FirstGridRowPlusSign = By.CssSelector(".body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By FirstGridRowPlusDetails = By.CssSelector(".form-fields");

        public static readonly By GridHeader = By.CssSelector(".cv-grid .grid-columns");

        public static readonly By CommonDetailsAccordion = By.CssSelector("li[section='details']>h1");

        public static readonly By CommonDetailsSection = By.CssSelector("#uc-details");

        public static readonly By CommonDetailsSectionEditbtn = By.CssSelector("[key='btnEdit']");

        public static readonly By CommonDetailsSectionDeletebtn = By.CssSelector("[key='btnDelete']");

        public static readonly By CommonPreviewAccordion = By.CssSelector("li[section='preview']>h1");

        public static readonly By CommonPreviewSection = By.CssSelector("#uc-preview");

        public static readonly By CommonPreviewSignatureTextField = By.CssSelector("[key='electronicsignatureElectronicSignature']");

        public static readonly By CommonPreviewExportBtn = By.CssSelector("[action='export']");

        //Document Configuration - Create Document Components
        public static readonly By CreateDocumentDescriptorAccordion = By.CssSelector("li[section='create']>h1");

        public static readonly By CreateDocumentContainer = By.CssSelector("#uc-create");

        public static readonly By CreateDocumentCancelButton = By.CssSelector("#uc-create a[key='btnCancel']");

        public static readonly By CreateDocumentCreateButton = By.CssSelector("#uc-create a[key='btnSave']");

        public static readonly By DocumentDescriptionInputField = By.CssSelector("ul.form-fields div[key='tbName']>input.tb.standard-input");

        public static readonly By DocumentDescriptionTextField = By.CssSelector("ul.form-fields div[key='taDescription']>textarea");

        public static readonly By DocumentTypeDropDown = By.CssSelector("ul.form-fields div[key='sddlDocumentTypeId']");

        //Document Configuration - Document Descriptor Details
        public static readonly By DocumentDescriptorDetailsAccordion = By.CssSelector("li[section='configurationdetails']>h1");

        public static readonly By DocumentDescriptorDetailsSection = By.CssSelector("#uc-configurationdetails");

        public static readonly By DocumentDescriptorDetailsTranslateBtn = By.CssSelector("[key='btnTranslate']");

        public static readonly By DocumentDescriptorDetailsEditBtn = By.CssSelector("[key='btnEdit']");

        public static readonly By CreateDocumentSetAccordion = By.CssSelector("li[section='createset']>h1");

        public static readonly By CreateDocumentSetTextArea = By.CssSelector("#uc-createset .form-field");

        public static readonly By CreateDocumentSetCancelBtn = By.CssSelector("#uc-createset [key='btnCancel']");

        public static readonly By CreateDocumentSetCreateBtn = By.CssSelector("#uc-createset [key='btnSave']");

        public static readonly By DocumentSetsAccordion = By.CssSelector("li[section='documentsets']>h1");

        public static readonly By DocumentSetsSection = By.CssSelector("#uc-documentsets");

        //Document Set Details
        public static readonly By PreClearanceTradeFormAccordion = By.CssSelector("li[section='documentsetdetails']>h1");

        public static readonly By PreClearanceTradeFormSection = By.CssSelector("#uc-documentsetdetails");

        public static readonly By PreClearanceTradeFormCloneBtn = By.CssSelector("#uc-documentsetdetails [action='clone']");

        public static readonly By DocumentConfigurationsAccordion = By.CssSelector("li[section='documentsetconfigurations']>h1");

        //Document Configuration Details
        public static readonly By UpdateDocumentSetConfigurationAccordion = By.CssSelector("li[section='configdetails']>h1");

        public static readonly By UpdateDocumentSetConfigurationSection = By.CssSelector("#uc-configdetails");

        public static readonly By PreviewUserDefinedFormAccordion = By.CssSelector("li[section='preview']>h1");

        public static readonly By PreviewUserDefinedFormSection = By.CssSelector("#uc-preview");

        public static readonly By PreviewUserDefinedFormSignatureTextField = By.CssSelector("[key='electronicsignatureElectronicSignature']");

        public static readonly By PreviewUserDefinedFormExportBtn = By.CssSelector("[action='export']");

        //Alerts Components
        public static readonly By AlertConfigurationAccordion = By.CssSelector("li[section='alertworkflow']>h1");

        public static readonly By AlertSectionsDropDown = By.CssSelector("div[key='sddl-sections']");

        public static readonly By AlertWorkFlowSection = By.CssSelector("#uc-alertworkflow");

        public static readonly By EmailAlertQueueAccordion = By.CssSelector("li[section='alertqueue']>h1");

        public static readonly By EmailAlertViewDropDown = By.CssSelector("#uc-alertqueue div[key='sddlViews']");

        public static readonly By EmailAlertGrid = By.CssSelector("#uc-alertqueue div.cv-grid");

        public static readonly By EmailAlertExportBtn = By.CssSelector("#uc-alertqueue [key='exportBtn']");

        public static readonly By EmailAlertCustomGridView = By.CssSelector("#uc-alertqueue .cv-container [key='btnEdit']");

        public static readonly By EmailAlertFirstGridRowID = By.CssSelector("#uc-alertqueue .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By EmailAlertReleaseSelectedAlertsButton = By.CssSelector(".action-buttons [action='releasealerts']");

        public static readonly By EmailAlertDeleteSelectedAlertsButton = By.CssSelector(".action-buttons [action='deletealerts']");

        public static readonly By PushNotificationAlertQueueAccordion = By.CssSelector("li[section='pushalertqueue']>h1");

        public static readonly By PushNotificationViewDropDown = By.CssSelector("#uc-pushalertqueue [title='Select Grid View']");

        public static readonly By PushNotificationGrid = By.CssSelector("#uc-pushalertqueue div.cv-grid");

        public static readonly By PushNotificationExportBtn = By.CssSelector("#uc-pushalertqueue [key='exportBtn']");

        public static readonly By PushNotificationCustomGridView = By.CssSelector("#uc-pushalertqueue .cv-container [key='btnEdit']");

        public static readonly By PushNotificationFirstGridRowID = By.CssSelector("#uc-pushalertqueue .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By PushNotificationReleaseSelectedAlertsButton = By.CssSelector(".action-buttons [action='releasepushalert']");

        public static readonly By PushNotificationDeleteSelectedAlertsButton = By.CssSelector(".action-buttons [action='deletepushalert']");

        //Custom View - Custom View Details
        public static readonly By DetailsAccordion = By.CssSelector("li[section='customviewtypedetails']>h1");

        public static readonly By DetailsSection = By.CssSelector("#uc-customviewtypedetails");

        public static readonly By DetailsTemplateName = By.CssSelector("[key='rotName']");

        public static readonly By DetailsCancelBtn = By.CssSelector("#uc-customviewtypedetails [key='btnCancel']");

        public static readonly By DetailsSaveBtn = By.CssSelector("#uc-customviewtypedetails [key='btnSave']");

        public static readonly By ViewsAccordion = By.CssSelector("li[section='customviewsgrid']>h1");

        public static readonly By ViewsViewNamesDropDown = By.CssSelector("#uc-customviewsgrid div[key='sddlViews']");

        public static readonly By ViewsGrid = By.CssSelector("#uc-customviewsgrid  table.grid");

        public static readonly By ViewsExportBtn = By.CssSelector("#uc-customviewsgrid [key='exportBtn']");

        public static readonly By ViewsCustomGridView = By.CssSelector("#uc-customviewsgrid .cv-container [key='btnEdit']");

        public static readonly By ViewsFirstGridRowID = By.CssSelector("#uc-customviewsgrid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By ViewsGridHeader = By.CssSelector("#uc-customviewsgrid .cv-grid .grid-columns");

        public static readonly By CreateViewAccordion = By.CssSelector("li[section='create']>h1");

        public static readonly By CreateViewNameTextBox = By.CssSelector("#uc-create [key='txtViewName']");

        public static readonly By CreateViewNameCancelBtn = By.CssSelector("#uc-create [key='btnCancel']");

        public static readonly By CreateViewNameCreateNewBtn = By.CssSelector("#uc-create [key='btnSaveAs']");

        public static readonly By DefaultViewRankAccordion = By.CssSelector("li[section='rank']>h1");

        public static readonly By DefaultViewRankSection = By.CssSelector("#uc-rank");

        public static readonly By DefaultViewRankEditBtn = By.CssSelector("#uc-rank [key='btnEdit']");

        // view Details page is throwing error ***************

        //File Import Components
        public static readonly By ImportFileAccordion = By.CssSelector("li[section='importfile']>h1>div");

        public static readonly By ImportFileBrowseBtn = By.CssSelector(".browse");

        public static readonly By ImportFileFileTypeDropDown = By.CssSelector("[key='sddlFileType']");

        public static readonly By ImportFileCancelBtn = By.CssSelector("#uc-importfile [key='btnCancel']");

        public static readonly By ImportFileUploadBtn = By.CssSelector("#uc-importfile [key='btnSave']");

        public static readonly By FileImportsAccordion = By.CssSelector("li[section='fileimports']>h1");

        public static readonly By FileImportsViewDropDown = By.CssSelector("#uc-fileimports div[key='sddlViews']");

        public static readonly By FileImportsGrid = By.CssSelector("#uc-fileimports table.grid");

        public static readonly By FileImportsExportBtn = By.CssSelector("#uc-fileimports [key='exportBtn']");

        public static readonly By FileImportsCustomGridView = By.CssSelector("#uc-fileimports .cv-container [key='btnEdit']");

        public static readonly By FileImportsFirstGridRowID = By.CssSelector("#uc-fileimports .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By FileImportsGridHeader = By.CssSelector("#uc-fileimports .cv-grid .grid-columns");

        public static readonly By FileImportConfigurationAccordion = By.CssSelector("li[section='grid']>h1");

        public static readonly By FileImportConfigurationViewDropDown = By.CssSelector("#uc-grid div[key='sddlViews']");

        public static readonly By FileImportConfigurationGrid = By.CssSelector("#uc-grid table.grid");

        public static readonly By FileImportConfigurationExportBtn = By.CssSelector("#uc-grid [key='exportBtn']");

        public static readonly By FileImportConfigurationCustomGridView = By.CssSelector("#uc-grid .cv-container [key='btnEdit']");

        public static readonly By FileImportConfigurationFirstGridRowID = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By FileImportConfigurationGridHeader = By.CssSelector("#uc-grid .cv-grid .grid-columns");

        //File Import Details

        public static readonly By FileImportDetailsAccordion = By.CssSelector("li[section='details']>h1");

        public static readonly By FileImportDetailsSection = By.CssSelector("#uc-details");

        public static readonly By FailedRowsAccordion = By.CssSelector("li[section='failedrows']>h1");

        public static readonly By FailedRowsSection = By.CssSelector("#uc-failedrows");

        public static readonly By FailedRowsExportBtn = By.CssSelector("#uc-failedrows [key='exportBtn']");

        public static readonly By FailedRowsFirstGridRowID = By.CssSelector("#uc-failedrows .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By SystemLogAccordion = By.CssSelector("li[section='systemlog']>h1");

        public static readonly By SystemLogSection = By.CssSelector("#uc-systemlog");

        public static readonly By SystemLogExportBtn = By.CssSelector("#uc-systemlog [key='exportBtn']");

        public static readonly By SystemLogFirstGridRowID = By.CssSelector("#uc-systemlog .body-scroller >tr:first-of-type>td:first-of-type");

        //File Import Configuration Details
        public static readonly By FileImportConfigurationFileImportDetailsAccordion = By.CssSelector("li[section='details']>h1");

        public static readonly By FileImportConfigurationFileImportDetailsSection = By.CssSelector("#uc-details");

        public static readonly By FileImportConfigurationFileImportViewFileSpecBtn = By.CssSelector("[action='viewfilespec']");

        public static readonly By FileImportConfigurationFileImportEditBtn = By.CssSelector("[key='btnEdit']");

        public static readonly By CreateLookupForImportAccordion = By.CssSelector("li[section='createlookup']>h1");

        public static readonly By CreateLookupForImportLookupField = By.CssSelector("#uc-createlookup [key='tbField']");

        public static readonly By CreateLookupForImportInputColumn = By.CssSelector("#uc-createlookup [key='tbInput']");

        public static readonly By CreateLookupForImportOutputColumn = By.CssSelector("#uc-createlookup [key='tbOutput']");

        public static readonly By CreateLookupForImportCancelBtn = By.CssSelector("#uc-createlookup [key='btnCancel']");

        public static readonly By CreateLookupForImportSaveBtn = By.CssSelector("#uc-createlookup [key='btnSave']");

        public static readonly By LookupsAccordion = By.CssSelector("li[section='lookupsgrid']>h1");

        public static readonly By LookupsExportBtn = By.CssSelector("#uc-lookupsgrid [key='exportBtn']");

        public static readonly By LookupsViewDropDown = By.CssSelector("#uc-lookupsgrid div[key='sddlViews']");

        public static readonly By LookupsCustomGridView = By.CssSelector("#uc-lookupsgrid .cv-container [key='btnEdit']");

        public static readonly By LookupsGrid = By.CssSelector("#uc-lookupsgrid table.grid");

        public static readonly By LookupsFirstGridRowPlusSign = By.CssSelector("#uc-lookupsgrid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By LookupsFirstGridRowDetails = By.CssSelector("#uc-lookupsgrid .form-fields");

        public static readonly By LookupsFirstGridRowEditBtn = By.CssSelector("#uc-lookupsgrid .form-btnssection  [key='btnEdit']");

        public static readonly By LookupsFirstGridRowDeleteBtn = By.CssSelector("#uc-lookupsgrid .form-btnssection  [key='btnDelete']");

        //Create Custom Column
        public static readonly By CreateCustomColumnAccordion = By.CssSelector("li[section='createcustomcolumn']>h1");

        public static readonly By CreateCustomColumnNameTextBox = By.CssSelector("#uc-createcustomcolumn [key='tbName']");

        public static readonly By CreateCustomColumnValueTextBox = By.CssSelector("#uc-createcustomcolumn [key='tbValue']");

        public static readonly By CreateCustomColumnCancelBtn = By.CssSelector("#uc-createcustomcolumn [key='btnCancel']");

        public static readonly By CreateCustomColumnSaveBtn = By.CssSelector("#uc-createcustomcolumn [key='btnSave']");

        public static readonly By CustomColumnAccordion = By.CssSelector("li[section='customcolumnsgrid']>h1");

        public static readonly By CustomColumnExportBtn = By.CssSelector("#uc-customcolumnsgrid [key='exportBtn']");

        public static readonly By CustomColumnFirstGridRowID = By.CssSelector("#uc-customcolumnsgrid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By CustomColumnViewDropDown = By.CssSelector("#uc-customcolumnsgrid div[key='sddlViews']");

        public static readonly By CustomColumnCustomGridView = By.CssSelector("#uc-customcolumnsgrid .cv-container [key='btnEdit']");

        public static readonly By CustomColumnGrid = By.CssSelector("#uc-customcolumnsgrid table.grid");

        public static readonly By CustomColumnFirstGridRowPlusSign = By.CssSelector("#uc-customcolumnsgrid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By CustomColumnFirstGridRowDetails = By.CssSelector("#uc-customcolumnsgrid .form-fields");

        public static readonly By CustomColumnFirstGridRowEditBtn = By.CssSelector("#uc-customcolumnsgrid .form-btnssection  [key='btnEdit']");

        public static readonly By CustomColumnFirstGridRowDeleteBtn = By.CssSelector("#uc-customcolumnsgrid .form-btnssection  [key='btnDelete']");

        public static readonly By ConfigureFileProcessedEmailAlertsAccordion = By.CssSelector("li[section='editfileprocessedemailalerts']>h1");

        public static readonly By ConfigureFileProcessedEmailAlertsSection = By.CssSelector("#uc-editfileprocessedemailalerts");

        public static readonly By ConfigureFileProcessedEmailAlertsCancelBtn = By.CssSelector("#uc-editfileprocessedemailalerts [key='btnCancel']");

        public static readonly By ConfigureFileProcessedEmailAlertsSaveBtn = By.CssSelector("#uc-editfileprocessedemailalerts [key='btnSave']");

        public static readonly By ConfigureFileNotReceivedAlertsAccordion = By.CssSelector("li[section='filenotreceivedalertconfig']>h1");

        public static readonly By ConfigureFileNotReceivedAlertsSection = By.CssSelector("#uc-filenotreceivedalertconfig");

        public static readonly By ConfigureFileNotReceivedAlertsSendAlertSection = By.CssSelector("#uc-filenotreceivedalertconfig [key='tbInput']");

        public static readonly By ConfigureFileNotReceivedAlertsCancel = By.CssSelector("#uc-filenotreceivedalertconfig [key='btnCancel']");

        public static readonly By ConfigureFileNotReceivedAlertsSaveBtn = By.CssSelector("#uc-filenotreceivedalertconfig [key='btnSave']");

        //Home Page Components
        public static readonly By CreateNewHomePageConfigurationAccordion = By.CssSelector("li[section='create']>h1");

        public static readonly By CreateNewHomePageName = By.CssSelector("#uc-create div[key='tbName']>input");

        public static readonly By CreateNewHomePageDescription = By.CssSelector("#uc-create div[key='taDescription']>textarea");

        public static readonly By CreateNewHomePageUserGroups = By.CssSelector("#uc-create div[key='finder']>input.tb-mask");

        public static readonly By CreateNewHomePageRank = By.CssSelector("#uc-create div[key='numerictbRank']>input.tb");

        public static readonly By CreateNewHomePageLockedButtonBar = By.CssSelector("#uc-create div[key='btnbarLocked']");

        public static readonly By CreateNewHomePageLockedCancelButton = By.CssSelector("#uc-create div [key='btnCancel']");

        public static readonly By CreateNewHomePageLockedSaveButton = By.CssSelector("#uc-create div [key='btnSave']");

        public static readonly By CreateNewHomePageUserGroupsEntityPicker = By.CssSelector("#uc-create [key='btnadv']");

        public static readonly By HomePageConfigurationsAccordion = By.CssSelector("li[section='grid']>h1");

        public static readonly By HomePageConfigurationsViewDropDown = By.CssSelector("#uc-grid div[key='sddlViews']");

        public static readonly By HomePageConfigrationsCustomGridView = By.CssSelector("#uc-grid .cv-container [key='btnEdit']");

        public static readonly By HomePageConfigrationsGrid = By.CssSelector("#uc-grid table.grid");

        public static readonly By HomePageConfigrationsExportBtn = By.CssSelector("#uc-grid [key='exportBtn']");

        public static readonly By HomePageConfigrationsirstGridRowPlusSign = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By HomePageConfigrationsFirstGridRowDetails = By.CssSelector("#uc-grid .form-fields");

        public static readonly By HomePageConfigrationsFirstGridRowModifyBtn = By.CssSelector("#uc-grid .form-btnssection  [action='modify']");

        public static readonly By HomePageConfigrationsFirstGridRowEditBtn = By.CssSelector("#uc-grid .form-btnssection  [key='btnEdit']");

        public static readonly By HomePageConfigrationsFirstGridRowDeleteBtn = By.CssSelector("#uc-grid .form-btnssection  [key='btnDelete']");

        public static readonly By LogoManagementAccordion = By.CssSelector("li[section='logo']>h1");

        public static readonly By LogoFileName = By.CssSelector("#uc-logo .filename");

        public static readonly By LogoFileSearchButton = By.CssSelector("#uc-logo [key='btn-browsehidden']");

        public static readonly By LogoCancelButton = By.CssSelector("#uc-logo [key='btnCancel']");

        public static readonly By LogoSaveButton = By.CssSelector("#uc-logo [key='btnSave']");

        //Employee Menu Configurations Components
        public static readonly By CurrentConfigurationAccordion = By.CssSelector("li[section='current']>h1");

        public static readonly By CurrentConfigurationSection = By.CssSelector("#uc-current");

        public static readonly By CreateNewConfigurationAccordion = By.CssSelector("li[section='create']>h1");

        public static readonly By CreateNewConfigurationNameField = By.CssSelector("#uc-create div[key='tbName'] input.tb");

        public static readonly By CreateNewConfigurationDescriptionField = By.CssSelector("#uc-create div[key='taDescription'] textarea");

        public static readonly By CreateNewConfigurationCancelButton = By.CssSelector("#uc-create [key='btnCancel']");

        public static readonly By CreateNewConfigurationCreateButton = By.CssSelector("#uc-create [key='btnSave']");

        public static readonly By ConfigurationVersionsAccordion = By.CssSelector("li[section='existing']>h1");

        public static readonly By ConfigurationVersionsGrid = By.CssSelector("#uc-existing table.grid");

        public static readonly By ConfigurationVersionsExportBtn = By.CssSelector("#uc-existing [key='exportBtn']");

        public static readonly By ConfigurationVersionsFirstGridRowID = By.CssSelector("#uc-existing .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By ConfigurationVersionsGridRow = By.CssSelector("#uc-existing .body-scroller >tr:first-of-type>td:first-of-type");

        //Configuration Details
        public static readonly By ConfigurationDetailsAccordion = By.CssSelector("li[section='details']>h1");

        public static readonly By ConfigurationDetailsSection = By.CssSelector("#uc-details");

        public static readonly By ConfigurationDetailsClonebtn = By.CssSelector("[action='clone']");

        public static readonly By EditConfigurationAccordion = By.CssSelector("li[section='editconfig']>h1");

        public static readonly By EditConfigurationSection = By.CssSelector("#uc-editconfig");

        public static readonly By EditConfidgurationViewAsUserBtn = By.CssSelector("#uc-editconfig [key='btnViewAs']");

        public static readonly By EditConfidgurationMsgsection = By.CssSelector("#uc-editconfig .std-message");

        //Help Menu Components
        // use common generic locators for help section

        //System Script Management Components
        // use common generic locators for help section

        //System Script Details

        public static readonly By SystemScriptDetailsAccordion = By.CssSelector("li[section='scriptdetails']>h1");

        public static readonly By SystemScriptDetailsSection = By.CssSelector("#uc-scriptdetails");

        public static readonly By SystemScriptDetailsRunbtn = By.CssSelector("[action='run']");

        public static readonly By CreateScheduleAccordion = By.CssSelector("li[section='createschedule']>h1");

        public static readonly By CreateScheduleScheduleTimeZone = By.CssSelector("[key='sddlScheduleTimeZoneCode']");

        public static readonly By CreateScheduleStartDate = By.CssSelector("[key='dtpStartDate']");

        public static readonly By CreateScheduleEndDate = By.CssSelector("[key='dtpEndDate']");

        public static readonly By CreateScheduleCancelBtn = By.CssSelector("#uc-createschedule [key='btnCancel']");

        public static readonly By CreateScheduleSaveBtn = By.CssSelector("#uc-createschedule [key='btnSave']");

        public static readonly By SchedulesAccordion = By.CssSelector("li[section='scriptschedules']>h1");
        // use common generic locators

        public static readonly By SystemScriptAccordion = By.CssSelector("li[section='systemscript']>h1");

        public static readonly By SystemScriptSection = By.CssSelector("#uc-systemscript");

        //System Script Schedule Details
        public static readonly By SystemScriptScheduleDetailsAccordion = By.CssSelector("li[section='details']>h1");

        public static readonly By SystemScriptScheduleDetailsSection = By.CssSelector("#uc-details");

        public static readonly By SystemScriptScheduleDetailsEditBtn = By.CssSelector("[key='btnEdit']");

        public static readonly By SystemScriptScheduleDetailsDeleteBtn = By.CssSelector("[key='btnDelete']");

        //grid details same as common generic locators

        //System Configuration Components
        public static readonly By LoginAccordion = By.CssSelector("li[section='login']>h1");

        public static readonly By LoginMaxLoginAttempts = By.CssSelector("div[key='numerictbMaxLoginAttempts'] span");

        public static readonly By LoginEnableCAPTCHA = By.CssSelector("div[key='chkEnableLogOnCaptcha'] span");

        public static readonly By LoginRestrictedMode = By.CssSelector("div[key='chkRestrictedMode']");

        public static readonly By LoginEnableStandardAuthentication = By.CssSelector("div[key='chkEnableStandardAuthentication']");

        public static readonly By LoginEnableSingleSignon = By.CssSelector("div[key='chkEnableCustomAuthentication']");

        public static readonly By LoginSystemBlockingTask = By.CssSelector("ul[key='rblSystemBlockingTaskOption']");

        public static readonly By LoginCustomerAuthenticationLoginURL = By.CssSelector("div[key='tbCustomAuthenticationLoginUrl']");

        public static readonly By LoginLoginMessage = By.CssSelector("div[key='texteditorLoginMessage']");

        public static readonly By LoginLogoutMessage = By.CssSelector("div[key='texteditorLogoutMessage']");

        public static readonly By LoginSSOErrorMessage = By.CssSelector("div[key='texteditorCustomAuthErrorMessage']");

        public static readonly By LoginLogoutURL = By.CssSelector("div[key='tbLogoutUrl']");

        public static readonly By LoginSupportAccountLoginMessage = By.CssSelector("div[key='texteditorSupportAccountLoginMessage']");

        public static readonly By LoginEditButton = By.CssSelector("#uc-login [key='btnEdit']");

        public static readonly By PasswordOptionsAccordion = By.CssSelector("li[section='password']>h1");

        public static readonly By PasswordMinimumPasswordLength = By.CssSelector("div[key='numerictbMinPasswordLen']");

        public static readonly By PasswordExpiresAfterDays = By.CssSelector("div[key='numerictbNoOfDaysUntilExpires']");

        public static readonly By PasswordNumberOfUpperCase = By.CssSelector("div[key='numerictbNoOfUpperCaseChars']");

        public static readonly By PasswordNumberOfLowerCase = By.CssSelector("div[key='numerictbNoOfLowerCaseChars']");

        public static readonly By PasswordNumberofNumeric = By.CssSelector("div[key='numerictbNoOfNumericChars']");

        public static readonly By PasswordNumberOfSpecial = By.CssSelector("div[key='numerictbNoOfSpecialChars']");

        public static readonly By PasswordSpecialCharacters = By.CssSelector("div[key='tbSpecialChars']");

        public static readonly By PasswordReusePasswordCycle = By.CssSelector("div[key='numerictbReusePasswordCycle']");

        public static readonly By PasswordForgottenPasswordEnabled = By.CssSelector("div[key='btnbarEnableForgottenPassword']");

        public static readonly By PasswordForgottenPasswordLinkExpires = By.CssSelector("div[key='numerictbNoOfHoursUntilPasswordLinkExpires']");

        public static readonly By PasswordForgottenPasswordCaptchaEnabled = By.CssSelector("div[key='btnbarEnableForgottenPasswordCaptcha']");

        public static readonly By PasswordEditButton = By.CssSelector("#uc-password [key='btnEdit']");

        public static readonly By CryptologyOptionsAccordion = By.CssSelector("li[section='cryptology']>h1");

        public static readonly By CryptologyWarningMessage = By.CssSelector("#uc-cryptology .std-message-content");

        public static readonly By CryptologyGenerateNewAsymetricKeyPaid = By.CssSelector("#uc-cryptology [action='generatenewkey']");

        public static readonly By CryptologyDownloadAsymetricPublicKey = By.CssSelector("#uc-cryptology [action='downloadkey']");

        public static readonly By MultiFactorAuthenticationAccordion = By.CssSelector("li[section='multifactorauth']>h1");

        public static readonly By MultiFactorEnableMultiFactorAuthentication = By.CssSelector("div[key='btnbarIsMFAEnabled']");

        public static readonly By MultiFactorTrustDevices = By.CssSelector("div[key='btnbarTrustDevices']");

        public static readonly By MultiFactorExcludedUserAccounts = By.CssSelector("div[key='efUserAccountIds']");

        public static readonly By MultiFactorExcludedUserGroups = By.CssSelector("div[key='efUserGroupIds']");

        public static readonly By MultiFactorEditButton = By.CssSelector("#uc-multifactorauth [key='btnEdit']");

        public static readonly By EmailOptionsAccordion = By.CssSelector("li[section='email']>h1");

        public static readonly By EmailMaximumAddressesPerUser = By.CssSelector("div[key='numerictbMaxUserDeviceEmailPerAccount']");

        public static readonly By EmailDefaultFromAddress = By.CssSelector("div[key='emailtbDefaultFromAddress']");

        public static readonly By EmailEditButton = By.CssSelector("#uc-email [key='btnEdit']");

        public static readonly By RestrictionOptionsAccordion = By.CssSelector("li[section='restriction']>h1");

        public static readonly By RestrictionDescription = By.Id("restrictionOptionsDescPartial");

        public static readonly By RestrictionComlianceUserCanMakeTheirOwnDeclerations = By.CssSelector("div[key='btnbarComplianceCanChangeOwnDeclarations']");

        public static readonly By RestrcitionEditButton = By.CssSelector("#uc-restriction [key='btnEdit']");

        public static readonly By DocumentVisibilityAcccordion = By.CssSelector("li[section='docvisibilityoptions']>h1");

        public static readonly By DocumentVisibilityTypeMatching = By.CssSelector("div[key='btnbarRestrictDocumentVisibility']");

        public static readonly By DocumentVisibilityEditButton = By.CssSelector("#uc-docvisibilityoptions [key='btnEdit']");

        public static readonly By UserInterfaceAccordion = By.CssSelector("li[section='userinterfaceoptions']>h1");

        public static readonly By UserInterfaceDefaultAccordionsToClosed = By.CssSelector("div[key='btnbarAccordionsAreClosedOnLoad']");

        public static readonly By UserInterfaceRedAlertTimeout = By.CssSelector("div[key='numerictbRedAlertBannerDefaultTimeout']");

        public static readonly By UserInterfaceYellowAlertTimeout = By.CssSelector("div[key='numerictbYellowAlertBannerDefaultTimeout']");

        public static readonly By UserInterfaceBlueAlertTimeout = By.CssSelector("div[key='numerictbBlueAlertBannerDefaultTimeout']");

        public static readonly By UserInterfaceGreenAlertTimeout = By.CssSelector("div[key='numerictbGreenAlertBannerDefaultTimeout']");

        public static readonly By UserInterfaceApplyTranslations = By.CssSelector("div[key='btnbarApplyTranslationsToCompliance']");

        public static readonly By UserInterfaceEditButton = By.CssSelector("#uc-userinterfaceoptions [key='btnEdit']");

        public static readonly By BrokerFeedStatusAccordion = By.CssSelector("li[section='brokerfeedstatus']>h1");

        public static readonly By BrokerFeedShowAllInformation = By.CssSelector("div[key='btnbarShowEmployeesBrokerFeedStatusInformation']");

        public static readonly By BrokerFeedEditButton = By.CssSelector("#uc-brokerfeedstatus [key='btnEdit']");

        public static readonly By ToDoAndToReviewAccordion = By.CssSelector("li[section='todoandtoreviewoptions']>h1");

        public static readonly By ToDoAndToReviewRequiredStatment = By.CssSelector("#uc-todoandtoreviewoptions [key='btnbarGetStatementCountInMonths']");

        public static readonly By ToDoAndToReviewEditButton = By.CssSelector("#uc-todoandtoreviewoptions [key='btnEdit']");

        public static readonly By DataEntryAccordion = By.CssSelector("li[section='dataentryoptions']>h1");

        public static readonly By DataEntryReferenceRequired = By.CssSelector("#uc-dataentryoptions [key='btnbarDataEntryReferenceRequired']");

        public static readonly By DataEntryEditButton = By.CssSelector("#uc-dataentryoptions [key='btnEdit']");

        public static readonly By SupportOptionsAccordion = By.CssSelector("li[section='supportoptions']>h1");

        public static readonly By SupportSupportURL = By.CssSelector("#uc-supportoptions [key='tbSupportUrl']");

        public static readonly By SupportContactUsURL = By.CssSelector("#uc-supportoptions [key='tbContactUsUrl']");

        public static readonly By SupportEditButton = By.CssSelector("#uc-supportoptions [key='btnEdit']");

        public static readonly By WebProxyOptionsAccordion = By.CssSelector("li[section='webproxy']>h1");

        public static readonly By WebProxyProxyURL = By.CssSelector("#uc-webproxy [key='tbUrl']");

        public static readonly By WebProxyProxyUsername = By.CssSelector("#uc-webproxy [key='tbCredentialUsername']");

        public static readonly By WebProxyProxyPassword = By.CssSelector("#uc-webproxy [key='tbUserProvidedPassword']");

        public static readonly By WebProxyByPassOnLocal = By.CssSelector("#uc-webproxy [key='btnbarBypassOnLocal']");

        public static readonly By WebProxyBypassList = By.CssSelector("#uc-webproxy [key='taBypassList']");

        public static readonly By WebProxyCancelBtn = By.CssSelector("#uc-webproxy [key='btnCancel']");

        public static readonly By WebProxySaveBtn = By.CssSelector("#uc-webproxy [key='btnSave']");

        public static readonly By MobileOptionsAccordion = By.CssSelector("li[section='mobileoptions']>h1");

        public static readonly By MobileOptionsAutomaticallyGrantAccess = By.CssSelector("#uc-mobileoptions [key='btnbarAutomaticallyGrantMobileAccess']");

        public static readonly By MobileOptionsEditButton = By.CssSelector("#uc-mobileoptions [key='btnEdit']");

        public static readonly By ControlRoomApiAccordion = By.CssSelector("li[section='controlroomapioptions']>h1");

        public static readonly By ControlRoomAuthenticationServerURL = By.CssSelector("#uc-controlroomapioptions  [key='tbAuthenticationServerUrl']");

        public static readonly By ControlRoomControlRoomAPIURL = By.CssSelector("#uc-controlroomapioptions  [key='tbControlRoomApiUrl']");

        public static readonly By ControlRoomClientID = By.CssSelector("#uc-controlroomapioptions  [key='tbClientId']");

        public static readonly By ControlRoomScopes = By.CssSelector("#uc-controlroomapioptions  [key='tbScopes']");

        public static readonly By ControlRoomTestAuthButton = By.CssSelector("#uc-controlroomapioptions  [action='test-auth']");

        public static readonly By ControlRoomEditButton = By.CssSelector("#uc-controlroomapioptions  [key='btnEdit']");

        public static readonly By AnalyticsOptionsAccordion = By.CssSelector("li[section='analyticsoptions']>h1");

        public static readonly By AnalyticsOptionsSection = By.CssSelector("#uc-analyticsoptions");

        public static readonly By AnalyticsOptionsSectionEditBtn = By.CssSelector("#uc-analyticsoptions [key='btnEdit']");

        //List Management Components
        public static readonly By CreateListAccordion = By.CssSelector("li[section='create']>h1");

        public static readonly By CreateListBusinessKey = By.CssSelector("#uc-create [key='tbBusinessKey']");

        public static readonly By CreateListListName = By.CssSelector("#uc-create [key='tbName']");

        public static readonly By CreateListDescription = By.CssSelector("#uc-create [key='taDescription']");

        public static readonly By CreateListCancelButton = By.CssSelector("#uc-create [key='btnCancel']");

        public static readonly By CreateListSaveButton = By.CssSelector("#uc-create [key='btnSave']");

        public static readonly By ListManagementGrid = By.CssSelector("#uc-grid table.grid");
        // user generic locator for grid **

        //List Details
        public static readonly By ListDetailsAccordion = By.CssSelector("li[section='details']>h1");

        public static readonly By ListDetailsSection = By.CssSelector("#uc-details");

        public static readonly By ListDetailsEditBtn = By.CssSelector("#uc-details [key='btnEdit']");

        public static readonly By ListDetailsDeleteBtn = By.CssSelector("#uc-details [key='btnDelete']");

        public static readonly By AddListItemAccordion = By.CssSelector("li[section='additem']>h1");

        public static readonly By AddListItemValuetextBox = By.CssSelector("#uc-additem [key='tbValue']");

        public static readonly By AddListItemDisplayNametextBox = By.CssSelector("#uc-additem [key='tbDisplayName']");

        public static readonly By AddListItemCancelBtn = By.CssSelector("#uc-additem [key='btnCancel']");

        public static readonly By AddListItemSaveBtn = By.CssSelector("#uc-additem [key='btnSave']");

        public static readonly By ListItemsAccordion = By.CssSelector("li[section='listitems']>h1");

        public static readonly By ListItemsViewNamesDropDown = By.CssSelector("#uc-listitems div[key='sddlViews']");

        public static readonly By ListItems = By.CssSelector("#uc-listitems table.grid");

        public static readonly By ListItemsExportBtn = By.CssSelector("#uc-listitems [key='exportBtn']");

        public static readonly By ListItemsCustomGridView = By.CssSelector("#uc-listitems .cv-container [key='btnEdit']");

        public static readonly By ListItemsFirstGridRowPlusSign = By.CssSelector("#uc-listitems .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By ListItemsFirstGridRowDetails = By.CssSelector("#uc-listitems .form-fields");

        public static readonly By ListItemsFirstGridRowDetailsEditBtn = By.CssSelector("#uc-listitems .form-btnssection [key='btnEdit']");

        //Archiving Components
        public static readonly By ArchivingAccordion = By.CssSelector("li[section='archiving']>h1");

        public static readonly By AvailableArchiveTypes = By.CssSelector("[key='chklistSelectedArchiveTypes']");

        public static readonly By SelectedRecords = By.CssSelector("[key='rblSelectedRecords']");

        public static readonly By FromField = By.CssSelector("[key='tbFrom']");

        public static readonly By ToField = By.CssSelector("[key='tbTo']");

        public static readonly By MoveOrCopy = By.CssSelector("[key='rblMoveOrCopy']");

        public static readonly By RunOptions = By.CssSelector("[key='rblRun']");

        public static readonly By StartDateTime = By.CssSelector("[key='dtpRunDateTime']");

        public static readonly By SendToArchiveButton = By.CssSelector(".action-buttons [action='SendToArchive']");

        public static readonly By RetrieveFromArchiveButton = By.CssSelector(".action-buttons [action='RetrieveFromArchive']");

        public static readonly By EditButton = By.CssSelector("[key='btnEdit']");

        public static readonly By ArchiveHistoryAccordion = By.CssSelector("li[section='archivehistory']>h1");

        public static readonly By ArchieveHistoryGrid = By.CssSelector("#uc-archivehistory table.grid");

        public static readonly By ArchieveHistoryExportToXlsBtn = By.CssSelector("#uc-archivehistory [key='exportBtn']");

        //System Languages Components
        public static readonly By SystemLanguagesTitle = By.CssSelector("[section='System Languages enabled for Translations'] h1");

        //Audit Log Compponents
        public static readonly By ConsolidatedAuditLogAccordion = By.CssSelector("[section='consolidatedauditlog']>h1");

        public static readonly By ConsolidatedAuditLogViewName = By.CssSelector("#uc-consolidatedauditlog [key='sddlViews']");

        public static readonly By ConsolidatedAuditLogFromDate = By.CssSelector("#uc-consolidatedauditlog [key='dp-consolidateddatefrom']");

        public static readonly By ConsolidatedAuditLogToDate = By.CssSelector("#uc-consolidatedauditlog [key='dp-consolidateddateto']");

        public static readonly By ConsolidatedAuditLogApplyButton = By.CssSelector("#uc-consolidatedauditlog [key='btn-consolidatedapplydatefilter']");

        public static readonly By ConsolidatedAuditLogGrid = By.CssSelector("#uc-consolidatedauditlog table.grid");

        public static readonly By ConsolidatedAuditLogExportBtn = By.CssSelector("#uc-consolidatedauditlog [key='exportBtn']");

        public static readonly By ConsolidatedAuditLogFirstRow = By.CssSelector("#uc-consolidatedauditlog .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By AuditLogAccordion = By.CssSelector("[section='auditlog']>h1");

        public static readonly By AuditLogViewName = By.CssSelector("#uc-auditlog [key='sddlViews']");

        public static readonly By AuditLogFromDate = By.CssSelector("#uc-auditlog [key='dp-datefrom']");

        public static readonly By AuditLogToDate = By.CssSelector("#uc-auditlog [key='dp-dateto']");

        public static readonly By AuditLogApplyButton = By.CssSelector("#uc-auditlog [key='btn-applydatefilter']");

        public static readonly By AuditLogGrid = By.CssSelector("#uc-auditlog table.grid");

        public static readonly By AuditLogExportBtn = By.CssSelector("#uc-auditlog [key='exportBtn']");

        public static readonly By AuditLogFirstRow = By.CssSelector("#uc-auditlog .body-scroller >tr:first-of-type>td:first-of-type");

        //Connection String Management Components
        public static readonly By CreateNewConnectionStringAccordion = By.CssSelector("[section='create']>h1");

        public static readonly By CreateNewConnectionStringKey = By.CssSelector("#uc-create [key='tbConnectionStringKey'] input.tb");

        public static readonly By CreateNewConnectionStringString = By.CssSelector("#uc-create [key='tbDecryptedConnectionString'] input.tb");

        public static readonly By CreateNewConnectionStringDataProviderType = By.CssSelector("#uc-create [key='sddlDataProviderType'] a");

        public static readonly By CreateNewConnectionStringDescription = By.CssSelector("#uc-create [key='taDescription'] textarea");

        public static readonly By CreateNewConnectionStringCancelButton = By.CssSelector("#uc-create [key='btnCancel']");

        public static readonly By CreateNewConnectionStringTestConnectionButton = By.CssSelector("#uc-create .action-buttons [action='testconnectionstringconfiguration']");

        public static readonly By CreateNewConnectionStringSaveButton = By.CssSelector("#uc-create [key='btnSave']");

        public static readonly By ConnectionStringsAccordion = By.CssSelector("[section='grid']>h1");

        public static readonly By ConnectionStringsGrid = By.CssSelector("#uc-grid table.grid");

        public static readonly By ConnectionStringsExportBtn = By.CssSelector("#uc-grid [key='exportBtn']");

        public static readonly By ConnectionStringsFirstRow = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        //Connection String Details
        public static readonly By ConnectionStringsDetailsSection = By.CssSelector("#uc-edit");

        public static readonly By ConnectionStringsDetailsTestConnectionStringBtn = By.CssSelector("#uc-edit [action='testconnectionstringconfiguration']");

        public static readonly By ConnectionStringsDetailsEditBtn = By.CssSelector("#uc-edit [key='btnEdit']");

        public static readonly By ConnectionStringsDetailsDeleteBtn = By.CssSelector("#uc-edit [key='btnDelete']");

        public static readonly By BusinessProcessVersionsAccordion = By.CssSelector("[section='grid']>h1");

        public static readonly By BusinessProcessVersionsExportToXlsBtn = By.CssSelector("#uc-grid [key='exportBtn']");
        // ** here use generic locators for grid

        ////Customer Alert Components
        public static readonly By CreateCustomAlertAccordion = By.CssSelector("[section='create']>h1");

        public static readonly By CustomAlertName = By.CssSelector("#uc-create div[key='tbName'] input.tb");

        public static readonly By CustomAlertDescription = By.CssSelector("#uc-create div[key='taDescription'] textarea");

        public static readonly By CustomAlertExcludedUserGroups = By.CssSelector("#uc-create div[key='efExcludedUserGroupIds']");

        public static readonly By DynamicRecipientGroups = By.CssSelector("#uc-create div[key='efUserGroupIds']");

        public static readonly By DynamicRecipientCustomAlertView = By.CssSelector("#uc-create div[key='scvfCustomViewId']");

        public static readonly By DynamicRecipientUserColumn = By.CssSelector("#uc-create div[key='sddlCustomAlertViewRecipientFieldId']");

        public static readonly By StaticRecipientUserAccounts = By.CssSelector("#uc-create div[key='efUserAccountIds']");

        public static readonly By StaticRecipientGroups = By.CssSelector("#uc-create div[key='efStaticUserGroupIds']");

        public static readonly By StaticRecipientCustomerAlertView = By.CssSelector("#uc-create div[key='scvfStaticCustomViewId']");

        public static readonly By StaticRecipientUserColumn = By.CssSelector("#uc-create div[key='sddlStaticCustomAlertViewRecipientFieldId']");

        public static readonly By EmailTemplateEmailFrom = By.CssSelector("#uc-create div[key='tbFromAddress'] input.tb");

        public static readonly By EmailTemplateAdditionalTo = By.CssSelector("#uc-create div[key='lstbldrToAddresses'] div[key='tbInput']");

        public static readonly By EmailTemplateAdditionalCC = By.CssSelector("#uc-create div[key='lstbldrCarbonCopies'] div[key='tbInput']");

        public static readonly By EmailTemplateAdditionalBCC = By.CssSelector("#uc-create div[key='lstbldrBlindCarbonCopies'] div[key='tbInput']");

        public static readonly By EmailTemplateKeywords = By.CssSelector("#uc-create div.keywords");

        public static readonly By EmailTemplateSubject = By.CssSelector("#uc-create [key='ckesubject']");

        public static readonly By EmailTemplateBody = By.CssSelector("#uc-create [key='ckebody']");

        public static readonly By CustomAlertCancelButton = By.CssSelector("#uc-create a[key='btnCancel']");

        public static readonly By CustomAlertSaveButton = By.CssSelector("#uc-create a[key='btnSave']");

        public static readonly By CCAExcludedUserGroupsEntityPicker = By.CssSelector("[key='efExcludedUserGroupIds'] [key='btnadv']");

        public static readonly By CCADynamicRecipientsGroupsEntityPicker = By.CssSelector("[key='efUserGroupIds'] [key='btnadv']");

        public static readonly By CCADynamicRecipientsCustomAlertViewEntityPicker = By.CssSelector("[key='scvfCustomViewId'] [key='btnadv']");

        public static readonly By CCAStaticRecipientsUserAccountsEntityPicker = By.CssSelector("[key='efUserAccountIds'] [key='btnadv']");

        public static readonly By CCAStaticRecipientsGroupsEntityPicker = By.CssSelector("[key='efStaticUserGroupIds'] [key='btnadv']");

        public static readonly By CCAStaticRecipientsCustomAlertViewEntityPicker = By.CssSelector("[key='scvfStaticCustomViewId'] [key='btnadv']");

        public static readonly By AlertTemplatesAccordion = By.CssSelector("[section='templateslist']>h1");

        public static readonly By AlertTemplatesViewNameDropDown = By.CssSelector("div[key='sddlViews'] a");

        public static readonly By AlertTemplatesGrid = By.CssSelector("#uc-templateslist table.grid");

        public static readonly By AlertTemplatesExportBtn = By.CssSelector("#uc-templateslist [key='exportBtn']");

        public static readonly By AlertTemplatesCustomGridView = By.CssSelector("#uc-templateslist .cv-container [key='btnEdit']");

        public static readonly By AlertTemplatesFirstGridRowID = By.CssSelector("#uc-templateslist .body-scroller >tr:first-of-type>td:first-of-type");

        //Custom Alert Details
        public static readonly By CustomAlertDetailsAccordion = By.CssSelector("[section='details']>h1");

        public static readonly By CustomAlertDetailsSection = By.CssSelector("#uc-details");

        public static readonly By CustomAlertDetailsCloneBtn = By.CssSelector("#uc-details [action='clone']");

        public static readonly By CustomAlertDetailsSendAlertBtn = By.CssSelector("#uc-details [action='sendcustomalert']");

        public static readonly By CustomAlertDetailsEditBtn = By.CssSelector("#uc-details [key='btnEdit']");

        public static readonly By CustomAlertDetailsDeleteBtn = By.CssSelector("#uc-details [key='btnDelete']");

        public static readonly By TemplatePreviewAccordion = By.CssSelector("[section='preview']>h1");

        public static readonly By TemplatePreviewSection = By.CssSelector("#uc-preview");

        public static readonly By TemplatePreviewBodyTempleteBtn = By.CssSelector("#uc-preview [val='template']");

        public static readonly By CreateNewScheduleAccordion = By.CssSelector("[section='createscustomalertschedule']>h1");

        public static readonly By CreateNewScheduleSection = By.CssSelector("#uc-createscustomalertschedule");

        public static readonly By CreateNewScheduleStartDate = By.CssSelector("#uc-createscustomalertschedule [key='dtpStartDate']");

        public static readonly By CreateNewScheduleEndDate = By.CssSelector("#uc-createscustomalertschedule [key='dtpEndDate']");

        public static readonly By CreateNewScheduleCancelBtn = By.CssSelector("#uc-createscustomalertschedule [key='btnCancel']");

        public static readonly By CreateNewScheduleSaveBtn = By.CssSelector("#uc-createscustomalertschedule [key='btnSave']");

        public static readonly By CustomAlertDetailsSchedulesAccordion = By.CssSelector("[section='customalertschedulesgrid']>h1");

        public static readonly By CustomAlertDetailsSchedulesExportBtn = By.CssSelector("#uc-customalertschedulesgrid table.grid");

        public static readonly By CustomAlertDetailsSchedulesFirstGridRowID = By.CssSelector("#uc-customalertschedulesgrid .body-scroller >tr:first-of-type>td:first-of-type");

        ////Customer Alert Views Components
        public static readonly By CreateCustomAlertViewsAccordion = By.CssSelector("[section='create']>h1");

        public static readonly By CreateCustomAlertDataSourceDropdown = By.CssSelector("#uc-create [key='sddlDataSource']");

        public static readonly By AlertViewsViewNameDropdown = By.CssSelector("#uc-grid [key='sddlViews']");

        public static readonly By AlertViewsGrid = By.CssSelector("#uc-grid table.grid");

        public static readonly By AlertViewsFirstRowGrid = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By AlertViewsCreateCustomGridViewIcon = By.CssSelector("#uc-grid [key='btnEdit']");

        public static readonly By AlertViewsExportToXlsBtn = By.CssSelector("#uc-grid [key='exportBtn']");
        //** use other generic grid locators

        //Custom Alert View Details
        public static readonly By CustomAlertViewDetailsAccordion = By.CssSelector("[section='details']>h1");

        public static readonly By CustomAlertViewDetailsSection = By.CssSelector("#uc-details");

        public static readonly By CustomAlertViewDetailsEditBtn = By.CssSelector("#uc-details [key='btnEdit']");

        public static readonly By CustomAlertViewDetailsDeleteBtn = By.CssSelector("#uc-details [key='btnDelete']");

        public static readonly By CustomAlertViewDetailsPreviewAccordion = By.CssSelector("[section='preview']>h1");

        public static readonly By CustomAlertViewDetailsPreviewSection = By.CssSelector("#uc-preview");

        public static readonly By CustomAlertViewDetailsPreviewExportBtn = By.CssSelector("#uc-preview table.grid");

        public static readonly By CustomAlertViewDetailsPreviewCreateCustomGridView = By.CssSelector("#uc-preview .cv-container [key='btnEdit']");

        public static readonly By CustomAlertViewDetailsPreviewFirstRowGrid = By.CssSelector("#uc-preview .body-scroller >tr:first-of-type>td:first-of-type");

        ////API Custom View Components
        public static readonly By ApiCustomViewNameDropdown = By.CssSelector("#uc-grid [key='sddlViews']");

        public static readonly By ApiCustomViewGrid = By.CssSelector("#uc-grid table.grid");

        public static readonly By ApiCustomViewCreateCustomGridViewIcon = By.CssSelector("#uc-grid [key='btnEdit']");

        public static readonly By ApiCustomViewExportToXlsBtn = By.CssSelector("#uc-grid [key='exportBtn']");

        public static readonly By ApiCustomViewFirstRowGrid = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        //Api Custom View Details

        public static readonly By APICustomViewDetailsAccordion = By.CssSelector("[section='apicustomviewtypedetails']>h1");

        public static readonly By APICustomViewDetailsSection = By.CssSelector("#uc-apicustomviewtypedetails");

        public static readonly By APICustomViewDetailsCancelBtn = By.CssSelector("#uc-apicustomviewtypedetails [key='btnCancel']");

        public static readonly By APICustomViewDetailsSaveBtn = By.CssSelector("#uc-apicustomviewtypedetails [key='btnSave']");

        public static readonly By APICustomViewsAccordion = By.CssSelector("[section='apicustomviewsgrid']>h1");

        public static readonly By APICustomViewViewsNamesDropDown = By.CssSelector("#uc-apicustomviewsgrid div[key='sddlViews']");

        public static readonly By APICustomViewsGrid = By.CssSelector("#uc-apicustomviewsgrid table.grid");

        public static readonly By APICustomViewsExportBtn = By.CssSelector("#uc-apicustomviewsgrid [key='exportBtn']");

        public static readonly By APICustomViewsCreateCustomGridView = By.CssSelector("#uc-apicustomviewsgrid .cv-container [key='btnEdit']");

        public static readonly By APICustomViewsFirstGridRowID = By.CssSelector("#uc-apicustomviewsgrid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By APICustomViewDetailsCreateViewAccordion = By.CssSelector("[section='create']>h1");

        public static readonly By APICustomViewDetailsCreateViewSection = By.CssSelector("#uc-create");

        public static readonly By APICustomViewDetailsCreateViewNameTextBox = By.CssSelector("[key='txtViewName']");

        public static readonly By APICustomViewDetailsCreateViewCancelBtn = By.CssSelector("#uc-create [key='btnCancel']");

        public static readonly By APICustomViewDetailsCreateViewCreateNewBtn = By.CssSelector("#uc-create [key='btnSaveAs']");

        public static readonly By APICustomViewDetailsDefaultViewRankAccordion = By.CssSelector("[section='rank']>h1");

        public static readonly By APICustomViewDetailsDefaultViewRankSection = By.CssSelector("#uc-rank");

        public static readonly By APICustomViewDetailsDefaultViewRankCancelBtn = By.CssSelector("#uc-rank [key='btnCancel']");

        public static readonly By APICustomViewDetailsDefaultViewRankSaveBtn = By.CssSelector("#uc-rank [key='btnSave']");

        public static readonly By APICustomViewDetailsItemDetailsAccordion = By.CssSelector("[section='details']>h1");

        public static readonly By APICustomViewDetailsItemDetailsSection = By.CssSelector("#uc-details");

        public static readonly By APICustomViewDetailsItemDetailsEditBtn = By.CssSelector("#uc-details [key='btnEdit']");

        public static readonly By APICustomViewDetailsItemDetailsDeleteBtn = By.CssSelector("#uc-details [key='btnDelete']");

        public static readonly By APICustomViewDetailsItemPreviewAccordion = By.CssSelector("[section='preview']>h1");

        public static readonly By APICustomViewDetailsItemPreviewGrid = By.CssSelector("#uc-preview table.grid");

        public static readonly By APICustomViewDetailsItemPreviewCreateCustomGridView = By.CssSelector("#uc-preview [key='btnEdit']");

        public static readonly By APICustomViewDetailsItemPreviewExportToXlsBtn = By.CssSelector("#uc-preview [key='exportBtn']");

        ////Quick Links Components
        public static readonly By CreateQuickLinkAccordion = By.CssSelector("[section='create']>h1");

        public static readonly By CreateQuickLinkDisplayName = By.CssSelector("#uc-create div[key='tbDisplayName']");

        public static readonly By CreateQuickLinkURL = By.CssSelector("#uc-create div[key='tbWebAddress']");

        public static readonly By CreateQuickLinkDescription = By.CssSelector("#uc-create div[key='tbDescription']");

        public static readonly By CreateQuickLinkDisplayOrder = By.CssSelector("#uc-create div[key='numerictbDisplayOrder']");

        public static readonly By CreateQuickLinkOpenMode = By.CssSelector("#uc-create div[key='sddlOpenIn']");

        public static readonly By CreateQuickLinkVisibilityType = By.CssSelector("#uc-create ul[key='rblSelectedPermission']");

        public static readonly By CreateQuickLinkRequiredRole = By.CssSelector("#uc-create div[key='sefRoleRequiredId']");

        public static readonly By CreateQuickLinkRequiredRoleEntityPicker = By.CssSelector("#uc-create div[key='sefRoleRequiredId'] [key='btnadv']");

        public static readonly By CreateQuickLinkCancelButton = By.CssSelector("#uc-create a[key='btnCancel']");

        public static readonly By CreateQuickLinkSaveButton = By.CssSelector("#uc-create a[key='btnSave']");

        public static readonly By QuickLinksViewNameDropdown = By.CssSelector("#uc-grid div[key='sddlViews']");

        public static readonly By QuickLinksGrid = By.CssSelector("#uc-grid table.grid");

        public static readonly By QuickLinksExportBtn = By.CssSelector("#uc-grid [key='exportBtn']");

        public static readonly By QuickLinksCreateCustomGridView = By.CssSelector("#uc-grid .cv-container [key='btnEdit']");

        public static readonly By QuickLinksFirstGridRowID = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By QuickLinksFirstGridRowPlusDetails = By.CssSelector("#uc-grid .form-fields");

        public static readonly By QuickLinksFirstGridRowTranslateBtn = By.CssSelector("#uc-grid [key='btnTranslate']");

        public static readonly By QuickLinksFirstGridRowEditBtn = By.CssSelector("#uc-grid [key='btnEdit']");

        public static readonly By QuickLinksFirstGridRowSaveBtn = By.CssSelector("#uc-grid [key='btnSave']");

        public static readonly By QuickLinksFirstGridRowDeleteBtn = By.CssSelector("#uc-grid [key='btnDelete']");

        //Credential Management
        public static readonly By CreateNewCredentialAccordion = By.CssSelector("[section='create']>h1");

        public static readonly By CreateNewCredentialUserName = By.CssSelector("#uc-create [key='tbUsername']");

        public static readonly By CreateNewCredentialPassWord = By.CssSelector("#uc-create [key='tbPassword']");

        public static readonly By CreateNewCredentialConfirmPassword = By.CssSelector("#uc-create [key='tbConfirmPassword']");

        public static readonly By CreateNewCredentialCancelBtn = By.CssSelector("#uc-create [key='btnCancel']");

        public static readonly By CreateNewCredentialSaveBtn = By.CssSelector("#uc-create [key='btnSave']");

        public static readonly By CredentialManagementGrid = By.CssSelector("#uc-grid");

        public static readonly By CredentialManagementFirstGridRowID = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By CredentialManagementFirstGridRowPlusDetails = By.CssSelector("#uc-grid .form-fields");

        public static readonly By CredentialManagementFirstGridRowEditBtn = By.CssSelector("#uc-grid [key='btnEdit']");

        public static readonly By CredentialManagementFirstGridRowSaveBtn = By.CssSelector("#uc-grid [key='btnSave']");

        public static readonly By CredentialManagementFirstGridRowDeleteBtn = By.CssSelector("#uc-grid [key='btnDelete']");

        //Application Links Components
        public static readonly By CreateApplicationLinkAccordion = By.CssSelector("[section='create']>h1");

        public static readonly By CreateApplicationDisplayName = By.CssSelector("#uc-create div[key='tbDisplayName']");

        public static readonly By CreateApplicationURL = By.CssSelector("#uc-create div[key='tbWebAddress']");

        public static readonly By CreateApplicationDisplayOrder = By.CssSelector("#uc-create div[key='numerictbDisplayOrder']");

        public static readonly By CreateApplicationOpenMode = By.CssSelector("#uc-create div[key='sddlOpenMode']");

        public static readonly By CreateApplicationUserGroups = By.CssSelector("#uc-create div[key='efSelectedUserGroupIds']");

        public static readonly By CreateApplicationUserAccounts = By.CssSelector("#uc-create div[key='efSelectedUserAccountIds']");

        public static readonly By CreateApplicationCancelBtn = By.CssSelector("#uc-create [key='btnCancel']");

        public static readonly By CreateApplicationSaveBtn = By.CssSelector("#uc-create [key='btnSave']");

        public static readonly By CreateApplicationUserGroupsEntityPicker = By.CssSelector("#uc-create div[key='efSelectedUserGroupIds'] [key='btnadv']");

        public static readonly By CreateApplicationUserAccountsEntityPicker = By.CssSelector("#uc-create div[key='efSelectedUserAccountIds'] [key='btnadv']");

        public static readonly By ApplicationLinksAccordion = By.CssSelector("[section='grid']>h1");

        public static readonly By ApplicationLinksViewNameDropdown = By.CssSelector("#uc-grid div[key='sddlViews']");

        public static readonly By ApplicationLinksGrid = By.CssSelector("#uc-grid table.grid");

        public static readonly By ApplicationLinksExportBtn = By.CssSelector("#uc-grid [key='exportBtn']");

        public static readonly By ApplicationLinksCreateCustomGridView = By.CssSelector("#uc-grid .cv-container [key='btnEdit']");

        public static readonly By ApplicationLinksFirstGridRowPlusSign = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        public static readonly By ApplicationLinksFirstGridRowPlusDetails = By.CssSelector("#uc-grid .form-btnssection [key='btnEdit']");

        public static readonly By ApplicationLinksFirstGridRowPlusDetailsEditBtn = By.CssSelector("#uc-grid .form-btnssection [key='btnEdit']");

        public static readonly By ApplicationLinksFirstGridRowPlusDetailsDeleteBtn = By.CssSelector("#uc-grid .form-btnssection [key='btnDelete']");
    }
}