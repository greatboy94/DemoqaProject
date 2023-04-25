using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class RadioButton : Elements
    {
        [FindsBy(How = How.XPath, Using = "//label[@for='yesRadio']")]
        public IWebElement yesRadio;
        
        [FindsBy(How = How.XPath, Using = "//label[@for='impressiveRadio']")]
        public IWebElement impressiveRadio;
        
        [FindsBy(How = How.XPath, Using = "//input[@id='noRadio']")]
        public IWebElement noRadio;

        [FindsBy(How = How.ClassName, Using = "mt-3")]
        public IWebElement checkState;
        
        public void CheckYesRadio()=>yesRadio.Click();

        public void CheckImpressiveRadio()=>impressiveRadio.Click();

        public RadioButton(IWebDriver driver) : base(driver)
        {
        }
    }
}

