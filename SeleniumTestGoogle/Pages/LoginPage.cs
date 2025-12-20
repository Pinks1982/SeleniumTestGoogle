using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestGoogle.Pages
{
       public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement LnkLogin => driver.FindElement(By.Id("LoginLink"));
        IWebElement txtUser => driver.FindElement(By.Id("username"));
        IWebElement txtPwd => driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => driver.FindElement(By.CssSelector(".btn"));

        public void ClickLogin()
        {
            LnkLogin.Click();
        }
        public void login(string username, string password)
        {
            txtUser.SendKeys(username);
            txtPwd.SendKeys(password);
            btnLogin.Submit();
        }

    }
    

}
