using System.Collections.ObjectModel;
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

        [FindsBy(How = How.XPath, Using = "//input[@class='mr-sm-2 field-error form-control']")]
        public IWebElement errorClass;

        [FindsBy(How = How.XPath, Using = "//span[text()='Check Box']")]
        public IWebElement checkBoxButton;

        [FindsBy(How = How.ClassName, Using = "rct-checkbox")]
        public IWebElement selectAll;

        [FindsBy(How = How.Id, Using = "result")]
        public IWebElement checkSelectedResult;

        [FindsBy(How = How.XPath, Using = "//button[@class='rct-collapse rct-collapse-btn'][1]")]
        public IWebElement arrowButton;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Desktop']")]
        public IWebElement desktopButton;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Commands']")]
        public IWebElement commandsButton;
        
        [FindsBy(How = How.XPath, Using = "//button[@title='Expand all']")]
        public IWebElement expendAll;
        
        [FindsBy(How = How.XPath, Using = "//button[@title='Collapse all']")]
        public IWebElement collapseAll;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Radio Button']")]
        public IWebElement radioButton;
        
        [FindsBy(How = How.XPath, Using = "//label[@for='yesRadio']")]
        public IWebElement yesRadio;
        
        [FindsBy(How = How.XPath, Using = "//label[@for='impressiveRadio']")]
        public IWebElement impressiveRadio;
        
        [FindsBy(How = How.XPath, Using = "//label[@for='noRadio']")]
        public IWebElement noRadio;
        
        [FindsBy(How = How.ClassName, Using = "mt-3")]
        public IWebElement checkState;

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

        //Getting text of elements
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

        //Getting placeholders
        public string GetFNamePlaceholder()
        {
            return fullNameInput.GetAttribute("placeholder");
        }

        public string GetEmailPlaceholder()
        {
            return emailInput.GetAttribute("placeholder");
        }

        public string GetCurrentAddPlaceholder()
        {
            return currentAddressInput.GetAttribute("placeholder");
        }

        public void NavigateToCheckBox()
        {
            checkBoxButton.Click();
            selectAll.Click();
        }

        public void Count()
        {
            ReadOnlyCollection<IWebElement> checkbox = driver.FindElements(By.XPath("//span[@class='text-success']"));
            Console.WriteLine(checkbox.Count);
            if (checkbox.Count==17)
            {
                Console.WriteLine("Selected all");
            }
            else if (!selectAll.Selected)
            {
                Console.WriteLine("Deselected all");
            }
            selectAll.Click();
        }

        public void SpecificCategories()
        {
            //Select specific category and verify
            arrowButton.Click();
            if (!desktopButton.Selected)
            {
                desktopButton.Click();
                Console.WriteLine("Category Desktop selected");
            }
            else
            {
                Console.WriteLine("Category Desktop not selected");
            }
        }

        public void SelectGroupAndUncheckSub()
        {
            ReadOnlyCollection<IWebElement> checkbox = driver.FindElements(By.XPath("//button[@class='rct-collapse rct-collapse-btn']"));
            checkbox[1].Click();
            if (!commandsButton.Selected)
            {
                commandsButton.Click();
                Console.WriteLine("Sub group deselected");
            }
        }

        public void ExpendAndCollapseAll()
        {
            expendAll.Click();
            collapseAll.Click();
        }

        public void NavigateToRadioButton()
        {
            radioButton.Click();
        }

        public void CheckYesRadio()
        {
            yesRadio.Click();
        }
        
        public void CheckImpressiveRadio()
        {
            impressiveRadio.Click();
        }
        
        public void CheckMultipleSelection()
        {
            
        }
    }
}