using OpenQA.Selenium;

namespace TestProject1
{
    [TestFixture]
    public class NeispravanLoginTest
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

        [TestCase("vvs.fhkmm@gmail.com", "1234", TestName = "NeispravanLogin_NeispravnaSifra_IspravnoKorisnickoIme")]
        [TestCase("nepostojeciEmail@gmail.com", "VVSfhkmm2024", TestName = "NeispravanLogin_IspravnaSifra_NeispravnoKorisnickoIme")]
        [TestCase("nepostojeciEmail@gmail.com", "1234", TestName = "NeispravanLogin_NeispravnaSifra_NeispravnoKorisnickoIme")]
        public void NeispravanLogin(string korisnickoIme, string sifra)
        {
            driver.Navigate().GoToUrl("https://olx.ba/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector(".css-1sjubqu")).Click();
            driver.FindElement(By.LinkText("Prijavi se")).Click();
            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/login"));

            driver.FindElement(By.Name("username")).SendKeys(korisnickoIme);
            driver.FindElement(By.Name("password")).SendKeys(sifra);
            driver.FindElement(By.CssSelector("button[data-v-3de08799]")).Click();

            Thread.Sleep(2000);

            Assert.That(driver.Url, Is.EqualTo("https://olx.ba/login"));

            driver.Close();
        }
    }
}
