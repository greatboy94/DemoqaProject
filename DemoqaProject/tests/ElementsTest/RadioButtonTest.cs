using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class RadioButtonTest : BaseSeleniumTest
    {
        [Test]
        public void ClickAndCheck()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            RadioButton radioButton = new RadioButton(driver);
            radioButton.NavigateToRadioButton();
            
            radioButton.CheckYesRadio();
            Assert.That(radioButton.checkState.Text, Does.Contain("Yes"));
            radioButton.CheckImpressiveRadio();
            Assert.That(radioButton.checkState.Text, Does.Contain("Impressive"));
        }

        [Test]
        public void CheckNoButton()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            RadioButton radioButton = new RadioButton(driver);
            radioButton.NavigateToRadioButton();
            
            Assert.IsFalse(radioButton.noRadio.Enabled);
        }
    }
}