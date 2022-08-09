using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Eapp
{
    public class Tests

    {
        //open the browser
        //instantiation of driver
        IWebDriver driver = new ChromeDriver();
        //hooks in nunit
        [SetUp]
        public void Setup()
        {
         
        }

        [Test]
        public void Test1()
        {
            
            //navigate to site
            driver.Navigate().GoToUrl("http://eaapp.somee.com/Account/Login");
            driver.Manage().Window.Maximize();
            Assert.Pass();
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}