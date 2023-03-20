using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SeleniumLearning
{
    public class LocatorsTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupBrowser()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.rahulshettyacademy.com/loginpagePractise/";
            TestContext.Progress.WriteLine(driver.Title);
        }

        [Test]
        public void TestLocators02()
        {
            IWebElement username2 = driver.FindElement(By.Id("username"));
            username2.SendKeys("rahulshettyacademy");            
            Thread.Sleep(500);
            IWebElement password2 = driver.FindElement(By.Name("password"));
            password2.SendKeys("learning");
            Thread.Sleep(500);
            IWebElement checkbox1 = driver.FindElement(By.CssSelector("#terms"));
            checkbox1.Click();
            Thread.Sleep(500);
            IWebElement signInButton = driver.FindElement(By.CssSelector("#signInBtn"));
            signInButton.Click();
            Thread.Sleep(5000);
        }
            

        [TearDown] 
        public void TearDown() 
        { 
            driver.Quit();
        }

    }
}
