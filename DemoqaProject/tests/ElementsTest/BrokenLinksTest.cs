using DemoqaProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqaProject
{
    public class BrokenLinksTest : BaseSeleniumTest
    {
        [Parallelizable]
        [Test]
        public void CheckBrokenImages()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            BrokenLinks brokenLinks = new BrokenLinks(driver);
            brokenLinks.NavigateToBrokenLinks();
            
            brokenLinks.ValidImage();
            Assert.IsTrue(brokenLinks.validImage.Displayed);
        }
        
        [Test]
        public void CheckValidAndInvalidLinks()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            BrokenLinks brokenLinks = new BrokenLinks(driver);
            brokenLinks.NavigateToBrokenLinks();
            
            brokenLinks.ValidAndInvalidLinks();
            Assert.IsTrue(brokenLinks.brokenLink.Displayed);
        }
    }
}