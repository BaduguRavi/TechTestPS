using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTestPS.Drivers;

namespace TechTestPS.CommonMethods
{
    [Binding]
    public class ComMeths : DriverSetup
    {

        public void MouseOverSubMenu(String strXPath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //Instantiate Action Class        
            Actions actions = new Actions(driver);
            //Retrieve WebElement 'Music' to perform mouse hover 
            IWebElement menuOption = (IWebElement)driver.FindElement(By.XPath(strXPath));
            //Mouse hover menuOption 'Music'
            actions.MoveToElement(menuOption).Perform();

        }
        public void MouseHover(IWebElement elementToHover)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(elementToHover).Build().Perform();
        }
        public void MouseHoverAndClick(IWebElement elementToHover, IWebElement elementToClick)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(elementToHover).Click(elementToClick).Build().Perform();
        }

        public void Click(IWebElement elementToClick)
        {
            Actions clickOn = new Actions(driver);
            clickOn.Click(elementToClick).Build().Perform();
        }

        public void EnterText(IWebElement elementToSendKeys)
        {
            Actions enterText = new Actions(driver);
            enterText.SendKeys("Careers").Build().Perform();

        }

    }
}
