using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning
{
    public class AlertExample
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void SetupBrowser()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            TestContext.WriteLine("Title of the Page --> " + driver.Title);
        }

        [Test]
        public void TestAlerts1()
        {
            String Name = "Gladson Antony";
            IWebElement textBox = driver.FindElement(By.CssSelector("#name"));
            IWebElement button_Alert = driver.FindElement(By.Id("alertbtn"));
            IWebElement button_Confirm = driver.FindElement(By.Id("confirmbtn"));

            textBox.SendKeys(Name);
            button_Alert.Click();
            driver.SwitchTo().Alert();
            String AlertText = driver.SwitchTo().Alert().Text;
            TestContext.WriteLine("Alert Text -> " + AlertText);
            driver.SwitchTo().Alert().Accept();
            StringAssert.Contains(Name,AlertText);
            Thread.Sleep(2000);
        }

        [Test]
        public void TestAlerts2() 
        {
            String Name1 = "Gladson Antony";
            IWebElement textBox1 = driver.FindElement(By.CssSelector("#name"));
            IWebElement button_Alert1 = driver.FindElement(By.Id("alertbtn"));
            IWebElement button_Confirm1 = driver.FindElement(By.Id("confirmbtn"));

            textBox1.SendKeys(Name1);
            button_Confirm1.Click();
            String AlertText = driver.SwitchTo().Alert().Text;
            TestContext.WriteLine("Alert Text -> " + AlertText);
            driver.SwitchTo().Alert().Dismiss();
        }

        [OneTimeTearDown] 
        public void TearDown() 
        { 
            driver.Close();
        }


    }
}
