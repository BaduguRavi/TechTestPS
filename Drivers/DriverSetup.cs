using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace TechTestPS.Drivers
{
    [Binding]
    public class DriverSetup
    {
        public static IWebDriver driver;

        public String _baseURL = "https://www.positive-solutions.co.uk/";

    }
}
