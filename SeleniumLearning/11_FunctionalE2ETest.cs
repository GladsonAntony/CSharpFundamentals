using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumLearning
{
    public class FunctionalE2ETest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupBrowser()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise";
            TestContext.WriteLine("Page Title -> " + driver.Title);
        }

        [Test]
        public void EndToEndFlowTest()
        {
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("learning");
            driver.FindElement(By.CssSelector("#terms")).Click();
            driver.FindElement(By.CssSelector("#signInBtn")).Click();
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[normalize-space()='ProtoCommerce']")));
            TestContext.WriteLine("Page after Login -> " + driver.Title);
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText("Checkout")));

            String[] expectedProducts = { "iphone X", "Samsung Note 8" };

            TestContext.WriteLine("Products available in the Page..");
            IList<IWebElement> products = driver.FindElements(By.TagName("app-card"));

            foreach (IWebElement product in products) 
            {
                TestContext.WriteLine(product.FindElement(By.CssSelector(".card-title a")).Text);
                if (expectedProducts.Contains(product.FindElement(By.CssSelector(".card-title a")).Text))
                {
                    product.FindElement(By.CssSelector(".card-footer button")).Click();
                }
            }

            driver.FindElement(By.XPath("//a[@class='nav-link btn btn-primary']")).Click();
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[normalize-space()='Checkout']")));
            driver.FindElement(By.XPath("//button[normalize-space()='Checkout']")).Click();
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[value='Purchase']")));
            driver.FindElement(By.CssSelector("input[value='Purchase']")).Click();            
        }

        [TearDown]
        public void TeardownBrowser() 
        { 
            driver.Quit();
        }

    }
}
