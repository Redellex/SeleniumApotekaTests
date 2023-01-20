using ApotekaInterviewTest.Pages;
using FluentAssertions;
using NUnit.Framework;

namespace ApotekaInterviewTest.Steps;

[Binding]
public class MyProfilePageSteps
{
    private MyProfilePage _myProfilePage;
    
    public MyProfilePageSteps()
    {
        _myProfilePage = new MyProfilePage();
    }
    
    [Then(@"I should see profile with name ""(.*)""")]
    public void ThenIShouldSeeProfileWithName(string expectedProfileName)
    {
        var check = _myProfilePage.GetProfileName();
        _myProfilePage.GetProfileName().Should().Equals(expectedProfileName);
    }
}