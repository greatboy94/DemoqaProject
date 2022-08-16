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
        
        [FindsBy(How = How.XPath, Using = "//h5[text()='Elements']")]
        public IWebElement elementButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//h5[text()='Forms']")]
        public IWebElement formsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//h5[text()='Alerts, Frame & Windows']")]
        public IWebElement alertsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//h5[text()='Widgets']")]
        public IWebElement widgetsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//h5[text()='Interactions']")]
        public IWebElement interactionButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//h5[text()='Book Store Application']")]
        public IWebElement bookButton { get; set; }
    }
}