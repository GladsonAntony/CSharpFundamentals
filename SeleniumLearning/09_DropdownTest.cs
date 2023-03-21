using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SeleniumLearning
{
    public class DropdownTest
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
        public void TestDropdowns()
        {
            IWebElement username2 = driver.FindElement(By.Id("username"));
            username2.SendKeys("Gladson Antony");
            IWebElement password2 = driver.FindElement(By.Name("password"));
            password2.SendKeys("Password");
            IWebElement radiobuttonAdmin = driver.FindElement(By.XPath("//div[@class='form-check-inline']//label[1]//span[2]"));
            IWebElement radiobuttonUser = driver.FindElement(By.XPath("//div[@class='form-check-inline']//label[1]//span[2]"));
            radiobuttonAdmin.Click();
            IWebElement dropdownMenu = driver.FindElement(By.CssSelector("select[class='form-control']"));
            SelectElement selectElement = new SelectElement(dropdownMenu);
            selectElement.SelectByText("Teacher");
            Thread.Sleep(1000);
            TestContext.WriteLine("Current Selected Option -> " + selectElement.SelectedOption.Text);
            selectElement.SelectByIndex(2);
            Thread.Sleep(1000);
            TestContext.WriteLine("Current Selected Option -> " + selectElement.SelectedOption.Text);
            selectElement.SelectByValue("stud");
            Thread.Sleep(1000);
            TestContext.WriteLine("Current Selected Option -> " + selectElement.SelectedOption.Text);
            IWebElement checkbox1 = driver.FindElement(By.CssSelector("#terms"));
            checkbox1.Click();
            IWebElement signInButton = driver.FindElement(By.CssSelector("#signInBtn"));
            signInButton.Click();
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Quit();
        }
    }
}
