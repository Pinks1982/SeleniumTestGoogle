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
    public class AddToCartPage
    {

        public void AddToCart(IWebDriver driver)
        {
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
        }
    }
}
