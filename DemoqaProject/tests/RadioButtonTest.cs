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
            
            elements.CheckYesRadio();
            Assert.That(elements.checkState.Text, Does.Contain("Yes"));
            elements.CheckImpressiveRadio();
            Assert.That(elements.checkState.Text, Does.Contain("Impressive"));
            
            Assert.IsTrue(elements.noRadio.Enabled);
            Thread.Sleep(5000);
        }
    }
}