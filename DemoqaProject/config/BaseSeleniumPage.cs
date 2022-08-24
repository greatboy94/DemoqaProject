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

        public void JSExecuter()
        {
            IJavaScriptExecutor js=driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,950);");
        }

        public string GetHeaderText()
        {
            return HeaderText.Text;
        }
    }    
}