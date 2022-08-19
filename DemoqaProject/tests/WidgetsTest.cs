using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class WidgetsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckWidgetsText()
        {
            String getHeader = Config.formsText;
            HomePage homePage = new HomePage();
            Forms forms = new Forms();
            homePage.ClickForm();
            Assert.AreEqual(getHeader, forms.GetHeaderText());
        }
    }   
}