using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Buttons : Elements
    {
        public string expectedDoubleClick = "You have done a double click";
        public string expectedRightClick = "You have done a right click";
        public string expectedClick = "You have done a dynamic click";
        
        [FindsBy(How = How.Id, Using = "doubleClickBtn")]
        public IWebElement doubleClickButton;
        
        [FindsBy(How = How.Id, Using = "rightClickBtn")]
        public IWebElement rightClickButton;
        
        [FindsBy(How = How.XPath, Using = "//button[text()='Click Me']")]
        public IWebElement ClickMeButton;
        
        [FindsBy(How = How.Id, Using = "doubleClickMessage")]
        public IWebElement doubleClickText;
        
        [FindsBy(How = How.Id, Using = "rightClickMessage")]
        public IWebElement rightClickText;
        
        [FindsBy(How = How.Id, Using = "dynamicClickMessage")]
        public IWebElement ClickMeText;
        
        Actions actions = new Actions(driver);

        public void PerformDoubleClick()
        {
            actions.DoubleClick(doubleClickButton).Perform();
        }

        public void PerformRightClick()
        {
            actions.ContextClick(rightClickButton).Build().Perform();
        }

        public void PerformClick()
        {
            ClickMeButton.Click();
        }

        public void WaitLoadPage()
        {
            Task.Delay(TimeSpan.FromSeconds(3)).Wait();
        }

        public Buttons(IWebDriver driver) : base(driver)
        {
        }
    }    
}

