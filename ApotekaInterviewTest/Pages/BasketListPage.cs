using ApotekaInterviewTest.Locators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = ApotekaInterviewTest.Drivers.WebDriver;

namespace ApotekaInterviewTest.Pages;

public class BasketListPage
{
    private BasketListPageLocators _locators;

    public BasketListPage()
    {
        _locators = new BasketListPageLocators();
    }

    public IWebElement GetItemName()
    {
        return Browser.FindElement(_locators.BasketItemName);
    }

    public string GetBusketSummary()
    {
        return Browser.FindElement(_locators.BasketListEmptySummary).Text;
    }

    public void RemoveItem()
    {
        new WebDriverWait(WebDriver.Driver(), TimeSpan.FromSeconds(10)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_locators.BasketItemRemoveButton));
        Browser.FindElement(_locators.BasketItemRemoveButton).Click();
    }
}