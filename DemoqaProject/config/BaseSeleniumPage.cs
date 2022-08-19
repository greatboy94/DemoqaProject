using OpenQA.Selenium;

namespace DemoqaProject
{
    public class BaseSeleniumPage
    {
        protected static IWebDriver driver;

        public static void SetDriver(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }    
}