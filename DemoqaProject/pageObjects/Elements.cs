using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Elements : BaseSeleniumPage
    {
        
        [FindsBy(How = How.ClassName, Using = "main-header")]
        public IWebElement ElementsText { get; set; }
        
        public Elements()
        {
            PageFactory.InitElements(driver, this);
        }
        
        public String GetHeaderText()
        {
            return ElementsText.Text;
        }

    }
}