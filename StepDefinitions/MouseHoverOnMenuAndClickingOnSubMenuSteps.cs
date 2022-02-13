using TechTalk.SpecFlow;
using TechTestPS.Drivers;
using TechTestPS.PageObjectMethods;

namespace TechTestPS.StepDefinitions
{
    [Binding]
    public class MouseHoverOnMenuAndClickingOnSubMenuSteps : DriverSetup
    {
        HomePage homePage = new HomePage();

        [Given(@"As a user I lauched the website")]
        public void GivenAsAUserILauchedTheWebsite()
        {
            driver.Navigate().GoToUrl(_baseURL);
        }

        [When(@"I do perform mouse hover action on Customer Support and I see a submenu item")]
        public void WhenIDoPerformMouseHoverActionOnCustomerSupportAndISeeASubmenuItem()
        {
            homePage.customerSupportMouseHover();
        }

        [Then(@"I should click on that submenu item")]
        public void ThenIShouldClickOnThatSubmenuItem()
        {
            homePage.ClickOnCustomerServiceSubmenu();
        }
    }
}
