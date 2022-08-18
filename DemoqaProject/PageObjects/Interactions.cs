using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Interactions
    {
            public Interactions()
            {
                PageFactory.InitElements(Driver.driver, this);
            }
        
            [FindsBy(How = How.ClassName, Using = "main-header")]
            public IWebElement InteractionsText { get; set; }
    }
}