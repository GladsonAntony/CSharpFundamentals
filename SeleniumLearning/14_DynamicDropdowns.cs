using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumLearning
{
    public class DynamicDropdowns
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void SetupBrowser()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";            
        }

        [Test]
        public void TestDynamicDropdown()
        {
            TestContext.WriteLine("Title of the Page --> " + driver.Title);
            IWebElement autosuggestionBox = driver.FindElement(By.Id("autocomplete"));
            autosuggestionBox.SendKeys("In");
            Thread.Sleep(2000);
            IList<IWebElement> autoSuggestionItems = driver.FindElements(By.XPath("//ul[@id='ui-id-1']/li/div"));
            TestContext.WriteLine("\n\nList of Items present in the Auto Suggestion");
            foreach (var autoSuggestionItem in autoSuggestionItems)
            {
                TestContext.WriteLine(autoSuggestionItem.Text);
            }
            autosuggestionBox.Clear();
        }

        [Test]
        public void TestSelectionFromDynamicDropdown()
        {
            TestContext.WriteLine("Title of the Page --> " + driver.Title);
            IWebElement autosuggestionBox = driver.FindElement(By.Id("autocomplete"));
            autosuggestionBox.SendKeys("Ind");
            Thread.Sleep(2000);
            IList<IWebElement> autoSuggestionItems = driver.FindElements(By.XPath("//ul[@id='ui-id-1']/li/div"));
            foreach (var autoSuggestionItem in autoSuggestionItems)
            {
                if(autoSuggestionItem.Text.Equals("India"))
                {
                    TestContext.WriteLine("Found the Necessary Value " + autoSuggestionItem.Text);
                    autoSuggestionItem.Click();
                }
            }
            TestContext.WriteLine("Selected Value is "+autosuggestionBox.GetAttribute("value"));
            Thread.Sleep(2000);
            autosuggestionBox.Clear();
        }


        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
