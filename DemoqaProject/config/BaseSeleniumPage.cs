using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System.Threading.Tasks;

namespace DemoqaProject
{
    public class BaseSeleniumPage
    {
        protected static IWebDriver driver;
        
        [FindsBy(How = How.ClassName, Using = "main-header")]
        public IWebElement HeaderText { get; set; }

        public static void SetDriver(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void JSExecuter(IWebElement element)
        {
            IJavaScriptExecutor js=driver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public string GetHeaderText()
        {
            return HeaderText.Text;
        }

        public void WaitElement(IWebElement xPath)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(xPath));
        }

        public void WaitInterval()
        {
            Task.Delay(TimeSpan.FromSeconds(3)).Wait();
        }
    }    
}