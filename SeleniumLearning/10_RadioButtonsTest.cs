using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumLearning
{
    public class RadioButtonsTest
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
        public void RadioButtonsExample()
        {
            IWebElement username2 = driver.FindElement(By.Id("username"));
            username2.SendKeys("Gladson Antony");
            IWebElement password2 = driver.FindElement(By.Name("password"));
            password2.SendKeys("Password");

            IList<IWebElement> radioButtons = driver.FindElements(By.XPath("//input[@type='radio']"));

            foreach (IWebElement radioButton in radioButtons)
            {
                if (radioButton.GetAttribute("value").Equals("user"))
                {
                    radioButton.Click();
                }
            }
            
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id("okayBtn")));
            driver.FindElement(By.Id("okayBtn")).Click();
            Boolean result = driver.FindElement(By.Id("usertype")).Selected;
            Assert.That(result, Is.True);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Quit();
        }

    }
}
