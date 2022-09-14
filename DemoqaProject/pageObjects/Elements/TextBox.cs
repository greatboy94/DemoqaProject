using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class TextBox : Elements
    {
        public static string fullName = "Andrew Garfield";
        public static string email = "Andrew@gmail.com";
        public static string currentAddress = "Wall Street 23";
        public static string permanentAddress = "Wisconsin Dells 18";
        public static string invalidEmail="Andrew123";
        
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

        [FindsBy(How = How.XPath, Using = "//input[@class='mr-sm-2 field-error form-control']")]
        public IWebElement errorClass;
        
        
        public void FillForm(string fullname, string email, string currentAddress, string permanentAddress)
        {
            fullNameInput.SendKeys(fullname);
            emailInput.SendKeys(email);
            currentAddressInput.SendKeys(currentAddress);
            permanentAddressInput.SendKeys(permanentAddress);
            submitButton.Click();
            
            IJavaScriptExecutor js=driver as IJavaScriptExecutor;
            js.ExecuteScript("userForm.reset()");
            
        }
        
        //Getting text of elements
        public string FullNameText() => fullnameText.Text;

        public string EmailText()=>emailText.Text;

        public string CurrentAdText()=>currentAddressText.Text;

        public string PerAdText()=>permanentAddressText.Text;

        //Getting placeholders
        public string GetFNamePlaceholder()=>fullNameInput.GetAttribute("placeholder");

        public string GetEmailPlaceholder()=>emailInput.GetAttribute("placeholder");

        public string GetCurrentAddPlaceholder()=>currentAddressInput.GetAttribute("placeholder");
    }    
}

