using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTestPS.Drivers;

namespace TechTestPS.Hooks
{
    [Binding]
    public sealed class BaseHook : DriverSetup
    {
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
