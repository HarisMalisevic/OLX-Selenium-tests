using OpenQA.Selenium;

namespace TestProject1
{
    [TestFixture]
    public class FiltriranjeNekretninaPoMinimalnojIMaksimalnojCijeniTest
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
        public void FiltriranjeNekretninaPoMinimalnojIMaksimalnojCijeni()
        {
            driver.Navigate().GoToUrl("https://olx.ba/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".css-1sjubqu")).Click();
            driver.FindElement(By.LinkText("Nekretnine")).Click();
            Thread.Sleep(1000);
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/nekretnine"));
            driver.FindElement(By.Id("price_lower")).SendKeys("0");
            driver.FindElement(By.Id("price_upper")).SendKeys("100000000");
            driver.FindElement(By.CssSelector(".mt-lg.mr-sm")).Click();
            Thread.Sleep(1000);
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/pretraga?category_id=23&price_from=0&price_to=100000000"));
            driver.Close();
        }
    }
}
