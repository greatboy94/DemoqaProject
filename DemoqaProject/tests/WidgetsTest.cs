using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class WidgetsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckWidgetsText()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToWidgetsPage();
            Widgets widgets = new Widgets();
            Assert.AreEqual(StoreElementTexts.widgetsText, widgets.GetHeaderText());
        }
    }   
}