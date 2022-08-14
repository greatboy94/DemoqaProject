using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqaProject.PageObjects
{
    public class Forms
    {
        private By formsText = By.ClassName("main-header");
        private By formsButton=By.XPath("//h5[text()='Forms']");

        public void ValidatePage(IWebDriver driver)
        {
            driver.FindElement(formsButton).Click();
            string store = driver.FindElement(formsText).Text;
            Assert.AreEqual("Forms",store, "I am in the Forms page");
            Thread.Sleep(2000);
            driver.Navigate().Back();
        }
    }
}