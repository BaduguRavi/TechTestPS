using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTestPS.Drivers;

namespace TechTestPS.PageElements
{
    [Binding]
    public class CareersPageElements : DriverSetup
    {
        public IWebElement CareersTab => driver.FindElement(By.Id("menu-item-5060"));
        public IWebElement CareersPageImg => driver.FindElement(By.XPath("//*[@id='post - 5033']/div/div/div/div/section[2]/div/div/div/div/div/div/div/div/img"));
        public IWebElement CareersPageTxt => driver.FindElement(By.XPath("//*[@id='post - 5033']/div/div/div/div/section[3]/div/div/div/div/div/div[1]/div/h5"));
        public String strOpenPositions = "#post-5033 > div > div > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-9d57420.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div > div > div > div.elementor-element.elementor-element-548f9c2.elementor-widget.elementor-widget-wp-widget-awsm-recent-jobs > div > h5";
        public String CareersPageText = "//*[@id='post - 5033']/div/div/div/div/section[3]/div/div/div/div/div/div[1]/div/h5";

        
    }
}
