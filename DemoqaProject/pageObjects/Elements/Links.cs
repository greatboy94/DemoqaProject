using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Links : Elements
    {
        [FindsBy(How = How.Id, Using = "simpleLink")]
        public IWebElement homeLink;
        
        [FindsBy(How = How.Id, Using = "dynamicLink")]
        public IWebElement home2Link;
        
        [FindsBy(How = How.ClassName, Using = "banner-image")]
        public IWebElement bannerImage;

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
    }    
}

