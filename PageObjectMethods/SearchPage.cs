using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTestPS.CommonMethods;
using TechTestPS.PageElements;

namespace TechTestPS.PageObjectMethods
{
    [Binding]
    public class SearchPage : SearchPageElements
    {
        ComMeths commMeths = new ComMeths();
        public void ClickSearchIcon()
        {
            commMeths.MouseHover(SearchIcon);
            commMeths.Click(SearchIcon);
        }

        public void EnterTextAndSearch()
        {
            IWebElement txtField = driver.FindElement(By.CssSelector(strSearchField));
            txtField.SendKeys("Careers");
            IWebElement btnSearch = driver.FindElement(By.CssSelector(btnSearchButton));
            commMeths.Click(btnSearch);
        }

        public void verifyPageEntryTitle()
        {
            if (driver.FindElement(By.XPath(SearchPageEntryTittle)).Displayed)
            {
                String strActual = "Need a new search?";
                strActual.Should().StartWith("Ne");
            }
        }

    }
}
