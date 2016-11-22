using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SeleniumInDotNetCoreTest
{
    public class On_google_search_page : IDisposable
    {
        private IWebDriver _driver;

        public On_google_search_page()
        {
            var capabilities = DesiredCapabilities.InternetExplorer();
            _driver = new RemoteWebDriver(new Uri("http://localhost:5555"), capabilities);
        }

        public void Dispose()
        {
        }

        [Fact]
        public void Should_find_search_box()
        {
            _driver.Navigate().GoToUrl("http://www.google.com/ncr");
            Console.WriteLine(_driver.Title);

            IWebElement query = _driver.FindElement(By.Name("q"));
            query.SendKeys("TestingBot");
            query.Submit();
            Console.WriteLine(_driver.Title);

            _driver.Quit();

        }
    }
}
