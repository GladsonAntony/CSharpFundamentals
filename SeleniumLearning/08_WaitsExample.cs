using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace SeleniumLearning
{
    public class WaitsExample
    {
        public IWebDriver driver;        

        [SetUp]
        public void SetupBrowser()
        {
            driver = new EdgeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.rahulshettyacademy.com/loginpagePractise/";
            TestContext.WriteLine("Page Title -> " + driver.Title);            
        }

        [Test]
        public void TestWaits()
        {
            IWebElement username2 = driver.FindElement(By.Id("username"));
            username2.SendKeys("Gladson Antony");
            IWebElement password2 = driver.FindElement(By.Name("password"));
            password2.SendKeys("Password");
            IWebElement checkbox1 = driver.FindElement(By.CssSelector("#terms"));
            checkbox1.Click();
            IWebElement signInButton = driver.FindElement(By.CssSelector("#signInBtn"));
            signInButton.Click();
            TestContext.WriteLine("Value on Clicking Sign In Button -> " + signInButton.GetAttribute("value"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions
                .TextToBePresentInElementValue(driver.FindElement(By.XPath("//input[@id='signInBtn']")),"Sign In"));
            TestContext.WriteLine("Value after Waiting -> " + signInButton.GetAttribute("value"));
        }

        [TearDown]
        public void TearDownBrowser() 
        {
            driver.Quit();
        }
    }
}
