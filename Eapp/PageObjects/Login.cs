using Eapp.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eapp.PageObjects
{
    
    public class Login:Common
    {
        IWebDriver driver = null;
        /************
         * Identifiers
         */
        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Pom model
       
        By inputUsername = By.Id("UserName");
        By inputUserPass = By.Id("Password");
        By Loginbutton = By.CssSelector("input[value='Log in']");

        public void HandleLogin(string name, string pass)
        {
            sendText(driver.FindElement(inputUsername), name);
            sendText(driver.FindElement(inputUserPass), pass);
           driver.FindElement(Loginbutton).Click();
        }


    }
}
