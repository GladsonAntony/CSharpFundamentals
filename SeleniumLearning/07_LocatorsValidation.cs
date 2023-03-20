using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SeleniumLearning
{
    public class LocatorsValidation
    {
        private IWebDriver driver;

        
        [SetUp]
        public void SetupBrowser()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.rahulshettyacademy.com/loginpagePractise/";
            TestContext.WriteLine("Page Title -> "+driver.Title);
        }

        [Test]
        public void TestLocatorsValidation01()
        {
            IWebElement username2 = driver.FindElement(By.Id("username"));
            username2.SendKeys("Gladson Antony");
            Thread.Sleep(500);
            IWebElement password2 = driver.FindElement(By.Name("password"));
            password2.SendKeys("Password");
            Thread.Sleep(500);
            IWebElement checkbox1 = driver.FindElement(By.CssSelector("#terms"));
            checkbox1.Click();
            Thread.Sleep(500);
            IWebElement signInButton = driver.FindElement(By.CssSelector("#signInBtn"));
            signInButton.Click();
            Thread.Sleep(3000);
            IWebElement errorMessage = driver.FindElement(By.XPath("//strong[normalize-space()='Incorrect']"));
            String messageToPrint = errorMessage.Text;
            TestContext.WriteLine("Error Message Received -> "+messageToPrint);
        }

        [Test]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Assertion", "NUnit2005:Consider using Assert.That(actual, Is.EqualTo(expected)) instead of Assert.AreEqual(expected, actual)", Justification = "<Pending>")]
        public void TestLocatorsValidation02() 
        {
            IWebElement blinkingMessage = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));
            TestContext.WriteLine(blinkingMessage.Text);            ;
            Assert.AreEqual("https://rahulshettyacademy.com/documents-request", (blinkingMessage.GetAttribute("href")));
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
