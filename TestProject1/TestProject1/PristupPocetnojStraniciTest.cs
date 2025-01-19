using OpenQA.Selenium;

namespace TestProject1
{
    public class PristupPocetnojStraniciTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = SingletonWebDriver.GetDriver();
        }

        [TearDown]
        protected void TearDown()
        {

            SingletonWebDriver.QuitDriver();
            driver.Dispose();
        }

        [Test]
        public void PristupPocetnojStranici()
        {
            driver.Navigate().GoToUrl("https://olx.ba");
            Thread.Sleep(5000); // Pause for 5 seconds to allow all elements to load
            Assert.That(driver.Title, Is.EqualTo("OLX.ba početna"));
        }
    }
}