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
            
            links.Created();
            Assert.That(links.responseLink.Text, Does.Contain("201"));
        }
        
        [Test]
        public void CheckNoContent()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.NoContent();
            Assert.That(links.responseLink.Text, Does.Contain("204"));
        }
        
        [Test]
        public void CheckMoved()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.Moved();
            Assert.That(links.responseLink.Text, Does.Contain("301"));
        }
        
        [Test]
        public void CheckBadRequest()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.BadRequest();
            Assert.That(links.responseLink.Text, Does.Contain("400"));
        }
        
        [Test]
        public void CheckUnauthorized()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.Unauthorized();
            Assert.That(links.responseLink.Text, Does.Contain("401"));
        }
        
        [Test]
        public void CheckForbidden()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.Forbidden();
            Assert.That(links.responseLink.Text, Does.Contain("403"));
        }
        
        [Test]
        public void CheckNotFound()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.NotFound();
            Assert.That(links.responseLink.Text, Does.Contain("404"));
        }
    }
}