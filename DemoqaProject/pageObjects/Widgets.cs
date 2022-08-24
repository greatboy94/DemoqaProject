using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Widgets : BaseSeleniumPage
    {

        public Widgets()
        { 
            PageFactory.InitElements(driver, this);
        }
    }
}