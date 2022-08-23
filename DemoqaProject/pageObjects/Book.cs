using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Book : BaseSeleniumPage
    {

        public Book()
        { 
            PageFactory.InitElements(driver, this);
        }
    }
}