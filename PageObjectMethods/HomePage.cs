using TechTalk.SpecFlow;
using TechTestPS.CommonMethods;
using TechTestPS.PageElements;

namespace TechTestPS.PageObjectMethods
{
    [Binding]
    public class HomePage : HomePageElements
    {

        ComMeths commMeths = new ComMeths();
        public void ClickOnLogo()
        {
            commMeths.Click(CompanyLogo);
        }
       public void customerSupportMouseHover()
        {
            commMeths.MouseHover(CustomerSupportTabId);
        }
        
        public void ClickOnCustomerServiceSubmenu()
        {
            commMeths.Click(CustomerServiceSubMenu);
        }


    }
}
