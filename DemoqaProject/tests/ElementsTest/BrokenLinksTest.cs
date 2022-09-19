using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class BrokenLinksTest : BaseSeleniumTest
    {
        [Test]
        public void CheckBrokenImages()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            BrokenLinks brokenLinks = new BrokenLinks();
            brokenLinks.NavigateToBrokenLinks();
            
            brokenLinks.ValidImage();
            Assert.IsTrue(brokenLinks.validImage.Displayed);
        }
        
        [Test]
        public void CheckValidAndInvalidLinks()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            BrokenLinks brokenLinks = new BrokenLinks();
            brokenLinks.NavigateToBrokenLinks();
            
            brokenLinks.ValidAndInvalidLinks();
        }
    }
}