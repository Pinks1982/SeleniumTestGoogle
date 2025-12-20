using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemo
{
    public class LoginPage
        {        

        public void Login(IWebDriver driver,string username, string password)
        {
            driver.FindElement(By.Id("user-name")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

        }
       
    }
}
