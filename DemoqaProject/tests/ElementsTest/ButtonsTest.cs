using DemoqaProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqaProject
{
    public class ButtonsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckDoubleClick(IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            Buttons buttons = new Buttons(driver);
            buttons.NavigateToButtons();
            
            buttons.WaitLoadPage();
            buttons.PerformDoubleClick();
            Assert.AreEqual(buttons.expectedDoubleClick, buttons.doubleClickText.Text);
        }
        
        [Test]
        public void CheckRightClick(IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            Buttons buttons = new Buttons(driver);
            buttons.NavigateToButtons();

            buttons.WaitLoadPage();
            buttons.PerformRightClick();
            Assert.AreEqual(buttons.expectedRightClick, buttons.rightClickText.Text);
        }
        
        [Test]
        public void CheckClick(IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            Buttons buttons = new Buttons(driver);
            buttons.NavigateToButtons();

            buttons.WaitLoadPage();
            buttons.PerformClick();
            Assert.AreEqual(buttons.expectedClick, buttons.ClickMeText.Text);
        }
    }    
}

