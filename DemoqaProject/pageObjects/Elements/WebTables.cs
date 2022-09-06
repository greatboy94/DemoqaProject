using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class WebTables : Elements
    {
        [FindsBy(How = How.Id, Using = "addNewRecordButton")]
        public IWebElement addButton;
        
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

        [FindsBy(How = How.XPath, Using = "//div[@class='rt-resizable-header-content']")]
        public IList<IWebElement> sorting;
        
        [FindsBy(How = How.XPath, Using = "//div[@class='rt-td']")]
        public IList<IWebElement> nameCheck;
        
        public void RegistrationForm(string firstname, string lastname, string email, string age, string salary, string department)
        {
            addButton.Click();
            firstNameInput.SendKeys(firstname);
            lastNameInput.SendKeys(lastname);
            userEmailInput.SendKeys(email);
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
            IList<IWebElement> checkbox = nameCheck;
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

        public void ClickNext()=>nextButton.Click();

        public void ClickPrevious()=>previousButton.Click();

        public void CheckSorting()
        {
            IList<IWebElement> checkbox = sorting;
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

