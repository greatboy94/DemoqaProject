using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class ButtonsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckDoubleClick()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Buttons buttons = new Buttons();
            buttons.NavigateToButtons();
            
            Thread.Sleep(2000);
            buttons.PerformDoubleClick();
            Assert.AreEqual(buttons.expectedDoubleClick, buttons.doubleClickText.Text);
        }
        
        [Test]
        public void CheckRightClick()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Buttons buttons = new Buttons();
            buttons.NavigateToButtons();

            Thread.Sleep(2000);
            buttons.PerformRightClick();
            Assert.AreEqual(buttons.expectedRightClick, buttons.rightClickText.Text);
        }
        
        [Test]
        public void CheckClick()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Buttons buttons = new Buttons();
            buttons.NavigateToButtons();

            Thread.Sleep(2000);
            buttons.PerformClick();
            Assert.AreEqual(buttons.expectedClick, buttons.ClickMeText.Text);
        }
    }    
}

