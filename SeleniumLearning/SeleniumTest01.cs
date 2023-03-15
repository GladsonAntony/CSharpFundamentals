using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class SeleniumTest01
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();            
        }

        [Test]
        public void Test01() 
        {
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