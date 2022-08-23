using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class FormsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckFormText()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToFormsPage();
            Forms forms = new Forms();
            Assert.AreEqual(StoreElementTexts.formsText, forms.GetHeaderText());
        }
    }    
}

