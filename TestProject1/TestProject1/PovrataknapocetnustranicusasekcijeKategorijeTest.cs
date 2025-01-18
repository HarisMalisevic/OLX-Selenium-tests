// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;

namespace TestProject1
{
    [TestFixture]
    public class PovrataknapocetnustranicusasekcijeKategorijeTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
        [Test]
        public void povrataknapocetnustranicusasekcijeKategorije()
        {
            driver.Navigate().GoToUrl("https://olx.ba/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".css-1sjubqu")).Click();
            driver.FindElement(By.CssSelector(".main-category-icon")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,6311.2001953125)");
            driver.FindElement(By.LinkText("Pirotehnika")).Click();
            js.ExecuteScript("window.scrollTo(0,1968)");
            driver.Close();
        }
    }
}
