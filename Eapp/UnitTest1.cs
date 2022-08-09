using Eapp.Login_step;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Eapp
{
    public class Tests

    {     
        //open the browser
        //instantiation of driver
       public static IWebDriver driver = null;
       
        //hooks in nunit
        [SetUp]
        public void Setup()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
        }

        [Test]
        public void Test1()
        {
            //All instances
            Login loginpage = new Login(driver);
            //Identifiers 
            //h2[normalize-space()='Login.']
            By logintitle = By.XPath("//h2[normalize-space()='Login.']");
            //navigate to site
            driver.Navigate().GoToUrl("http://eaapp.somee.com/Account/Login");
            driver.Manage().Window.Maximize();
            loginpage.HandleLogin();
            Assert.That(driver.FindElement(logintitle).Displayed, Is.True) ;
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}