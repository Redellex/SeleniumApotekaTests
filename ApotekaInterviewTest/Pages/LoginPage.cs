using ApotekaInterviewTest.Locators;

namespace ApotekaInterviewTest.Pages;

public class LoginPage: BasePage
{
    private readonly string _url = "https://apopro.dk/Account/Login";
    private LoginPageLocators _locators;

    public LoginPage()
    {
        _locators = new LoginPageLocators();
        
    }
    public override void GoToPage()
    {
        Browser.GoToUrl(_url);
    }

    public void Login(string email, string password)
    {
        Browser.FindElement(_locators.EmailInput).SendKeys(email);
        Browser.FindElement(_locators.PasswordInput).SendKeys(password);
        Browser.FindElement(_locators.LoginButton).Click();
    }

    public string GetAlertInfo()
    {
        return Browser.FindElement(_locators.AlertInfo).Text;
    }
}