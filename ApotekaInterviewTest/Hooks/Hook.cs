using ApotekaInterviewTest.Drivers;
using ApotekaInterviewTest.Utilities;

namespace ApotekaInterviewTest.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario()]
        public void BeforeScenario()
        {
            WebDriver.InitializeDriver(BrowserType.Chrome);
        }

        [AfterScenario()]
        public void AfterScenario()
        {
            WebDriver.Driver().Close();
        }
    }
}