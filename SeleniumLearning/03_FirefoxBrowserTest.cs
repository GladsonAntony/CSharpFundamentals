using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumLearning
{
    public class FirefoxBrowserTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupFirefoxBrowser()
        {            
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestFirefoxBrowser()
        {
            driver.Url = "https://courses.rahulshettyacademy.com/";
            Thread.Sleep(5000);
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
