namespace Star.Web.AutomatedUITests.Models
{
    public class Account
    {
        public string LegacyUsername { get; set; }

        public string LegacyPassword { get; set; }

        public string OAuthUsername { get; set; }

        public string OAuthPassword { get; set; }

        public bool IsSupportAccount { get; set; }

        public Account(string legacyUsername, string legacyPassword, string oAuthUsername, string oAuthPassword, bool isSupportAccount)
        {
            LegacyUsername = legacyUsername;
            LegacyPassword = legacyPassword;
            OAuthUsername = oAuthUsername;
            OAuthPassword = oAuthPassword;
            IsSupportAccount = isSupportAccount;
        }
    }
}
