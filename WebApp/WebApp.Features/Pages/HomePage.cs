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

        private IWebElement FindTitle => testContext.Driver.FindElement(By.Id("HomePageTitle"));

        public void GoTo()
        {
            testContext.Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["RootUrl"]);
        }
        
        public void AssertIsDisplayed()
        {
            FindTitle.Displayed.Should().BeTrue();
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