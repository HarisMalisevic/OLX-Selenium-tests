using OpenQA.Selenium;

namespace TestProject1
{
    [TestFixture]
    public class IspravanLoginTest
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
        public void IspravanLogin_IspravnaSifra_IspravnoKorisnickoIme()
        {
            driver.Navigate().GoToUrl("https://olx.ba/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".css-1sjubqu")).Click();
            driver.FindElement(By.LinkText("Prijavi se")).Click();
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/login"));
            driver.FindElement(By.Name("username")).SendKeys("vvs.fhkmm@gmail.com");
            driver.FindElement(By.Name("password")).SendKeys("VVSfhkmm2024#");
            driver.FindElement(By.CssSelector("button[data-v-3de08799]")).Click();
            Thread.Sleep(5000);
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/"));
            driver.Close();
        }
    }
}
