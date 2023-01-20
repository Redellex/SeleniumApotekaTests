using OpenQA.Selenium;

namespace ApotekaInterviewTest.Locators;

public class SearchBarLocators
{
   public By searchButton = By.Id("navsearch-submit");
   public By searchResults = By.CssSelector("section[data-packageid]");
}