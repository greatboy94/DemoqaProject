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

        public void EnableButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement searchResult = wait.Until(ExpectedConditions.ElementToBeClickable(enableButton));
            searchResult.Click();
        }
    }
}