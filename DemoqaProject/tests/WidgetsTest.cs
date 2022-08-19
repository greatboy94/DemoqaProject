using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class WidgetsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckWidgetsText()
        {
            String getHeader = Config.widgetsText;
            HomePage homePage = new HomePage();
            Widgets widgets = new Widgets();
            homePage.ClickWidget();
            Assert.AreEqual(getHeader, widgets.GetHeaderText());
        }
    }   
}