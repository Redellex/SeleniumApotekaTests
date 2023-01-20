using FluentAssertions;

namespace ApotekaInterviewTest.Steps;
using ApotekaInterviewTest.Pages;

[Binding]
public class LoginPageSteps
{
    private readonly ScenarioContext _scenarioContext;
    private LoginPage _loginPage;
    
    LoginPageSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        _loginPage = new LoginPage();
    }

    [Given("I am on Login Page")]
    public void GivenIamOnHomePage()
    {
        _loginPage.GoToPage();
    }

    [When(@"I enter credentials ""(.*)"", ""(.*)""")]
    public void WhenIEnterCredentials(string email, string password)
    {
        _loginPage.Login(email, password);
    }

    [Then(@"I see alert information ""(.*)""")]
    public void ThenISeeAlertInformation(string expectedError)
    {
        var check = _loginPage.GetAlertInfo();
        _loginPage.GetAlertInfo().Should().Contain(expectedError);
    }
}