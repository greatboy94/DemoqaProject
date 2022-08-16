using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqaProject.PageObjects
{
    public class Elements
    {
        private By elementText = By.ClassName("main-header");
        //private By elementButton=By.XPath("//h5[text()='Elements']");

        public void ValidatePage(IWebDriver driver)
        {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            
            //driver.FindElement(elementButton).Click();
            string store = driver.FindElement(elementText).Text;
            Assert.AreEqual("Elements",store, "I am in the Elements page");
            Thread.Sleep(2000);
            driver.Navigate().Back();
        }
    }
}