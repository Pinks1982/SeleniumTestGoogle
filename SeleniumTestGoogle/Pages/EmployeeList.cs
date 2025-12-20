using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestGoogle.Pages
{
    internal class EmployeeList
    {

        private IWebDriver _driver;        

        public EmployeeList(IWebDriver driver)
        {
            this._driver = driver;
        }
      
        public void CreateEmpList()
        {

            IWebElement LinkEmp = _driver.FindElement(By.LinkText("Employee List"));
            LinkEmp.Click();
            var btnCreateNew = _driver.FindElement(By.CssSelector(".btn"));
            btnCreateNew.Click();
            var txtName = _driver.FindElement(By.Id("Name"));
            txtName.SendKeys("TestEmp22");
            var txtSalary = _driver.FindElement(By.Id("Salary"));
            txtSalary.SendKeys("10000");
            var WorkDuration = _driver.FindElement(By.Name("DurationWorked"));
            WorkDuration.SendKeys("24");
            //SelectElement selectElement = new SelectElement(_driver.FindElement(By.Id("Grade"))) ;
            //selectElement.
        }
        
    }
}
