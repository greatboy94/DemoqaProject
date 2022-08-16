using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqaProject.PageObjects
{
    public class Widgets
    {
        private By widgetText = By.ClassName("main-header");
        //private By widgetsButton=By.XPath("//h5[text()='Widgets']");

        public void ValidatePage(IWebDriver driver)
        {
            //driver.FindElement(widgetsButton).Click();
            string store = driver.FindElement(widgetText).Text;
            Assert.AreEqual("Widgets",store, "I am in the Widgets page");
            Thread.Sleep(2000);
            driver.Navigate().Back();
        }
    }
}