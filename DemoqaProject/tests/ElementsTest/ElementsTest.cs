using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class ElementsTest : BaseSeleniumTest
    {
        
        [Test]
        public void CheckElementText()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            Elements elements = new Elements(driver);
            Assert.AreEqual(StoreElementTexts.elementsText, elements.GetHeaderText());
        }
    }
}