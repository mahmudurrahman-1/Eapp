using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eapp.Login_step
{
    
    public class Login
    {
        IWebDriver driver = null;
        
        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }
        /************
* Identifiers
*/
        By inputUsername = By.Id("UserName");
        By inputUserPass = By.Id("Password");
        By Loginbutton = By.CssSelector("input[value='Log in']");


        public void HandleLogin()
        {
            driver.FindElement(inputUsername).SendKeys("mahmudur.sqa");
            driver.FindElement(inputUserPass).SendKeys("Password");
            driver.FindElement(Loginbutton).Click();
        }


    }
}
