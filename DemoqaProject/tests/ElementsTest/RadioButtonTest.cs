using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class RadioButtonTest : BaseSeleniumTest
    {
        [Test]
        public void ClickAndCheck()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Elements elements = new Elements();
            elements.NavigateToRadioButton();
            RadioButton radioButton = new RadioButton();
            
            radioButton.CheckYesRadio();
            Assert.That(radioButton.checkState.Text, Does.Contain("Yes"));
            radioButton.CheckImpressiveRadio();
            Assert.That(radioButton.checkState.Text, Does.Contain("Impressive"));
            
            Assert.IsTrue(radioButton.noRadio.Enabled);
            Thread.Sleep(5000);
        }
    }
}