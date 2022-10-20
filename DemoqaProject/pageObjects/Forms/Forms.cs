using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Forms : BaseSeleniumPage
    {
        [FindsBy(How = How.XPath, Using = "//span[text()='Practice Form']")]
        public IWebElement practiceForm;
        
        public Forms()
        {
            PageFactory.InitElements(driver, this);
        }

        public PracticeForm NavigateToPracticeForm()
        {
            practiceForm.Click();
            return new PracticeForm();
        }
    }
}