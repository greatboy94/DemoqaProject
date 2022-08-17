using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Elements
    {
        public Elements()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //public static By elementsGetText = By.XPath("main-header");
        

        [FindsBy(How = How.ClassName, Using = "main-header")]
        public IWebElement elementsText { get; set; }

        // string store = driver.FindElement(elementText).Text;
        //     Assert.AreEqual("Elements",store, "I am in the Elements page");
        //     Thread.Sleep(2000);
        //     driver.Navigate().Back();

    }
}