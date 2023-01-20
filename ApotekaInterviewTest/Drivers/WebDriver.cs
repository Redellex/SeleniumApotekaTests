
using ApotekaInterviewTest.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ApotekaInterviewTest.Drivers
{
    public class WebDriver
    {
        private static IWebDriver _webDriver;
        public static void InitializeDriver(BrowserType browser)
        {
            switch (browser)
            {
                case BrowserType.Chrome:
                    _webDriver = new ChromeDriver();
                    break;
                case BrowserType.ChromeHeadless:
                    _webDriver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    _webDriver = new FirefoxDriver();
                    break;
                default:
                    throw new ArgumentException("Invalid browser type chosen");
            }
            _webDriver.Manage().Window.Maximize();
        }
        
        public static IWebDriver Driver()
        {
            return _webDriver;
        }
    }
}