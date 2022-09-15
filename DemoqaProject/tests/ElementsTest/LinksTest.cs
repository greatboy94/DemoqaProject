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
        
        [Test]
        public void CheckCreated()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.Created();
            Assert.That(links.responseLink.Text, Does.Contain(links.createCode));
            Thread.Sleep(5000);
        }
        
        [Test]
        public void CheckNoContent()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.NoContent();
            Assert.That(links.responseLink.Text, Does.Contain(links.noContentCode));
            Thread.Sleep(5000);
        }
        
        [Test]
        public void CheckMoved()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.Moved();
            Assert.That(links.responseLink.Text, Does.Contain(links.movedCode));
            Thread.Sleep(5000);
        }
        
        [Test]
        public void CheckBadRequest()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.BadRequest();
            Assert.That(links.responseLink.Text, Does.Contain(links.badRequestCode));
            Thread.Sleep(5000);
        }
        
        [Test]
        public void CheckUnauthorized()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.Unauthorized();
            Assert.That(links.responseLink.Text, Does.Contain(links.unauthorizedCode));
            Thread.Sleep(5000);
        }
        
        [Test]
        public void CheckForbidden()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.Forbidden();
            Assert.That(links.responseLink.Text, Does.Contain(links.forbiddenCode));
            Thread.Sleep(5000);
        }
        
        [Test]
        public void CheckNotFound()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Links links = new Links();
            links.NavigateToLinks();
            
            links.NotFound();
            Assert.That(links.responseLink.Text, Does.Contain(links.notFoundCode));
            Thread.Sleep(5000);
        }
    }
}