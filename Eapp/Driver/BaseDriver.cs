using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eapp.Driver
{
    public class BaseDriver
    {
        public static IWebDriver driver = null;
        public string baseurl = "http://eaapp.somee.com/Account/Login";

        [SetUp]
        public void startBrowser()
        {
            if(driver == null)
            {
                driver = new ChromeDriver();
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }
     

        [TearDown]
        public void closeBrowser()
        {
           driver.Quit();
        }
    }
}
