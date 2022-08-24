using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Interactions : BaseSeleniumPage
    {
       
        public Interactions()
        { 
            PageFactory.InitElements(driver, this);
        }
    }
}