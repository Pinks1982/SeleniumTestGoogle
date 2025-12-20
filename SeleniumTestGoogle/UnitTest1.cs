using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using OpenQA.Selenium.Chrome;
using SeleniumTestGoogle.Pages;

namespace SeleniumTestGoogle
{
   
    [TestFixture("admin", "password")]

    public class Tests
    {
       private IWebDriver _driver;
        private readonly string userName;
        private readonly string password;

        public Tests(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Test]
        public void TestLocators()
        {

            //Simplest way of writing code but lenghty
            _driver.FindElement(By.Id("loginLink")).Click();
            //driver.FindElement(By.Name("UserName")).SendKeys("admin");
            //driver.FindElement(By.Name("Password")).SendKeys("password");

            //passing params userName and password using TestFixture below
            _driver.FindElement(By.Name("UserName")).SendKeys(userName);
            _driver.FindElement(By.Name("Password")).SendKeys(password);
            _driver.FindElement(By.CssSelector(".btn")).Submit();
            EmployeeList emp = new EmployeeList(_driver);
            emp.CreateEmpList();
            // _driver.Quit();
        }

       
        //[Test]
        //public void CustomCode()
        //{

        //    //using custom code
        //    Click(_driver, By.Id("loginLink"));
        //    EnterUsername(_driver, By.Name("UserName"), "admin");
        //    EnterPassword(_driver, By.Name("Password"), "password");
        //    submitDetails(_driver, By.CssSelector(".btn"));

        //}

        ////methods for Custom code example starts
        //public void Click(IWebDriver driver, By locator)
        //{
        //    driver.FindElement(locator).Click();
        //}
        //public void EnterUsername(IWebDriver driver, By username, string text)
        //{
        //    driver.FindElement(username).SendKeys(text);

        //}
        //public void EnterPassword(IWebDriver driver, By password, string text)
        //{
        //    driver.FindElement(password).SendKeys(text);

        //}

        //public void submitDetails(IWebDriver driver, By Locator)
        //{
        //    driver.FindElement(Locator).Submit();
        //}
        ////methods for Custom code example ends        

        //[Test]    
        ////[Category("smoke")]
        //public void TestWithPom()
        //{

        //    //using POM (Page Oriented Model)
        //    //initializing LoginPage
        //    LoginPage loginPage = new LoginPage(_driver);

        //    loginPage.ClickLogin();
        //    loginPage.login("admin", "password");
        //    //EmployeeList emplist = new EmployeeList(_driver);
        //    //emplist.CreateEmpList();
        //}



        //[Test]
        //[TestCase("Chrome","30")]
        //public void TestBrowserVersion(string browser, string version)
        //{
        //    Console.WriteLine($"The browser is {browser} with version {version}");

        //}



        [TearDown]
        public void TearDown()
        {

            _driver.Dispose();
        }
        
    }
}