using OpenQA.Selenium;

namespace ApotekaInterviewTest.Locators;

public class BasketListPageLocators
{
   public By BasketItemName => By.CssSelector("span[ng-bind-html='orderItem.ProductName']");
   public By BasketItemRemoveButton => By.CssSelector("a[title='Fjern fra kurv']");
   public By BasketListEmptySummary => By.CssSelector("div.cart_empty h3");
}