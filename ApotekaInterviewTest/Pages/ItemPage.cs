using ApotekaInterviewTest.Locators;

namespace ApotekaInterviewTest.Pages;

public class ItemPage
{
    private ItemPageLocators _locators;

    public ItemPage ()
    {
        _locators = new ItemPageLocators();
    }

    public void AddToBasket()
    {
        Browser.FindElement(_locators.AddToCartButton).Click();
    }

    public string GetItemName()
    {
        return Browser.FindElement(_locators.ItemName).Text;
    }
}