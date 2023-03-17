using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class EdgeIEBrowserTest
    {
        public IWebDriver driver;
        public InternetExplorerOptions ieOptions;

        [SetUp]
        public void SetupEdgeIEBrowser()
        {
            ieOptions = new InternetExplorerOptions
            {
                IgnoreZoomLevel = true,
                AttachToEdgeChrome = true,
                EdgeExecutablePath = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe"                
            };
            driver = new InternetExplorerDriver(ieOptions);            
        }

        [Test]
        [Ignore ("Ignore this Test")]
        public void TestEdgeIEMode()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.co.in/";
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
