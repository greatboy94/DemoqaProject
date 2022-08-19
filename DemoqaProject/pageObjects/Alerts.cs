using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Alerts : BaseSeleniumPage
    {
        
        [FindsBy(How = How.ClassName, Using = "main-header")]
        public IWebElement AlertsText { get; set; }
        
        public Alerts() 
        { 
            PageFactory.InitElements(driver, this);
        }

        public String GetHeaderText()
        { 
            return AlertsText.Text;
        }
    }
}