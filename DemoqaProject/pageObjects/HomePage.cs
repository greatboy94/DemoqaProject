using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class HomePage : BaseSeleniumPage
    {
        public HomePage()
        {
            driver.Navigate().GoToUrl(Config.baseURL);
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][1]")]
        public IWebElement elementButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][2]")]
        public IWebElement formsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][3]")]
        public IWebElement alertsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][4]")]
        public IWebElement widgetsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][5]")]
        public IWebElement interactionButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][6]")]
        public IWebElement bookButton { get; set; }

        public Elements ClickElement()
        {
            elementButton.Click();
            return new Elements();
        }
        public Forms ClickForm()
        {
            formsButton.Click();
            return new Forms();
        }
        public Alerts ClickAlert()
        {
            alertsButton.Click();
            return new Alerts();
        }
        public Widgets ClickWidget()
        {
            widgetsButton.Click();
            return new Widgets();
        }
        public Interactions ClickInteraction()
        {
            interactionButton.Click();
            return new Interactions();
        }
        public Book ClickBook()
        {
            IJavaScriptExecutor js=driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,950);");
            bookButton.Click();
            return new Book();
        }
    }
}