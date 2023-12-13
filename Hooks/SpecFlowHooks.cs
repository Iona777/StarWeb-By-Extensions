using NUnit.Framework;

using Star.Web.AutomatedUITests.Framework.Configuration;

using TechTalk.SpecFlow;

namespace Star.Web.AutomatedUITests.Hooks
{
    [Binding]
    public class SpecFlowHooks
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            SeleniumExecutor.Initialize(TestContext.CurrentContext.Test.Name);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            SeleniumExecutor.Close();
        }
    }
}