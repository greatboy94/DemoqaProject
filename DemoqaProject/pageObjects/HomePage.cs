using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class HomePage : BaseSeleniumPage
    {
        public HomePage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(Config.baseURL);
            PageFactory.InitElements(driver, this);
        }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][1]")]
        public IWebElement elementButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][2]")]
        public IWebElement formsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][3]")]
        public IWebElement alertsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][4]")]
        public IWebElement widgetsButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][5]")]
        public IWebElement interactionButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][6]")]
        public IWebElement bookButton { get; set; }

        public Elements NavigateToElementPage()
        {
            elementButton.Click();
            return new Elements(driver);
        }
        public Forms NavigateToFormsPage()
        {
            formsButton.Click();
            return new Forms();
        }
        public Alerts NavigateToAlertsPage()
        {
            alertsButton.Click();
            return new Alerts();
        }
        public Widgets NavigateToWidgetsPage()
        {
            widgetsButton.Click();
            return new Widgets();
        }
        public Interactions NavigateToInteractionsPage()
        {
            interactionButton.Click();
            return new Interactions();
        }
        public Book NavigateToBookPage()
        {
            JSExecuter(bookButton);
            bookButton.Click();
            return new Book();
        }
    }
}