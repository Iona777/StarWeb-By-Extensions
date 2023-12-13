using Star.Web.AutomatedUITests.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star.Web.AutomatedUITests.Models
{
    public class DefaultAmendedOrder
    {
        public static string securitySymbol = "AAPL";
        public static string brokerAccount = "70395 Scottrade Head Office";
        public static string transactionType = "Buy";
        public static string orderType = "Limit";
        public static string duration = "Fill or kill";

        public static string OrderDateMM = "12";
        public static string OrderDateDD = "01";
        public static string OrderDateYYYY = "2020";

        public static string quantity = "100";
        public static string LimitPrice = "10";

        public static string brokerReference = "BF" + CommonStepDefinitions.GenerateRandomNumber();
        public static string memoText = "This is some memo text";
        public static string amendmentType = "Amendment";


        public static string amendedOrderType = "Limit";
    }
}
