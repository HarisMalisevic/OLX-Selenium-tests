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

namespace TestProject1
{
  [TestFixture]
  public class NavigacijadokategorijeAutomobiliTest
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
    public void navigacijadokategorijeAutomobili()
    {
      driver.Navigate().GoToUrl("https://olx.ba/");
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
      Thread.Sleep(5000); // Pause for 5 seconds to allow all elements to load
      driver.FindElement(By.CssSelector(".css-1sjubqu")).Click();
      driver.FindElement(By.CssSelector(".main-category-icon > img")).Click();
      driver.FindElement(By.LinkText("Automobili")).Click();
      driver.Close();
    }
  }
}
