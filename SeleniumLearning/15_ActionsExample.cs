using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning
{
    public class ActionsExample
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void SetupBrowser()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
        }

        [Test]
        public void MouseHoverDemo()
        {
            driver.Url = "https://rahulshettyacademy.com/";
            TestContext.WriteLine("Page Title -> " + driver.Title);
            Actions action = new Actions(driver);
            IWebElement menu = driver.FindElement(By.CssSelector("div[class='nav-outer clearfix'] a[class='dropdown-toggle']"));
            IWebElement AboutUs = driver.FindElement(By.XPath("//ul[@class='dropdown-menu']/li/a[contains(text(),'About us')]"));
            //IWebElement PartTimeJob = driver.FindElement(By.XPath("//ul[@class='dropdown-menu']/li/a[contains(text(),'Part time jobs')]"));
            //IWebElement Contact = driver.FindElement(By.XPath("//ul[@class='dropdown-menu']/li/a[contains(text(),'Contact')]"));
            action.MoveToElement(menu).Build().Perform();            
            AboutUs.Click();
            TestContext.WriteLine("Page Title -> " + driver.Title);
            driver.Navigate().Back();
            TestContext.WriteLine("Page Title -> " + driver.Title);
            //Thread.Sleep(3000);            
            //action.MoveToElement(menu).Build().Perform();
            //PartTimeJob.Click();
            //TestContext.WriteLine("Page Title -> " + driver.Title);
            //driver.Navigate().Back();
            //Thread.Sleep(3000);            
            //action.MoveToElement(menu).Build().Perform();
            //Contact.Click();
            //TestContext.WriteLine("Page Title -> " + driver.Title);
            //driver.Navigate().Back();
        }

        [Test]
        public void DragAndDropDemo()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/droppable");
            TestContext.WriteLine("Page Title -> " + driver.Title);
            Actions action1 = new Actions(driver);
            IWebElement SourceElement = driver.FindElement(By.Id("draggable"));
            IWebElement Destination = driver.FindElement(By.Id("droppable"));
            action1.DragAndDrop(SourceElement, Destination).Build().Perform();
            Thread.Sleep(2000);
        }

        [OneTimeTearDown]
        public void TeardownBrowser()
        {
            driver.Close();
        }
    }
}
