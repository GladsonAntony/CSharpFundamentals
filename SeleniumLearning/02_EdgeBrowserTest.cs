using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class EdgeBrowserTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupEdgeBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();                        
        }

        [Test]
        public void TestEdgeBrowser() 
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com/";
            string pageTitle = driver.Title.ToString();
            Assert.That (pageTitle, Is.EqualTo("Google"));
            Thread.Sleep(5000);
        }

        [TearDown]
        public void CloseBrowser() 
        { 
            driver.Close();
            driver.Quit();
        }
    }
}