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
            
            links.FirstLinkOpenNewTab();
            Assert.IsTrue(links.bannerImage.Displayed);
        }

        [Test]
        public void CheckHome2Link()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.SecondLinkOpenNewTab();
            Assert.IsTrue(links.bannerImage.Displayed);
        }
        
        [Test]
        public void CheckCreated()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.ClickCreatedButton();
            Assert.That(links.responseLink.Text, Does.Contain("201"));
        }
        
        [Test]
        public void CheckNoContent()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.ClickNoContentButton();
            Assert.That(links.responseLink.Text, Does.Contain("204"));
        }
        
        [Test]
        public void CheckMoved()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.ClickMovedButton();
            Assert.That(links.responseLink.Text, Does.Contain("301"));
        }
        
        [Test]
        public void CheckBadRequest()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.ClickBadRequestButton();
            Assert.That(links.responseLink.Text, Does.Contain("400"));
        }
        
        [Test]
        public void CheckUnauthorized()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.ClickUnauthorizedButton();
            Assert.That(links.responseLink.Text, Does.Contain("401"));
        }
        
        [Test]
        public void CheckForbidden()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.ClickForbiddenButton();
            Assert.That(links.responseLink.Text, Does.Contain("403"));
        }
        
        [Test]
        public void CheckNotFound()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.ClickNotFoundButton();
            Assert.That(links.responseLink.Text, Does.Contain("404"));
        }
    }
}