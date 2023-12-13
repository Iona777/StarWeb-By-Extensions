using Star.Web.AutomatedUITests.StepDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star.Web.AutomatedUITests.Models
{
    public static class DefaultUser
    {
        public static string FirstName = "Joe";
        public static string MiddleName = "Frederick";
        public static string LastName = "Bloggs"+ CommonStepDefinitions.GenerateRandomNumber();
        public static string UserName = "jf"+LastName;
        public static string JobTitle = "Test User";
        public static string EmployeeCode = "jf" + LastName;
        public static string OfficeName = "New York";
        public static string PhoneNumer = "0190412345678";
        public static string EmailAddress =  "JFBLoggs@Blah.com";
        public static string EmailDescription = "Work";
        public static string Password = "testPassword";
        public static string NewPassword = "newTestPassword";
    }
}
