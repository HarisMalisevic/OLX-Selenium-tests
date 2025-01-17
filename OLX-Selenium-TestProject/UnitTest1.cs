using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OLX_Selenium_TestProject;

[TestFixture]
    public class WebDriverTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void VerifyGoogleTitle()
        {
            // Navigate to Google
            _driver.Navigate().GoToUrl("https://www.google.com");

            // Verify the page title
            Assert.That(_driver.Title, Is.EqualTo("Google"));
        }

        [TearDown]
        public void Teardown()
        {
            // Close the browser
            _driver.Quit();
            _driver.Dispose();
        }
    }