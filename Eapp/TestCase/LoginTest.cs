using Eapp.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using Eapp.PageObjects;
using System.Threading;

namespace Eapp.TestCase

{
    public class LoginTest:BaseDriver

    {
        

        [Test]
        public void Test1()
        {
            //All instances
            Login loginpage = new Login(driver);
            //Identifiers 
            //open the browser
            By logintitle = By.XPath("//h2[normalize-space()='Login.']");
            //navigate to site
            driver.Url = baseurl;
            //driver.Manage().Window.Maximize();
            loginpage.HandleLogin("mahmudur000","mahmudur@000");
            Thread.Sleep(5000);
            Assert.That(driver.FindElement(logintitle).Displayed, Is.True) ;
        }

       
    }
}