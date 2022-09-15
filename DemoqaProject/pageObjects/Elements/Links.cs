using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Links : Elements
    {
        public string createCode = "201";
        public string noContentCode = "204";
        public string movedCode = "301";
        public string badRequestCode = "400";
        public string unauthorizedCode = "401";
        public string forbiddenCode = "403";
        public string notFoundCode = "404";

        [FindsBy(How = How.Id, Using = "simpleLink")]
        public IWebElement homeLink;
        
        [FindsBy(How = How.Id, Using = "dynamicLink")]
        public IWebElement home2Link;
        
        [FindsBy(How = How.ClassName, Using = "banner-image")]
        public IWebElement bannerImage;
        
        [FindsBy(How = How.Id, Using = "created")]
        public IWebElement createdButton;
        
        [FindsBy(How = How.Id, Using = "linkResponse")]
        public IWebElement responseLink;
        
        [FindsBy(How = How.Id, Using = "no-content")]
        public IWebElement noContentButton;
        
        [FindsBy(How = How.Id, Using = "moved")]
        public IWebElement movedButton;
        
        [FindsBy(How = How.Id, Using = "bad-request")]
        public IWebElement badRequestButton;
        
        [FindsBy(How = How.Id, Using = "unauthorized")]
        public IWebElement unauthorizedButton;
        
        [FindsBy(How = How.Id, Using = "forbidden")]
        public IWebElement forbiddenButton;
        
        [FindsBy(How = How.Id, Using = "invalid-url")]
        public IWebElement notFoundButton;

        public void HomeLink()
        {
            homeLink.Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }
        
        public void Home2Link()
        {
            home2Link.Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }
        
        public void Created()
        {
            createdButton.Click();
        }

        public void NoContent()
        {
            noContentButton.Click();
        }
        
        public void Moved()
        {
            movedButton.Click();
        }
        
        public void BadRequest()
        {
            badRequestButton.Click();
        }
        
        public void Unauthorized()
        {
            unauthorizedButton.Click();
        }
        
        public void Forbidden()
        {
            forbiddenButton.Click();
        }
        
        public void NotFound()
        {
            notFoundButton.Click();
        }
    }    
}

