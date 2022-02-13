using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTestPS.Drivers;

namespace TechTestPS.PageElements
{
    [Binding]
    public class SearchPageElements : DriverSetup
    {
        public IWebElement SearchIcon => driver.FindElement(By.CssSelector("#menu-psl-mega-menu > li.fusion-custom-menu-item.fusion-main-menu-search"));
        public IWebElement SearchTextField => driver.FindElement(By.CssSelector("#menu-psl-mega-menu > li.fusion-custom-menu-item.fusion-main-menu-search.fusion-main-menu-search-open > div > form > div > div.fusion-search-field.search-field > label > input"));
        public IWebElement SearchTextFieldSearchIcon => driver.FindElement(By.CssSelector("#menu-psl-mega-menu > li.fusion-custom-menu-item.fusion-main-menu-search.fusion-main-menu-search-open > div > form > div > div.fusion-search-button.search-button > input"));

        public String SearchPageEntryTittle = "//*[@id='content']/div[1]/h1";

        public String strSearchField = "#menu-psl-mega-menu > li.fusion-custom-menu-item.fusion-main-menu-search.fusion-main-menu-search-open > div > form > div > div.fusion-search-field.search-field > label > input";
        
        public String btnSearchButton = "#menu-psl-mega-menu > li.fusion-custom-menu-item.fusion-main-menu-search.fusion-main-menu-search-open > div > form > div > div.fusion-search-button.search-button > input";
        

    }
}
