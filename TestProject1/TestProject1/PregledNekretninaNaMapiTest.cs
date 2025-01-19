using OpenQA.Selenium;

namespace TestProject1
{
    [TestFixture]
    public class PregledNekretninaNaMapiTest
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
        public void PregledNekretninaNaMapi()
        {
            driver.Navigate().GoToUrl("https://olx.ba/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".css-1sjubqu")).Click();
            driver.FindElement(By.LinkText("Nekretnine")).Click();
            Thread.Sleep(1000);
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/nekretnine"));
            driver.FindElement(By.CssSelector(".mt-lg.ml-sm")).Click();
            Thread.Sleep(5000);
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/pretraga?category_id=23&show_map=1"));
            driver.Close();
        }
    }
}
