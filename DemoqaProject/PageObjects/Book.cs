using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Book
    {
        public Book()
            {
                PageFactory.InitElements(Driver.driver, this);
            }
        
            [FindsBy(How = How.ClassName, Using = "main-header")]
            public IWebElement BookText { get; set; }
    }
}