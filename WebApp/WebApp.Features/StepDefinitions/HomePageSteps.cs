using Disaplan.WebApp.Features.Pages;
using TechTalk.SpecFlow;

namespace Disaplan.WebApp.Features.StepDefinitions
{
    [Binding]
    public sealed class HomePageSteps
    {
        private readonly HomePage homePage;

        public HomePageSteps(HomePage homePage)
        {
            this.homePage = homePage;
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
        }

        [Then(@"I should see the homepage")]
        public void ThenIShouldSeeTheHomepage()
        {
            homePage.AssertIsDisplayed();
        }
    }
}
