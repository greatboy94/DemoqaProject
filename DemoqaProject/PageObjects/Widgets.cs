using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Widgets
    {
        public Widgets()
        { 
            PageFactory.InitElements(Driver.driver, this);
        }
        
        [FindsBy(How = How.ClassName, Using = "main-header")] 
        public IWebElement WidgetsText { get; set; }
    }
}