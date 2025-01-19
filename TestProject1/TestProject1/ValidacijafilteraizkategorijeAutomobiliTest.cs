using OpenQA.Selenium;

namespace TestProject1
{
    [TestFixture]
    public class ValidacijaFilteraIzKategorijeAutomobiliTest
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
        public void ValidacijaFilteraIzKategorijeAutomobili()
        {
            driver.Navigate().GoToUrl("https://olx.ba/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".css-1sjubqu")).Click();
            driver.FindElement(By.CssSelector(".main-category-icon > img")).Click();
            Thread.Sleep(1000);
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/kategorije"));
            driver.FindElement(By.LinkText("Automobili")).Click();
            Thread.Sleep(5000);
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/pretraga?category_id=18"));
            driver.FindElement(By.CssSelector(".cars-filter")).Click();
            Thread.Sleep(500);
            Assert.That(driver.FindElement(By.CssSelector(".sortGroupFilter[data-v-3d39cbd2]")).Displayed, Is.True);
            driver.FindElement(By.CssSelector(".relative:nth-child(6) > div > .flex")).Click();
            Thread.Sleep(500);
            Assert.That(driver.FindElement(By.CssSelector(".relative:nth-child(6) > div > .sortGroupFilter")).Displayed, Is.True);
            driver.FindElement(By.CssSelector(".relative:nth-child(7) > div > .flex")).Click();
            Thread.Sleep(500);
            Assert.That(driver.FindElement(By.CssSelector(".relative:nth-child(7) > div > .sortGroupFilter")).Displayed, Is.True);
            driver.FindElement(By.CssSelector(".relative:nth-child(8) > div > .flex")).Click();
            Thread.Sleep(500);
            Assert.That(driver.FindElement(By.CssSelector(".relative:nth-child(8) > div > .sortGroupFilter")).Displayed, Is.True);
            driver.FindElement(By.CssSelector(".main-btn")).Click();
            Thread.Sleep(500);
            Assert.That(driver.FindElement(By.CssSelector(".gallery-open")).Displayed, Is.True);
            driver.FindElement(By.CssSelector(".modal-header > .h-6")).Click();
            Thread.Sleep(500);
            var popupExists = driver.FindElements(By.CssSelector(".gallery-open")).Count > 0;
            Assert.That(popupExists, Is.False);
            driver.Close();
        }
    }
}