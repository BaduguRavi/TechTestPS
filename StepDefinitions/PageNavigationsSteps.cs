using System;
using TechTalk.SpecFlow;
using TechTestPS.Drivers;
using TechTestPS.PageObjectMethods;

namespace TechTestPS.StepDefinitions
{
    [Binding]
    public class PageNavigationsSteps : DriverSetup
    {
        CareersPage careersPage = new CareersPage();

        [Given(@"I'm on homepage")]
        public void GivenIMOnHomepage()
        {
            driver.Navigate().GoToUrl(_baseURL);
        }

        [When(@"I Click on Careers tab")]
        public void WhenIClickOnCareersTab()
        {
            careersPage.ClickOnCareersTab();
        }

        [Then(@"I Should navigate to Careers page")]
        public void ThenIShouldNavigateToCareersPage()
        {
            careersPage.verifyCareerPageTxt();
        }

    }
}
