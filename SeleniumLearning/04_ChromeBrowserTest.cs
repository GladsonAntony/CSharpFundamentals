using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumLearning
{
    public class ChromeBrowserTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupChromeBrowser()
        {            
            driver = new ChromeDriver();            
        }

        [Test]
        public void TestChromeBrowser()
        {
            driver.Manage().Window.Maximize();
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
