using OpenQA.Selenium.DevTools.V117.DOM;
using Star.Web.AutomatedUITests.Locators;
using Star.Web.AutomatedUITests.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Star.Web.AutomatedUITests.Models
{
    public class DefaultBroker
    {        
        public static string AccountTitle = "Test Default Broker Account " + CommonStepDefinitions.GenerateRandomNumber();
        public static string AccountNumber = "70" + CommonStepDefinitions.GenerateRandomNumber();
        public static string BrokerOffice = "Scottrade Head Office";
        public static string DateOpenedMM = "12";
        public static string DateOpenedDD = "01";
        public static string DateOpenedYYYY = "2020";
        public static string AccountType = "Regular Account";
        public static string AccountStatus = "Active";
         
    }
}
