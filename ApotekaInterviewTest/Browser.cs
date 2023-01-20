using System.Collections.ObjectModel;
using OpenQA.Selenium;
using WebDriver = ApotekaInterviewTest.Drivers.WebDriver;

namespace ApotekaInterviewTest;

public class Browser
{
    public static void GoToUrl(string url)
    {
        WebDriver.Driver().Navigate().GoToUrl(url);
    }

    public static IWebElement FindElement(By selector)
    {
        return WebDriver.Driver().FindElement(selector);
    }

    public static ReadOnlyCollection<IWebElement> FindElements(By selector)
    {
        return WebDriver.Driver().FindElements(selector);
    }
}