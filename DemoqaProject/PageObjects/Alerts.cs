using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqaProject.PageObjects
{
    public class Alerts
    {
        private By alertsText = By.ClassName("main-header");
        private By alertsButton=By.XPath("//h5[text()='Alerts, Frame & Windows']");

        public void ValidatePage(IWebDriver driver)
        {
            driver.FindElement(alertsButton).Click();
            string store = driver.FindElement(alertsText).Text;
            Assert.AreEqual("Alerts, Frame & Windows",store, "I am in the Alert page");
            Thread.Sleep(2000);
            driver.Navigate().Back();
        }
    }
}