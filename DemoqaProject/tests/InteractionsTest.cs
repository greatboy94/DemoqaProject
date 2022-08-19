using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class InteractionsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckInteractionsText()
        {
            String getHeader = Config.interactionText;
            HomePage homePage = new HomePage();
            Interactions interactions = new Interactions();
            homePage.ClickInteraction();
            Assert.AreEqual(getHeader, interactions.GetHeaderText());
        }
    }   
}