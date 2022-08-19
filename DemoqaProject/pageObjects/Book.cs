using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Book : BaseSeleniumPage
    {
        
        [FindsBy(How = How.ClassName, Using = "main-header")]
        public IWebElement BookText { get; set; }

        public Book()
        { 
            PageFactory.InitElements(driver, this);
        }
        
        public String GetHeaderText()
        { 
            return BookText.Text;
        }
    }
}