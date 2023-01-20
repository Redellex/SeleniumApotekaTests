using ApotekaInterviewTest.Locators;
using ApotekaInterviewTest.Pages;

namespace ApotekaInterviewTest.Steps;

[Binding]
public class CommonSteps
{
    private CookiePopupSubPage _cookiePopup;
    private LoginPage _loginPage;
    
    public CommonSteps()
    {
        _cookiePopup = new CookiePopupSubPage();
        _loginPage = new LoginPage();
    }
    
    [Given("I accept all cookies")]
    public void GivenIAcceptAllCookies()
    {
        _cookiePopup.AcceptCookies();
    }
    
    [Given("I am logged")]
    public void GivenIamLogged()
    {
        //I could get credentials from json configuration
        _loginPage.GoToPage();
        _cookiePopup.AcceptCookies();
        _loginPage.Login("psobocinski@pgs-soft.com", "TestForInterview1");
    }
}