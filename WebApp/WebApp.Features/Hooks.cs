using Disaplan.WebApp.Features.Pages;
using TechTalk.SpecFlow;

namespace Disaplan.WebApp.Features
{
    [Binding]
    public class Hooks
    {
        private readonly TestContext testContext;
        private readonly HomePage homePage;

        public Hooks(TestContext testContext, HomePage homePage)
        {
            this.testContext = testContext;
            this.homePage = homePage;
        }

        [BeforeTestRun]
        public static void BeforeAllScanarios()
        {
            TestContext.Initialise();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            testContext.Setup();
            homePage.GoTo();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            testContext.Clear();
        }

        [AfterTestRun]
        public static void AfterAllScenarios()
        {
            TestContext.Dispose();
        }
    }
}