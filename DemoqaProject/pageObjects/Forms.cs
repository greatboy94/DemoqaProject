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
        
        [FindsBy(How = How.ClassName, Using = "main-header")]
        public IWebElement FormsText { get; set; }
        
        public String GetHeaderText()
        {
            return FormsText.Text;
        }
        
    }
}