using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqaProject.PageObjects
{
    public class Book
    {
        private By bookText = By.ClassName("main-header");
        //private By bookButton=By.XPath("//h5[text()='Book Store Application']");

        public void ValidatePage(IWebDriver driver)
        {
            IJavaScriptExecutor js=driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,950);");
            
            //driver.FindElement(bookButton).Click();
            string store = driver.FindElement(bookText).Text;
            Assert.AreEqual("Book Store",store, "I am in the Book Store page");
            Thread.Sleep(2000);
            driver.Navigate().Back();
        }
    }
}