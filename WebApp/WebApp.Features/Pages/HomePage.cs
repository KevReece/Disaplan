using System;
using System.Configuration;
using FluentAssertions;
using OpenQA.Selenium;

namespace Disaplan.WebApp.Features.Pages
{
    public class HomePage
    {
        private readonly TestContext testContext;

        public HomePage(TestContext testContext)
        {
            this.testContext = testContext;
        }

        private IWebElement FindIntroCarousel => testContext.Driver.FindElement(By.Id("intro"));

        public void GoTo()
        {
            testContext.Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["RootUrl"]);
        }
        
        public void AssertIsDisplayed()
        {
            FindIntroCarousel.Displayed.Should().BeTrue();
        }
        
        public static bool IsDisplayed(Func<IWebElement> elementFinder)
        {
            try
            {
                return elementFinder().Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}