using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Alerts
    {
        public class Forms
        {
            public Forms()
            {
                PageFactory.InitElements(Driver.driver, this);
            }
        
            [FindsBy(How = How.ClassName, Using = "main-header")]
            public IWebElement AlertsText { get; set; }
            
        }
    }
}