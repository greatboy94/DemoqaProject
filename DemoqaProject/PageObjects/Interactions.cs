using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqaProject.PageObjects
{
    public class Interactions
    {
        private By interactionsText = By.ClassName("main-header");
        private By interactionsButton=By.XPath("//h5[text()='Interactions']");

        public void ValidatePage(IWebDriver driver)
        {
            driver.FindElement(interactionsButton).Click();
            string store = driver.FindElement(interactionsText).Text;
            Assert.AreEqual("Interactions",store, "I am in the Interactions page");
            Thread.Sleep(2000);
            driver.Navigate().Back();
        }
    }
}