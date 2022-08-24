using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Elements : BaseSeleniumPage
    {

        [FindsBy(How = How.XPath, Using = "//span[text()='Text Box']")]
        public IWebElement textBoxButton;

        [FindsBy(How = How.XPath, Using = "//input[@id='userName']")]
        public IWebElement fullNameInput;

        [FindsBy(How = How.XPath, Using = "//input[@id='userEmail']")]
        public IWebElement emailInput;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='currentAddress']")]
        public IWebElement currentAddressInput;

        [FindsBy(How = How.XPath, Using = "//textarea[@id='permanentAddress']")]
        public IWebElement permanentAddressInput;
        
        [FindsBy(How = How.XPath, Using = "//button[@id='submit']")]
        public IWebElement submitButton;
        
        [FindsBy(How = How.XPath, Using = "//form[@id='userForm']")]
        public IWebElement userForm;

        [FindsBy(How = How.XPath, Using = "//p[@id='name']")]
        public IWebElement fullnameText;
        
        [FindsBy(How = How.XPath, Using = "//p[@id='email']")]
        public IWebElement emailText;
        
        [FindsBy(How = How.XPath, Using = "//p[@id='currentAddress']")]
        public IWebElement currentAddressText;
        
        [FindsBy(How = How.XPath, Using = "//p[@id='permanentAddress']")]
        public IWebElement permanentAddressText;
        
        

        public Elements()
        {
            PageFactory.InitElements(driver, this);
        }

        public void NavigateToTextBox(string fullname, string email, string currentAddress, string permanentAddress)
        {
            textBoxButton.Click();
            fullNameInput.SendKeys(fullname);
            emailInput.SendKeys(email);
            currentAddressInput.SendKeys(currentAddress);
            permanentAddressInput.SendKeys(permanentAddress);
            submitButton.Click();
            
            IJavaScriptExecutor js=driver as IJavaScriptExecutor;
            js.ExecuteScript("userForm.reset()");
            
        }

        public string FullNameText()
        {
            return fullnameText.Text;
        }
        
        public string EmailText()
        {
            return emailText.Text;
        }
        
        public string CurrentAdText()
        {
            return currentAddressText.Text;
        }
        
        public string PerAdText()
        {
            return permanentAddressText.Text;
        }
        

    }
}