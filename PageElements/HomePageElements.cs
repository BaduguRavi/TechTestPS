using OpenQA.Selenium;
using TechTestPS.Drivers;

namespace TechTestPS.PageElements
{
    public class HomePageElements : DriverSetup
    {
        public IWebElement CompanyLogo => driver.FindElement(By.ClassName("fusion-standard-logo"));
        public IWebElement CustomerSupportTabId => driver.FindElement(By.Id("menu-item-2572"));
        public IWebElement CustomerServiceSubMenu => driver.FindElement(By.Id("menu-item-4816"));
        public IWebElement SolutionsTab => driver.FindElement(By.Id("menu-item-2134"));

    }
}
    