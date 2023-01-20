using ApotekaInterviewTest.Locators;

namespace ApotekaInterviewTest.Pages;

public class MyProfilePage: BasePage
{
    private MyProfilePageLocators _locators;

    public MyProfilePage()
    {
        _locators = new MyProfilePageLocators();
    }
    
    public override void GoToPage()
    {
        Browser.GoToUrl("https://apopro.dk/Profile");
    }

    public string GetProfileName()
    {
        return Browser.FindElement(_locators.MyProfileName).Text;
    }
}