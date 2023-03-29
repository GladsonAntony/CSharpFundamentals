using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning
{
    public class FramesExample
    {
        IWebDriver driver;

        [SetUp]
        public void SetupBrowser()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            TestContext.WriteLine("Page Tile --> " + driver.Title);
        }

        [Test]
        public void FramesInteractionDemo()
        {
            IWebElement framesIdentifier = driver.FindElement(By.Id("courses-iframe"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", framesIdentifier);
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(framesIdentifier);
            driver.FindElement(By.XPath("(//nav[@class='main-menu']/div/ul/li/a)[3]")).Click();
            Thread.Sleep(2000);
            TestContext.WriteLine(driver.FindElement(By.TagName("h1")).Text);
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            TestContext.WriteLine(driver.FindElement(By.TagName("h1")).Text);
        }


        [TearDown]
        public void TeardownBrowser() 
        {
            driver.Close();
        }

    }
}
