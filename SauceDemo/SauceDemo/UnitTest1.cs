using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace SauceDemo
{
    
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Login()
        {
            LoginPage login = new LoginPage();
            string username = "standard_user";
            string password = "secret_sauce";
            login.Login(driver, username, password);


            AddToCartPage cart = new AddToCartPage();
            cart.AddToCart(driver);


            Checkoutpage check = new Checkoutpage();
            check.checkout(driver);
            driver.Manage().Window.FullScreen();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Assert.Pass();
        }
             
       

        [TearDown]
        public void TearDown() 
        {
            driver.Dispose();
        }
       
    }
}