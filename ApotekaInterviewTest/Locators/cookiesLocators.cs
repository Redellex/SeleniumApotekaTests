using OpenQA.Selenium;

namespace ApotekaInterviewTest.Locators;

public class cookiesLocators
{
    public By CookieAcceptButton => By.CssSelector("button[onkeypress='CookieInformation.submitAllCategories();']");
}