using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace DemoqaProject.PageObjects
{
    public class DynamicProperties : Elements
    {
        [FindsBy(How = How.Id, Using = "enableAfter")]
        public IWebElement enableButton;
        
        [FindsBy(How = How.XPath, Using = "//p[text()='This text has random Id']")]
        public IWebElement randomIDButton;

        public void EnableButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement searchResult = wait.Until(ExpectedConditions.ElementToBeClickable(enableButton));
            searchResult.Click();
        }

        public string RandomID()
        {
            string a=randomIDButton.GetAttribute("id");
            Console.WriteLine("Expected Result: "+a);
            return a;
        }
    }
}