using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class DynamicProperties : Elements
    {
        [FindsBy(How = How.Id, Using = "enableAfter")]
        public IWebElement enableButton;
        
        [FindsBy(How = How.XPath, Using = "//p[text()='This text has random Id']")]
        public IWebElement randomIDButton;
        
        [FindsBy(How = How.XPath, Using = "//button[@class='mt-4 text-danger btn btn-primary']")]
        public IWebElement colorChangeButton;

        [FindsBy(How = How.Id, Using = "visibleAfter")]
        public IWebElement visibleAfterButton;
        
        
        public void EnableButton()
        {
            WaitElement(enableButton);
            enableButton.Click();
        }

        public string RandomID()
        {
            string a=randomIDButton.GetAttribute("id");
            Console.WriteLine("Expected Result: " + a);
            driver.Navigate().Refresh();
            return a;
        }

        public void ColorButton()
        {
            WaitElement(colorChangeButton);
            colorChangeButton.Click();
        }

        public void VisibleButton()
        {
            WaitElement(visibleAfterButton);
            visibleAfterButton.Click();
        }
    }
}