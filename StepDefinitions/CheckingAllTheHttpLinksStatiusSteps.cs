using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTestPS.CommonMethods;
using TechTestPS.Drivers;

namespace TechTestPS.StepDefinitions
{
    [Binding]
    public class CheckingAllTheHttpLinksStatiusSteps : DriverSetup
    {
        MenuLinks menuLinks = new MenuLinks();
        List<string> lstAllLinks = new List<string>();

        [Given(@"I launched the website")]
        public void GivenILaunchedTheWebsite()
        {
            driver.Navigate().GoToUrl(_baseURL);
        }
        
        [When(@"I check all the links")]
        public void WhenICheckAllTheLinks()
        {
            lstAllLinks=menuLinks.GetAllLinks(_baseURL);
        }
        
        [Then(@"I should get a TestLog\.txt file in base directory with status")]
        public void ThenIShouldGetATestLog_TxtFileInBaseDirectoryWithStatus()
        {
            menuLinks.CheckAllURLS(lstAllLinks);
        }
    }
}
