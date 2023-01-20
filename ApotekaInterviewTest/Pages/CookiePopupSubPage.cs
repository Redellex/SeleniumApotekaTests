using ApotekaInterviewTest.Locators;

namespace ApotekaInterviewTest.Pages;

public class CookiePopupSubPage
{
    private cookiesLocators _locators;

    public CookiePopupSubPage()
    {
        _locators = new cookiesLocators();
    }
    
    public void AcceptCookies()
    {
        Browser.FindElement(_locators.CookieAcceptButton).Click();
    }
}