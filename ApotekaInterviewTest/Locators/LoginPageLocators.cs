using OpenQA.Selenium;

namespace ApotekaInterviewTest.Locators;

public class LoginPageLocators
{
    public By EmailInput => By.Id("Email");
    public By PasswordInput => By.Id("password");
    public By LoginButton => By.Id("login-submit");
    public By AlertInfo => By.ClassName("alert-danger");
}