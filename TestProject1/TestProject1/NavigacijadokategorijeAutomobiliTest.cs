using OpenQA.Selenium;

namespace TestProject1
{
    [TestFixture]
    public class NavigacijaDoKategorijeAutomobiliTest
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
        public void NavigacijaDoKategorijeAutomobili()
        {
            driver.Navigate().GoToUrl("https://olx.ba/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".css-1sjubqu")).Click();
            driver.FindElement(By.CssSelector(".main-category-icon > img")).Click();
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/kategorije"));
            driver.FindElement(By.LinkText("Automobili")).Click();
            Thread.Sleep(1000);
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/pretraga?category_id=18"));
            driver.Close();
        }
    }
}
