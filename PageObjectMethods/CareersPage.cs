using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTestPS.CommonMethods;
using TechTestPS.PageElements;

namespace TechTestPS.PageObjectMethods
{
    [Binding]
    public class CareersPage : CareersPageElements
    {
        ComMeths commMeths = new ComMeths();
        public void ClickOnCareersTab()
        {
            commMeths.Click(CareersTab);
        }
        public void verifyCareerPageTxt()
        {
            if (driver.FindElement(By.CssSelector(strOpenPositions)).Displayed)
            {
                String strActual = "Open Positions";
                strActual.Should().StartWith("Op");
            }
        }

    }
}
