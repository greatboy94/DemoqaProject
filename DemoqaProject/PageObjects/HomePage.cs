using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
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
    }
}