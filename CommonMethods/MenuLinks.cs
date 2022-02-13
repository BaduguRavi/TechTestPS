using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;
using TechTestPS.Drivers;

namespace TechTestPS.CommonMethods
{
    [Binding]
    public class MenuLinks : DriverSetup
    {
        public void CheckMenuLinks(string strURL)
        {
            driver.Navigate().GoToUrl(strURL);

            //Declare Webrequest
            HttpWebRequest re = null;
            var urls = driver.FindElements(By.TagName("a")).Take(10);

            Console.WriteLine("Looking at all URLs of Positive Solutions site :");
            //Loop through all the urls
            foreach (var url in urls)
            {
                if (!(url.Text.Contains("Email") || url.Text == ""))
                {
                    //Get the url
                    re = (HttpWebRequest)WebRequest.Create(url.GetAttribute("href"));
                    try
                    {
                        var response = (HttpWebResponse)re.GetResponse();
                        System.Console.WriteLine($"URL: {url.GetAttribute("href")} status is :{response.StatusCode}");
                    }
                    catch (WebException e)
                    {
                        var errorResponse = (HttpWebResponse)e.Response;
                        System.Console.WriteLine($"URL: {url.GetAttribute("href")} status is :{errorResponse.StatusCode}");
                    }
                }
            }

        }
        public List<string> GetAllLinks(String strURL)
        {

            string currentURL = strURL; 
            List<string> LinksList = new List<string>();
            IList<IWebElement> LinkElements = driver.FindElements(By.TagName("a"));

            foreach (IWebElement item in LinkElements)
            {

                string getURL = item.GetAttribute("href");
                try
                {
                    if (getURL !=null && getURL.StartsWith(currentURL))
                    {
                        LinksList.Add(getURL);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return LinksList;

        }
        public string GetHttpStatus(string url)
        {
            try
            {
                HttpWebRequest webReq;
                webReq = (HttpWebRequest)WebRequest.Create(url);
                webReq.UseDefaultCredentials = true;
                webReq.UserAgent = "Link Checker";
                webReq.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)webReq.GetResponse();
                return response.StatusCode.ToString();

            }

            catch (Exception e)
            {
                return e.Message;
            }

        }

        public static void InitiateSSLTrust()
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback =
                    new RemoteCertificateValidationCallback(
                        delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
                        {
                            return true;
                        });
            }
            catch (Exception)
            {
            }
        }

        public void CheckAllURLS(List<string> arrFoundLinks)
        {
            
            arrFoundLinks.ForEach(url =>
            {
                var UrlStatus = GetHttpStatus(url).ToString();

                if (UrlStatus == "OK")
                {

                    System.Diagnostics.Debug.WriteLine(url + " Status : " + UrlStatus + "--->>>> Link is valid");
                    createLog(url + " Status : " + UrlStatus + "--->>>> Link is valid");
                }
                else
                {

                    System.Diagnostics.Debug.WriteLine(url + " Status : " + UrlStatus + "--->>>> Link is not valid");
                    createLog(url + " Status : " + UrlStatus + "--->>>> Link is not valid");
                }

            }
            );

        }
        public void createLog(String strLoginfo)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "TestLog.txt"; 
            // This text is added only once to the file.
            if (System.IO.File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Append))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(Environment.NewLine);
                    sw.Write("===============================");
                    sw.Write(Environment.NewLine);
                    sw.Write(strLoginfo);
                    sw.Close();
                }
            }
            else
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(Environment.NewLine);
                    sw.Write(strLoginfo);
                    sw.Close();
                }
            }


        }
        public HttpStatusCode GetHeaders(string url)
        {
            HttpStatusCode result = default(HttpStatusCode);

            var request = HttpWebRequest.Create(url);
            request.Method = "HEAD";
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                if (response != null)
                {
                    result = response.StatusCode;
                    response.Close();
                }
            }

            return result;
        }

        public void MouseHover(String strElement)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(strElement)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void MouseHoverbyXPath(String strElement)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(strElement)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void MouseOverSubMenu(String strXPath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //Instantiate Action Class        
            Actions actions = new Actions(driver);
            //Retrieve WebElement 'Music' to perform mouse hover 
            WebElement menuOption = (WebElement)driver.FindElement(By.XPath(strXPath));
            //Mouse hover menuOption 'Music'
            actions.MoveToElement(menuOption).Perform();
            
        }
        public void HoverAndClick(WebElement elementToHover, WebElement elementToClick)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(elementToHover).Click(elementToClick).Build().Perform();
        }


    }
}