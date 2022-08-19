using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Interactions : BaseSeleniumPage
    {
        
        [FindsBy(How = How.ClassName, Using = "main-header")]
        public IWebElement InteractionsText { get; set; }

        public Interactions()
        { 
            PageFactory.InitElements(driver, this);
        }
        
        public String GetHeaderText()
        { 
            return InteractionsText.Text;
        }
    }
}