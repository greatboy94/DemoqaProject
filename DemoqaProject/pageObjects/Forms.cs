using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Forms : BaseSeleniumPage
    {
        
        public Forms()
        {
            PageFactory.InitElements(driver, this);
        }
    }
}