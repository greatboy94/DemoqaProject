using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Widgets : BaseSeleniumPage
    {
        
        [FindsBy(How = How.ClassName, Using = "main-header")] 
        public IWebElement WidgetsText { get; set; }
        
        public Widgets()
        { 
            PageFactory.InitElements(driver, this);
        }
        
        public String GetHeaderText()
        { 
            return WidgetsText.Text;
        }
    }
}