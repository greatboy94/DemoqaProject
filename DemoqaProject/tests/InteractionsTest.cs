using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class InteractionsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckInteractionsText()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToInteractionsPage();
            Interactions interactions = new Interactions();
            Assert.AreEqual(StoreElementTexts.interactionText, interactions.GetHeaderText());
        }
    }   
}