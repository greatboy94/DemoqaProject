using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class LinksTest : BaseSeleniumTest
    {
        [Test]
        public void CheckHomeLink()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.HomeLink();
            Assert.IsTrue(links.bannerImage.Displayed);
        }

        [Test]
        public void CheckHome2Link()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.Home2Link();
            Assert.IsTrue(links.bannerImage.Displayed);
        }
    }
}