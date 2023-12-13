using OpenQA.Selenium;

namespace Star.Web.AutomatedUITests.Locators.Compliance
{
    public class ReviewPage
    {
        //// General Page Components
        public static By PageHeader = By.CssSelector("h1.pageheader");

        public static By EntityPicker = By.CssSelector("[key='btnadv']:first-of-type");

        public static By VisiblePopupHeader = By.CssSelector("div.popup-open .title");

        public static By VisiblePopupGrid = By.CssSelector("div.popup-open table.grid");

        public static By NotesandAttachmentsAccordion = By.CssSelector("[section='notesandattachments']>h1");

        public static By NotesandAttachmentsGrid = By.CssSelector("#uc-notesandattachments .cv-grid>table");

        public static By CreateButton = By.CssSelector("[title='Create']");

        public static By CreateSection = By.CssSelector("[key='tab-create']>div");

        public static By CreateSectionCancelBtn = By.CssSelector("#uc-notesandattachments [key='btnCancel']");

        public static By CreateSectionCreateBtn = By.CssSelector("#uc-notesandattachments [key='btnSave']");

        //Cases - Trade Request Related Cases
        public static By AssignToMe = By.CssSelector("[key='mycases']");

        public static By AssignToOthers = By.CssSelector("[key='assignedcases']");

        public static By UnAssigned = By.CssSelector("[key='unassignedcases']");

        public static By OpenCases = By.CssSelector("[key='sddl-filters']");

        public static By ViewName = By.CssSelector("[key='sddlViews']");

        public static By CustomGridView = By.CssSelector(".viewselector [key='btnEdit']");

        public static By ExportBtn = By.CssSelector("[key='exportBtn']");

        public static By FirstGridData = By.CssSelector(".body-scroller>tr:first-of-type>td:first-of-type");

        public static By UpdateBtn = By.CssSelector("[action='updateselectedcases']");

        //To Review page components
        public static By MyItemsFilterButtonBar = By.CssSelector(".filterbuttons [key='myitems']");

        public static By UnavailableItemsButtonBar = By.CssSelector(".filterbuttons [key='available']");

        public static By AvailableItemsButtonBar = By.CssSelector(".filterbuttons [key='unavailable']");

        public static By TradeRequestAccordion = By.CssSelector("li[section='traderequests']>h1");

        public static By TradeRequestsGrid = By.CssSelector("#uc-traderequests table.grid");

        public static By TradeRequestsFirstRow = By.CssSelector("#uc-traderequests .body-scroller>tr:first-of-type>td:first-of-type");

        public static By TradeRequestsExportBtn = By.CssSelector("#uc-traderequests [key='exportBtn']");

        public static By PrivateTransactionsAccordion = By.CssSelector("li[section='privatetransactions']>h1");

        public static By PrivateTransactionsGrid = By.CssSelector("#uc-privatetransactions table.grid");

        public static By PrivateTransactionsExportBtn = By.CssSelector("#uc-privatetransactions [key='exportBtn']");

        public static By PrivateTransactionsFirstRow = By.CssSelector("#uc-privatetransactions .body-scroller>tr:first-of-type>td:first-of-type");

        public static By DocumentsAccordion = By.CssSelector("li[section='documents']>h1");

        public static By DocumentsGrid = By.CssSelector("#uc-documents table.grid");

        public static By DocumentsExportBtn = By.CssSelector("#uc-documents [key='exportBtn']");

        public static By DocumentsFirstRow = By.CssSelector("#uc-documents .body-scroller>tr:first-of-type>td:first-of-type");

        public static By GiftsAccordion = By.CssSelector("li[section='gifts']>h1");

        public static By GiftsGrid = By.CssSelector("#uc-gifts table.grid");

        public static By GiftsExportBtn = By.CssSelector("#uc-gifts [key='exportBtn']");

        public static By GiftsFirstRow = By.CssSelector("#uc-gifts .body-scroller>tr:first-of-type>td:first-of-type");

        public static By EntertainmentAccordion = By.CssSelector("li[section='entertainments']>h1");

        public static By EntertainmentGrid = By.CssSelector("#uc-entertainments table.grid");

        public static By EntertainmentExportBtn = By.CssSelector("#uc-entertainments [key='exportBtn']");

        public static By EntertainmentFirstRow = By.CssSelector("#uc-entertainments .body-scroller>tr:first-of-type>td:first-of-type");

        public static By OutsideActivityAccordion = By.CssSelector("li[section='outsideactivity']>h1");

        public static By OutsideActivityGrid = By.CssSelector("#uc-outsideactivity table.grid");

        public static By OutsideActivityExportBtn = By.CssSelector("#uc-outsideactivity [key='exportBtn']");

        public static By OutsideActivityFirstRow = By.CssSelector("#uc-outsideactivity .body-scroller>tr:first-of-type>td:first-of-type");

        public static By PoliticalActivityAccordion = By.CssSelector("li[section='politicalactivity']>h1");

        public static By PoliticalActivityGrid = By.CssSelector("#uc-politicalactivity table.grid");

        public static By PoliticalActivityExportBtn = By.CssSelector("#uc-politicalactivity [key='exportBtn']");

        public static By PoliticalActivityFirstRow = By.CssSelector("#uc-politicalactivity .body-scroller>tr:first-of-type>td:first-of-type");

        public static By PoliticalBeneficiaryAccordion = By.CssSelector("li[section='beneficiary']>h1");

        public static By PoliticalBeneficiaryGrid = By.CssSelector("#uc-beneficiary table.grid");

        public static By PoliticalBeneficiaryFirstGrid = By.CssSelector("#uc-beneficiary .body-scroller>tr:first-of-type>td:first-of-type");

        public static By BrokerAccountStatementsAccordion = By.CssSelector("li[section='statements']>h1");

        public static By BrokerAccountStatementsGrid = By.CssSelector("#uc-statements table.grid");

        public static By BrokerAccountStatementsExportBtn = By.CssSelector("#uc-statements [key='exportBtn']");

        public static By BrokerAccountStatementsFirstGrid = By.CssSelector("#uc-statements .body-scroller>tr:first-of-type>td:first-of-type");

        //Cases page components
        public static By AssignedToMeButtonBar = By.CssSelector(".filterbuttons [key='mycases']");

        public static By AssignedToOthersButtonBar = By.CssSelector(".filterbuttons [key='assignedcases']");

        public static By UnassignedButtonBar = By.CssSelector(".filterbuttons [key='unassignedcases']");

        public static By TradeRequestRelatedCasesAccordion = By.CssSelector("li[section='traderequests']>h1");

        public static By TradeRequestRelatedCasesGrid = By.CssSelector("#uc-traderequests table.grid");

        public static By TradeRequestRelatedCasesViewButton = By.CssSelector("#uc-traderequests [action='viewall']");

        public static By TradeRequestRelatedCasesFirstGrid = By.CssSelector("#uc-traderequests .body-scroller>tr:first-of-type>td:first-of-type");

        //Case Details
        //Cases // Trade Request Related Cases // Trade Request Case Details
        public static By UpdateCaseAccordion = By.CssSelector("li[section='updatecase']>h1");

        public static By UpdateCaseSection = By.CssSelector("li[section='updatecase'] .form-fields");

        public static By UpdateCaseUpdateBtn = By.CssSelector("li[section='updatecase'] [action='update-case']");

        public static By SurveillanceCaseReasonsAccordion = By.CssSelector("li[section='casereasons']>h1");

        public static By SurveillanceCaseReasonsExportBtn = By.CssSelector("#uc-casereasons [key='exportBtn']");

        public static By SurveillanceCaseReasonsFirstGrid = By.CssSelector("#uc-casereasons .body-scroller>tr:first-of-type>td:first-of-type");

        public static By TradeRequestInformationAccordion = By.CssSelector("li[section='details']>h1");

        public static By TradeRequestInformationSection = By.CssSelector("#uc-details");

        public static By CaseHistoryAccordion = By.CssSelector("li[section='casehistory']>h1");

        public static By CaseHistoryExportBtn = By.CssSelector("#uc-casehistory [key='exportBtn']");

        public static By CaseHistoryFirstGrid = By.CssSelector("#uc-casehistory .body-scroller>tr:first-of-type>td:first-of-type");

        public static By TradeRequestFormAccordion = By.CssSelector("li[section='form']>h1");

        public static By TradeRequestFormSection = By.CssSelector("#uc-form");

        public static By MatchedTransactionsAccordion = By.CssSelector("li[section='matchedtransactions']>h1");

        public static By MatchedTransactionsExportBtn = By.CssSelector("#uc-matchedtransactions [key='exportBtn']");

        public static By TransactionAccordion = By.CssSelector("li[section='transactions']>h1");

        public static By TransactionGrid = By.CssSelector("#uc-transactions table.grid");

        public static By TransactionExportBtn = By.CssSelector("#uc-transactions [key='exportBtn']");

        public static By TradeRequestsAccordion = By.CssSelector("li[section='traderequests']>h1");

        public static By TradeRequestGrid = By.CssSelector("#uc-traderequests table.grid");

        public static By HoldingsAccordion = By.CssSelector("li[section='holdings']>h1");

        public static By HoldingsExportBtn = By.CssSelector("#uc-holdings [key='exportBtn']");

        public static By HoldingsDatePicker = By.CssSelector("[key='dpDateFilter']");

        public static By HoldingsDatePickerApplyBtn = By.CssSelector("[key='btnApplyDateFilter']");

        public static By HoldingsFirstGrid = By.CssSelector("#uc-holdings .body-scroller>tr:first-of-type>td:first-of-type");

        public static By BrokerAccountMissingStatementsAccordion = By.CssSelector("li[section='statements']>h1");

        public static By BrokerAccountMissingStatementsExportBtn = By.CssSelector("#uc-statements [key='exportBtn']");

        public static By BrokerAccountMissingStatementsFirstGrid = By.CssSelector("#uc-statements .body-scroller>tr:first-of-type>td:first-of-type");

        public static By BrokerFeedIssuesAccordion = By.CssSelector("li[section='brokerfeedissues']>h1");

        public static By BrokerFeedIssuesExportBtn = By.CssSelector("#uc-brokerfeedissues [key='exportBtn']");

        public static By BrokerFeedIssuesFirstGrid = By.CssSelector("#uc-brokerfeedissues .body-scroller>tr:first-of-type>td:first-of-type");

        //
        public static By OrderRelatedCasesAccordion = By.CssSelector("li[section='orders']>h1");

        public static By OrderRelatedCasesGrid = By.CssSelector("#uc-orders table.grid");

        public static By ViewOrderRelatedCasesViewButton = By.CssSelector("#uc-orders [action='viewall']");

        public static By ViewOrderRelatedCasesFirstGrid = By.CssSelector("#uc-orders .body-scroller>tr:first-of-type>td:first-of-type");
        //Case Details
        //Cases // Order Related Cases //Order Case Details

        public static By OCDUpdateCaseAccordion = By.CssSelector("li[section='updatecase']>h1");

        public static By OCDUpdateCaseSection = By.CssSelector("li[section='updatecase'] .form-fields");

        public static By OCDUpdateCaseUpdateBtn = By.CssSelector("li[section='updatecase'] [action='update-case']");

        public static By OrderCaseReasonsAccordion = By.CssSelector("li[section='ordercasereasons']>h1");

        public static By OrderCaseReasonsExportBtn = By.CssSelector("#uc-ordercasereasons [key='exportBtn']");

        public static By OrderCaseReasonsFirstGrid = By.CssSelector("#uc-ordercasereasons .body-scroller>tr:first-of-type>td:first-of-type");

        public static By OrderInformationAccordion = By.CssSelector("li[section='details']>h1");

        public static By OrderInformationSection = By.CssSelector("#uc-details");

        public static By AmendmentsAccordion = By.CssSelector("li[section='amendments']>h1");

        public static By AmendmentsSection = By.CssSelector("#uc-amendments");

        public static By AmendmentsExportBtn = By.CssSelector("#uc-amendments [key='exportBtn']");

        public static By OCDCaseHistoryAccordion = By.CssSelector("li[section='casehistory']>h1");

        public static By OCDCaseHistoryExportBtn = By.CssSelector("#uc-casehistory [key='exportBtn']");

        public static By OCDCaseHistorySection = By.CssSelector("#uc-casehistory");

        public static By OCDTradeRequestAccordion = By.CssSelector("li[section='traderequests']>h1");

        public static By OCDTradeRequestSection = By.CssSelector("#uc-traderequests");

        public static By OCDTradeRequestExportBtn = By.CssSelector("#uc-traderequests [key='exportBtn']");

        public static By OCDTradeRequestFirstGrid = By.CssSelector("#uc-traderequests .body-scroller>tr:first-of-type>td:first-of-type");

        public static By OrdersAccordion = By.CssSelector("li[section='orders']>h1");

        public static By OrdersSection = By.CssSelector("#uc-orders");

        public static By OrdersExportBtn = By.CssSelector("#uc-orders [key='exportBtn']");

        public static By OrdersFirstGrid = By.CssSelector("#uc-orders .body-scroller>tr:first-of-type>td:first-of-type");

        public static By TransactionsAccordion = By.CssSelector("li[section='transactions']>h1");

        public static By TransactionsSection = By.CssSelector("#uc-transactions");

        public static By TransactionsExportBtn = By.CssSelector("#uc-transactions [key='exportBtn']");

        public static By TransactionsFirstGrid = By.CssSelector("#uc-transactions .body-scroller>tr:first-of-type>td:first-of-type");

        //Casess
        public static By TransactionRelatedCasesAccordion = By.CssSelector("li[section='transactions']>h1");

        public static By TransactionRelatedCasesGrid = By.CssSelector("#uc-transactions table.grid");

        public static By ViewTransactionsRelatedCasesViewButton = By.CssSelector("#uc-transactions [action='viewall']");

        public static By ViewTransactionsRelatedFirstGrid = By.CssSelector("#uc-transactions .body-scroller>tr:first-of-type>td:first-of-type");

        //Case Details - Review - Cases - Transaction Related Cases -Security Transaction Case Details

        public static By SecurityTransactionInformationAccordion = By.CssSelector("li[section='details']>h1");

        public static By SecurityTransactionInformationSection = By.CssSelector("#uc-details");

        public static By BrokerAccountMissingsStatementsAccordion = By.CssSelector("li[section='statements']>h1");

        public static By BrokerAccountMissingsStatementsGrid = By.CssSelector("#uc-statements table.grid");

        public static By BrokerAccountMissingsStatementsExportBtn = By.CssSelector("#uc-statements [key='exportBtn']");

        public static By BrokerAccountMissingsStatementsFirsGridData = By.CssSelector("li[section='statements'] .body-scroller>tr:first-of-type>td:first-of-type");

        public static By TradeTimeLineAccordion = By.CssSelector("li[section='datavisualisation']>h1");

        public static By TradeTimeLineSection = By.CssSelector("#uc-datavisualisation");

        //
        public static By PrivateTransactionConfirmationsRelatedAccordion = By.CssSelector("li[section='privatetransactionconfirmations']>h1");

        public static By PrivateTransactionConfirmationsRelatedGrid = By.CssSelector("#uc-privatetransactionconfirmations table.grid");

        public static By PrivateTransactionConfirmationsRelatedViewButton = By.CssSelector("#uc-privatetransactionconfirmations [action='viewall']");

        public static By PrivateTransactionConfirmationsRelatedFirstGrid = By.CssSelector("#uc-privatetransactionconfirmations .body-scroller>tr:first-of-type>td:first-of-type");

        //Case Details - Review - Cases - Private Transaction Confirmation Related Cases - Private Transaction Confirmation Case Details

        public static By PrivateTransactionDetailsAccordion = By.CssSelector("li[section='privatetransactiondetails']>h1");

        public static By PrivateTransactionDetailsSection = By.CssSelector("#uc-privatetransactiondetails .form-fields");
        // end

        public static By GiftRelatedCasesAccordion = By.CssSelector("li[section='gifts']>h1");

        public static By GiftRelatedCasesRelatedGrid = By.CssSelector("#uc-gifts table.grid");

        public static By GiftRelatedCasesViewButton = By.CssSelector("#uc-gifts [action='viewall']");

        public static By GiftRelatedCasesFirstGrid = By.CssSelector("#uc-gifts .body-scroller>tr:first-of-type>td:first-of-type");

        //Case Details - Review - Cases - Gift Related Cases - Gift Case Details
        public static By GiftInformationAccordion = By.CssSelector("li[section='donumdetails']>h1");

        public static By GiftInformationSection = By.CssSelector("#uc-donumdetails .form-content");
        // end

        public static By DocumentSubmissionRelatedCasesAccordion = By.CssSelector("li[section='documentsubmissions']>h1");

        public static By DocumentSubmissionRelatedCasesGrid = By.CssSelector("#uc-documentsubmissions table.grid");

        public static By ViewDocumentSubmissionRelatedCasesViewButton = By.CssSelector("#uc-documentsubmissions [action='viewall']");

        public static By ViewDocumentSubmissionRelatedCasesFirstGrid = By.CssSelector("#uc-documentsubmissions .body-scroller>tr:first-of-type>td:first-of-type");

        //Case Details - Review - Cases - Document Submission Related Cases //Document Case Details
        public static By DocumentSubmissionInformationAccordion = By.CssSelector("li[section='details']>h1");

        public static By DocumentSubmissionInformationSection = By.CssSelector("#uc-details .form-content");

        public static By DocumentFormPreviewAccordion = By.CssSelector("li[section='preview']>h1");

        public static By DocumentFormPreviewSection = By.CssSelector("#uc-preview .form-content");
        // end

        public static By ManuallyRaisedCasesAccordion = By.CssSelector("li[section='manuallyrasied']>h1");

        public static By ManuallyRaisedCasesGrid = By.CssSelector("#uc-manuallyrasied table.grid");

        public static By ViewManuallyRaisedCasesViewButton = By.CssSelector("#uc-manuallyrasied [action='viewall']");

        public static By ManuallyRaisedCasesFirstGrid = By.CssSelector("#uc-manuallyrasied .body-scroller>tr:first-of-type>td:first-of-type");

        //Case Details - Review - Cases - Manually Raised Cases // Manually Raised Case Details

        public static By CaseInformationAccordion = By.CssSelector("li[section='details']>h1");

        public static By CaseInformationSection = By.CssSelector("#uc-details");

        // end
        //
        public static By TotalTradeRequestRelatedCasesLabel = By.CssSelector("#uc-accordioncounts [data-type='Traderequest'] .item-type");

        public static By TotalOrderRelatedCasesLabel = By.CssSelector("#uc-accordioncounts [data-type='Order'] .item-type");

        public static By TotalTransactionRelatedCasesLabel = By.CssSelector("#uc-accordioncounts [data-type='Securitytransaction'] .item-type");

        public static By TotalPrivateTransactionRequestLabel = By.CssSelector("#uc-accordioncounts [data-type='Privatetransactionrequest'] .item-type");

        public static By TotalPrivateTransactionConfirmationLabel = By.CssSelector("#uc-accordioncounts [data-type='Privatetransactionconfirmation'] .item-type");

        public static By TotalGiftRelatedCasesLabel = By.CssSelector("#uc-accordioncounts [data-type='Gift'] .item-type");

        public static By TotalEntertainmentRelatedCasesLabel = By.CssSelector("#uc-accordioncounts [data-type='Entertainment'] .item-type");

        public static By TotalDocumentSubmissionRelatedCasesLabel = By.CssSelector("#uc-accordioncounts [data-type='Documentsubmission'] .item-type");

        public static By TotalFirmTradeRelatedCasesLabel = By.CssSelector("#uc-accordioncounts [data-type='Firmtrade'] .item-type");

        public static By TotalManuallyRaisedCasesLabel = By.CssSelector("#uc-accordioncounts [data-type='Manuallyraised'] .item-type");

        //Manually Raised Cases
        //Cases // Manually Raised Cases
        public static By CreateManuallyRaisedCaseAccordion = By.CssSelector("li[section='create']>h1");

        public static By CreateManuallyRaisedCaseRelatedToInputBox = By.CssSelector("[key='finder']");

        public static By CreateManuallyRaisedDescription = By.CssSelector("[key='tbCaseDescription']");

        public static By CreateManuallyRaisedCancelBtn = By.CssSelector("#uc-create [key='btnCancel']");

        public static By CreateManuallyRaisedCreateBtn = By.CssSelector("#uc-create [key='btnSave']");

        //Override Review page components
        public static By OverrideReviewTradeRequestsAccordion = By.CssSelector("li[section='traderequests']>h1");

        public static By OverrideReviewTradeRequestsGrid = By.CssSelector("#uc-traderequests table.grid");

        public static By OverrideReviewTradeRequestsExportBtn = By.CssSelector("#uc-traderequests [key='exportBtn']");

        public static By OverrideReviewTradeRequestsFirsGridData = By.CssSelector("li[section='traderequests'] .body-scroller>tr:first-of-type>td:first-of-type");

        //OverrideReview // Override Review Trade Request

        public static By SummaryAccordion = By.CssSelector("li[section='form']>h1");

        public static By SummaryOverrideReviewResultDD = By.CssSelector("[key='sddlReviewResult']");

        public static By SummaryOverrideReviewCommentsTextBox = By.CssSelector("[key='taComplianceComment']");

        public static By SummarySubmitButton = By.CssSelector("[key='btnSave'] .btntext");

        public static By PreviewAccordion = By.CssSelector("li[section='preview']>h1");

        public static By PreviewSection = By.CssSelector("#uc-preview");

        public static By RuleSetResultsAccordion = By.CssSelector("li[section='rulesetresults']>h1");

        public static By RuleSetResultsExportBtn = By.CssSelector("#uc-rulesetresults [key='exportBtn']");

        public static By RuleSetResultsFirstGridData = By.CssSelector("[section='rulesetresults'] .body-scroller>tr:first-of-type>td:first-of-type");

        public static By ReviewsAccordion = By.CssSelector("li[section='reviews']>h1");

        public static By ReviewsSection = By.CssSelector("#uc-reviews");

        public static By FurtherQuestionsAccordion = By.CssSelector("li[section='questions']>h1");

        public static By FurtherQuestionsSection = By.CssSelector("#uc-questions");

        //PRIVATE TRANSACTIONS
        public static By OverrideReviewPrivateTransactionsAccordion = By.CssSelector("li[section='privatetransactions']>h1");

        public static By OverrideReviewPrivateTransactionsGrid = By.CssSelector("#uc-privatetransactions table.grid");

        public static By OverrideReviewPrivateTransactionsExportBtn = By.CssSelector("#uc-privatetransactions [key='exportBtn']");

        public static By OverrideReviewPrivateTransactionsFirsGridData = By.CssSelector("li[section='privatetransactions'] .body-scroller>tr:first-of-type>td:first-of-type");

        public static By OverrideReviewDocumentsAccordion = By.CssSelector("li[section='documents']>h1");

        public static By OverrideReviewDocumentsGrid = By.CssSelector("#uc-documents table.grid");

        public static By OverrideReviewDocumentsExportBtn = By.CssSelector("#uc-documents [key='exportBtn']");

        public static By OverrideReviewDocumentsFirsGridData = By.CssSelector("li[section='documents'] .body-scroller>tr:first-of-type>td:first-of-type");

        public static By OverrideReviewGiftsAccordion = By.CssSelector("li[section='gifts']>h1");

        public static By OverrideReviewGiftsGrid = By.CssSelector("#uc-gifts table.grid");

        public static By OverrideReviewGiftsExportBtn = By.CssSelector("#uc-gifts [key='exportBtn']");

        public static By OverrideReviewGiftsFirsGridData = By.CssSelector("li[section='gifts'] .body-scroller>tr:first-of-type>td:first-of-type");

        public static By OverrideReviewEntertainmentAccordion = By.CssSelector("li[section='entertainments']>h1");

        public static By OverrideReviewEntertainmentGrid = By.CssSelector("#uc-entertainments table.grid");

        public static By OverrideReviewEntertainmentExportBtn = By.CssSelector("#uc-entertainments [key='exportBtn']");

        public static By OverrideReviewEntertainmentFirsGridData = By.CssSelector("li[section='entertainments'] .body-scroller>tr:first-of-type>td:first-of-type");

        public static By OverrideReviewOutsideActivityAccordion = By.CssSelector("li[section='outsideactivity']>h1");

        public static By OverrideReviewOutsideActivityGrid = By.CssSelector("#uc-outsideactivity table.grid");

        public static By OverrideReviewOutsideActivityExportBtn = By.CssSelector("#uc-outsideactivity [key='exportBtn']");

        public static By OverrideReviewOutsideActivityFirsGridData = By.CssSelector("li[section='outsideactivity'] .body-scroller>tr:first-of-type>td:first-of-type");

        public static By OverrideReviewPoliticalActivityAccordion = By.CssSelector("li[section='politicalactivity']>h1");

        public static By OverrideReviewPoliticalActivityGrid = By.CssSelector("#uc-politicalactivity table.grid");

        public static By OverrideReviewPoliticalActivityExportBtn = By.CssSelector("#uc-politicalactivity [key='exportBtn']");

        public static By OverrideReviewPoliticalActivityFirsGridData = By.CssSelector("li[section='politicalactivity'] .body-scroller>tr:first-of-type>td:first-of-type");

        public static By OverrideReviewBrokerAccountStatementAccordion = By.CssSelector("li[section='statements']>h1");

        public static By OverrideReviewBrokerAccountStatementGrid = By.CssSelector("#uc-statements table.grid");

        public static By OverrideReviewBrokerAccountStatementExportBtn = By.CssSelector("#uc-statements [key='exportBtn']");

        public static By OverrideReviewBrokerAccountStatementFirsGridData = By.CssSelector("li[section='statements'] .body-scroller>tr:first-of-type>td:first-of-type");

        //  ------------------------------------------

        // REVIEW LEVELS PAGE
        public static By GobalReviewSettingsAccordion = By.CssSelector("li[section='global']>h1");

        public static By GobalReviewSettingsSection = By.CssSelector("#uc-global .form-section");

        public static By GobalReviewSettingsEditBtn = By.CssSelector("li[section='global'] [key='btnEdit']");

        public static By CreateNewReviewLevelAccordion = By.CssSelector("li[section='create']>h1");

        public static By CreateNewReviewLevelNametextBox = By.CssSelector("li[section='create'] [key='tbName']");

        public static By CreateNewReviewLevelDesTextBox = By.CssSelector("li[section='create'] [key='tbDescription']");

        public static By CreateNewReviewLevelPosition = By.CssSelector("li[section='create'] [key='numerictbPosition']");

        public static By CreateNewReviewLevelDisplayOrder = By.CssSelector("li[section='create'] [key='numerictbDisplayRank']");

        public static By CreateNewReviewLevelDisplayCancelBtn = By.CssSelector("li[section='create'] [key='numerictbDisplayRank']");

        public static By CreateNewReviewLevelDisplayCreateBtn = By.CssSelector("li[section='create'] [key='numerictbDisplayRank']");

        public static By ReviewLevelsAccordion = By.CssSelector("li[section='grid']>h1");

        public static By ReviewLevelsGrid = By.CssSelector("#uc-grid table.grid");

        public static By ReviewLevelsExportBtn = By.CssSelector("[key='exportBtn']");

        public static By ReviewLevelsCustomGridView = By.CssSelector("#uc-grid [key='btnEdit']");

        public static By FirstReviewLevelsID = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        //Review Level - Review Level Details

        public static By DetailsAccordion = By.CssSelector("li[section='details']>h1");

        public static By DetailsSection = By.CssSelector("#uc-details");

        public static By DetailsEditBtn = By.CssSelector("#uc-details [key='btnEdit']");

        public static By DetailsDeleteBtn = By.CssSelector("#uc-details [key='btnDelete']");

        public static By UserAccountsAccordion = By.CssSelector("li[section='useraccounts']>h1");

        public static By UserAccountsFirstRow = By.CssSelector("#uc-useraccounts .body-scroller >tr:first-of-type>td:first-of-type");

        public static By UserAccountsExportBtn = By.CssSelector("li[section='useraccounts'] [key='exportBtn']");

        // REVIEW DELEGATION PAGE

        public static By CreateNewReviewDelegationAccordion = By.CssSelector("li[section='create']>h1");

        public static By CreateNewReviewDelegationPrimaryReviewertextBox = By.CssSelector("[key='sefReviewerUserAccountId'] [key='finder']");

        public static By CreateNewReviewDelegationCancelBtn = By.CssSelector("[key='btnCancel']");

        public static By CreateNewReviewDelegationCreateBtn = By.CssSelector("[key='btnSave']");

        public static By ReviewDelegationEntityPicker = By.CssSelector("[key='sefReviewerUserAccountId'] [key='btnadv']");

        public static By ReviewDelegationViewNameDropdown = By.CssSelector("#uc-grid [key='sddlViews']");

        public static By ReviewDelegationGrid = By.CssSelector("#uc-grid table.grid");

        public static By ReviewDelegationExportBtn = By.CssSelector("[key='exportBtn']");

        public static By ReviewDelegationCustomGridView = By.CssSelector("#uc-grid [key='btnEdit']");

        public static By ReviewDelegationFirstPlusSignReviewerID = By.CssSelector("#uc-grid .body-scroller >tr:first-of-type>td:first-of-type");

        public static By ReviewDelegationFirstPlusSignReviewerDetails = By.CssSelector("[key='sefReviewerUserAccountId'] .lbl");

        //-------------------------------------------
    }
}