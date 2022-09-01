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
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Web Tables']")]
        public IWebElement WebTablesButton;
        
        [FindsBy(How = How.Id, Using = "addNewRecordButton")]
        public IWebElement AddButton;
        
        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement firstNameInput;
        
        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement lastNameInput;
        
        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement userEmailInput;
        
        [FindsBy(How = How.Id, Using = "age")]
        public IWebElement ageInput;
        
        [FindsBy(How = How.Id, Using = "salary")]
        public IWebElement salaryInput;
        
        [FindsBy(How = How.Id, Using = "department")]
        public IWebElement departmentInput;
        
        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement submitForm;
        
        [FindsBy(How = How.Id, Using = "edit-record-4")]
        public IWebElement editRecord;
        
        [FindsBy(How = How.Id, Using = "delete-record-4")]
        public IWebElement deleteRecord;

        [FindsBy(How = How.XPath, Using = "//div[@class='rt-td']")]
        public IWebElement checkFirstname;
        
        [FindsBy(How = How.XPath, Using = "//option[@value='5']")]
        public IWebElement valueRows;
        
        [FindsBy(How = How.XPath, Using = "//select[@aria-label='rows per page']")]
        public IWebElement rowChangeto5;
        
        [FindsBy(How = How.XPath, Using = "//*[text()='Previous']")]
        public IWebElement previousButton;
        
        [FindsBy(How = How.XPath, Using = "//*[text()='Next']")]
        public IWebElement nextButton;
        
        [FindsBy(How = How.ClassName, Using = "-totalPages")]
        public IWebElement totalPages;
        
        [FindsBy(How = How.Id, Using = "searchBox")]
        public IWebElement searchBox;
        

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

        public void NavigateToWebTables(string firstname, string lastname, string email, string age, string salary, string department)
        {
            WebTablesButton.Click();
            AddButton.Click();
            firstNameInput.SendKeys(firstname);
            lastNameInput.SendKeys(lastname);
            emailInput.SendKeys(email);
            ageInput.SendKeys(age);
            salaryInput.SendKeys(salary);
            departmentInput.SendKeys(department);
            submitForm.Click();
        }

        public void EditRecord()
        {
            editRecord.Click();
            firstNameInput.Clear();
            firstNameInput.SendKeys("Tom");
            submitForm.Click();
        }

        public bool CheckName(string name)
        {
            ReadOnlyCollection<IWebElement> checkbox = driver.FindElements(By.XPath("//div[@class='rt-td']"));
            return checkbox.Any(checkFirstname => checkFirstname.Text.Equals(name));
        }

        public void DeleteRecord()
        {
            deleteRecord.Click();
        }

        public void ChangeRows()
        {
            JSExecuter(rowChangeto5);
            rowChangeto5.Click();
            valueRows.Click();
        }

        public void ClickNext()
        {
            nextButton.Click();
        }
        
        public void ClickPrevious()
        {
            previousButton.Click();
        }

        public void CheckSorting()
        {
            ReadOnlyCollection<IWebElement> checkbox = driver.FindElements(By.XPath("//div[@class='rt-resizable-header-content']"));
            foreach (IWebElement el in checkbox)
            {
                Thread.Sleep(2000);
                el.Click();
            }
        }

        public void CheckSearch(string searchText)
        {
            searchBox.Click();
            searchBox.SendKeys(searchText);
        }
    }
}