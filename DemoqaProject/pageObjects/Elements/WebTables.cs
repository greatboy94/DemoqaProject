using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class WebTables : Elements
    {
        public static string firstName = "Denzel";
        public static string lastName = "Washington";
        public static string emailForm = "Denzel@gmail.com";
        public static string age = "67";
        public static string salary = "3500";
        public static string department = "New York, Mount Vernon";
        public static string pageNumber = "2";

        public static string option = "5";
        
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

        [FindsBy(How = How.XPath, Using = "//select[@aria-label='rows per page']")]
        public IWebElement pagination;
        
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
        
        public void EditRecord(string name)
        {
            editRecord.Click();
            firstNameInput.Clear();
            firstNameInput.SendKeys(name);
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

        public void Pagination()
        {
            SelectElement selectElement = new SelectElement(pagination);
            selectElement.SelectByValue(option);
        }

        public void ClickNext()=>nextButton.Click();

        public void ClickPrevious()=>previousButton.Click();

        public void CheckSorting()
        {
            IList<IWebElement> checkbox = sorting;
            foreach (IWebElement el in checkbox)
            {
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

