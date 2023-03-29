using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace SeleniumLearning
{
    public class WindowHandlesExample
    {
        IWebDriver driver;

        [SetUp]
        public void SetupBrowser()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise";
            TestContext.WriteLine("Page Title -> " + driver.Title);
        }

        [Test]
        public void WindowHandlesDemo()
        {
            String ParentWindowID = driver.CurrentWindowHandle;
            IWebElement BlinkingText = driver.FindElement(By.ClassName("blinkingText"));
            BlinkingText.Click();  
            Assert.AreEqual(2,driver.WindowHandles.Count);
            String ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            TestContext.WriteLine("Page Title after Clicking on the Hyperlink --> " + driver.FindElement(By.TagName("h1")).Text);
            IWebElement NewPageItem = driver.FindElement(By.XPath("//p[@class='im-para red']"));
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[@class='im-para red']")));

            String ToParseText = NewPageItem.Text;
            TestContext.WriteLine($"{ToParseText}");

            String[] ParsedText = ToParseText.Split(" ");

            TestContext.WriteLine("To Print the values in the String Array one by one");
            foreach (String s in ParsedText)
            {
                TestContext.WriteLine(s);                
            }

            Assert.AreEqual("mentor@rahulshettyacademy.com", ParsedText[4]);
            driver.Close();
            driver.SwitchTo().Window(ParentWindowID);
            TestContext.WriteLine("Page Title -> " + driver.Title);
        }

        [TearDown]
        public void TeardownBrowser()
        {
            driver.Quit();
        }
    }
}
