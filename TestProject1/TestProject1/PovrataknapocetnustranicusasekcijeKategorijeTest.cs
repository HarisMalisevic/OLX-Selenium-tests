using OpenQA.Selenium;

namespace TestProject1
{
    [TestFixture]
    public class PovratakNaPocetnuStranicuSaSekcijeKategorijeTest
    {
        private IWebDriver driver;
        private IJavaScriptExecutor js;

        [SetUp]
        public void SetUp()
        {
            driver = SingletonWebDriver.GetDriver();
            js = (IJavaScriptExecutor)driver;
        }

        [TearDown]
        protected void TearDown()
        {
            SingletonWebDriver.QuitDriver();
            driver.Dispose();
        }

        [Test]
        public void PovratakNaPocetnuStranicuSaSekcijeKategorije()
        {
            driver.Navigate().GoToUrl("https://olx.ba/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".css-1sjubqu")).Click();
            driver.FindElement(By.CssSelector(".main-category-icon")).Click();
            Thread.Sleep(2000);
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/kategorije"));
            js.ExecuteScript("window.scrollTo(0,6311.2001953125)");
            driver.FindElement(By.CssSelector(".olx-logo[data-v-64994449]")).Click();
            Thread.Sleep(1000);
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/"));
            long scrollPosition = (long)js.ExecuteScript("return window.scrollY || document.documentElement.scrollTop;");
            Assert.That(scrollPosition, Is.EqualTo(0));
            driver.Close();
        }
    }
}
