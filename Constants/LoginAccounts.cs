using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star.Web.AutomatedUITests.Models;

namespace Star.Web.AutomatedUITests.Constants
{
    public static class LoginAccounts
    {
        public static readonly Account Cwood = new("cwood", "cwood", "cwood", "Testing123!", false);

        public static readonly Account Empl1 = new("empl1", "empl1", "empl1", "6xnRDefcnCkbLqeMbbGfyA3mfK8", false);

        public static readonly Account Support = new("support", "support", "defaultadmin", "defaultadmin", true);

        public static readonly Account InvalidAccount = new("invalidaccount", "invalidaccount", "invalidaccount", "invalidaccount", false);
    }
}
