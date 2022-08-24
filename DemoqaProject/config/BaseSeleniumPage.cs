using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

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
    }    
}