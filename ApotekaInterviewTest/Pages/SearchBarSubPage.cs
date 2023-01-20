using ApotekaInterviewTest.Locators;
using OpenQA.Selenium;

namespace ApotekaInterviewTest.Pages;

public class SearchBarSubPage
{
    private SearchBarLocators _locators;

    public SearchBarSubPage()
    {
        _locators = new SearchBarLocators();
    }

    public void SearchBarButtonClick()
    {
        Browser.FindElement(_locators.searchButton).Click();
    }

    public void ClickOnFirstResult()
    {
        Browser.FindElements(_locators.searchResults).First().Click();
    }
}