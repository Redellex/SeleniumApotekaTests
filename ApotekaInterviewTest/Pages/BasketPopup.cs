using ApotekaInterviewTest.Drivers;
using ApotekaInterviewTest.Locators;
using OpenQA.Selenium.Support.UI;

namespace ApotekaInterviewTest.Pages;

public class BasketPopup
{
    private BasketPopupLocators _locators;

    public BasketPopup()
    {
        _locators = new BasketPopupLocators();
    }

    public string GetBasketSummaryText()
    {
        new WebDriverWait(WebDriver.Driver(), TimeSpan.FromSeconds(10)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(_locators.BasketSummaryInformation));
        return Browser.FindElement(_locators.BasketSummaryInformation).Text;
    }

    public void GoToBasket()
    {
        new WebDriverWait(WebDriver.Driver(), TimeSpan.FromSeconds(10)).Until(
            SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(_locators.BasketSummaryInformation));
        Browser.FindElement(_locators.GoToBasket).Click();
    }
}