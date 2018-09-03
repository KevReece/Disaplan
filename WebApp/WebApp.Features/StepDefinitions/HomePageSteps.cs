using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Disaplan.WebApp.Features.StepDefinitions
{
    [Binding]
    public sealed class HomePageSteps
    {
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            Assert.Fail();
        }

        [Then(@"I should see the homepage")]
        public void ThenIShouldSeeTheHomepage()
        {
            Assert.Fail();
        }
    }
}
