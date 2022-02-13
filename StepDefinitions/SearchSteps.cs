using TechTalk.SpecFlow;
using TechTestPS.Drivers;
using TechTestPS.PageObjectMethods;

namespace TechTestPS.StepDefinitions
{
    [Binding]
    public class SearchSteps : DriverSetup
    {
        
        SearchPage searchPage = new SearchPage();

        [Given(@"AS a user I enter Careers in searchfield")]
        public void GivenASAUserIEnterCareersInSearchfield()
        {
            driver.Navigate().GoToUrl(_baseURL);
            searchPage.ClickSearchIcon();
        }
        
        [When(@"I click on search")]
        public void WhenIClickOnSearch()
        {
            searchPage.EnterTextAndSearch();
        }
        
        [Then(@"It should navigate me to a screen where i see recent posts advanced searchfield etc")]
        public void ThenItShouldNavigateMeToAScreenWhereISeeRecentPostsAdvancedSearchfieldEtc()
        {
            searchPage.verifyPageEntryTitle();
        }
    }
}
