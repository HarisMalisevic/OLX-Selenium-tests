using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestProject1;

public class SingletonWebDriver
{
    private static IWebDriver _driver;

    private SingletonWebDriver() { }

    public static IWebDriver GetDriver()
    {
        if (_driver == null)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        return _driver;
    }

    public static void QuitDriver()
    {
        if (_driver != null)
        {
            _driver.Quit();
            _driver.Dispose();
            _driver = null;
        }
    }
}
