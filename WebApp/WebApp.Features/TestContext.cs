using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Disaplan.WebApp.Features
{
    public class TestContext
    {
        private static IWebDriver driver;

        public IWebDriver Driver => driver;

        public static void Initialise()
        {
            driver = new ChromeDriver();
        }

        public void Setup()
        {
        }

        public void Clear()
        {
            driver.Navigate().GoToUrl("about:blank");
        }

        public static void Dispose()
        {
            driver.Quit();
        }
    }
}