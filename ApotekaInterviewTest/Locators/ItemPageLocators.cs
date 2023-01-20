using OpenQA.Selenium;

namespace ApotekaInterviewTest.Locators;

public class ItemPageLocators
{
    public By AddToCartButton => By.CssSelector("div.add-to-basket > a");
    public By ItemName => By.CssSelector("h1[property='name']");
}