using Eapp.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eapp.utils
{
    public class Common:BaseDriver
    {

        //Send values
        public static void sendText(IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
        //Select Items
        public void selectitem(IWebElement element, String value)
        {
            SelectElement selectText = new SelectElement(element);
            selectText.SelectByValue(value);
        }
        //Scroll to elements
        public void scrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        //Wait for pageload
        public void WaitForPageToLoad()
        {
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                wait.Until(driver =>((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
            }
            catch (Exception pageLoadWaitError)
            {
                throw new TimeoutException("Timeout during page load", pageLoadWaitError);
            }
        }



    }
}
