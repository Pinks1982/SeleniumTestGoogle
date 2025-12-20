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
    public class Checkoutpage
    {
        public void checkout(IWebDriver driver)
        {
            driver.FindElement(By.ClassName("shopping_cart_link")).Click();
            driver.FindElement(By.Id("checkout")).Click();
            driver.FindElement(By.Name("firstName")).SendKeys("Pinky");
            driver.FindElement(By.Name("lastName")).SendKeys("Chaudhary");
            driver.FindElement(By.Name("postalCode")).SendKeys("34787");
            driver.FindElement(By.Name("continue")).Click();

        }
    }
}
