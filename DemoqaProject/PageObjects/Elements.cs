using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Elements : BaseSeleniumPage
    {
        public Elements()
        {
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.ClassName, Using = "main-header")]
        public IWebElement elementsText { get; set; }

        public String GetHeaderText()
        {
            return elementsText.Text;
        }

    }
}