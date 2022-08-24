using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class WidgetsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckWidgetsText()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToWidgetsPage();
            Widgets widgets = new Widgets();
            Assert.AreEqual(StoreElementTexts.widgetsText, widgets.GetHeaderText());
        }
    }   
}