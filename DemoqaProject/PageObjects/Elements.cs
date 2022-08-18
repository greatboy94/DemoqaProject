using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Elements
    {
        public Elements()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.ClassName, Using = "main-header")]
        public IWebElement elementsText { get; set; }

    }
}