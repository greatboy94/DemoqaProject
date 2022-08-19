using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class FormsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckFormText()
        {
            String getHeader = Config.formsText;
            HomePage homePage = new HomePage();
            Forms form = new Forms();
            homePage.ClickForm();
            Assert.AreEqual(getHeader, form.GetHeaderText());
        }
    }    
}

