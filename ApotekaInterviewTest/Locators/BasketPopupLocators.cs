using OpenQA.Selenium;

namespace ApotekaInterviewTest.Locators;

public class BasketPopupLocators
{
    public By BasketSummaryInformation = By.CssSelector("p.h2");
    public By GoToBasket = By.CssSelector("div.modal-body a[href='/Cart']");
}