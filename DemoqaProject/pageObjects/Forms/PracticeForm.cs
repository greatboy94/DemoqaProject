using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class PracticeForm : Forms
    {
        private string YEAR = "1994";
        private string MONTH = "July";
        private static string? RunningPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString())?.ToString();
        public string uploadURL = Path.GetFullPath(Path.Combine(RunningPath ?? string.Empty, $"files{Path.DirectorySeparatorChar}sampleFile.jpeg"));

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement firstName;
        
        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement lastName;
        
        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement userEmail;
        
        [FindsBy(How = How.XPath, Using = "//label[@for='gender-radio-1']")]
        public IWebElement male;
        
        [FindsBy(How = How.Id, Using = "userNumber")]
        public IWebElement userNumber;
        
        [FindsBy(How = How.Id, Using = "dateOfBirthInput")]
        public IWebElement dateOfBirth;

        [FindsBy(How = How.ClassName, Using = "react-datepicker__month-select")]
        public IWebElement pickMonth;
        
        [FindsBy(How = How.ClassName, Using = "react-datepicker__year-select")]
        public IWebElement pickYear;
        
        [FindsBy(How = How.XPath, Using = "//div[@class='react-datepicker__day react-datepicker__day--024 react-datepicker__day--weekend']")]
        public IWebElement pickDate;

        [FindsBy(How = How.Id, Using = "subjectsInput")]
        public IWebElement subject;

        [FindsBy(How = How.XPath, Using = "//div[@class='custom-control custom-checkbox custom-control-inline']")]
        public IList<IWebElement> hobbies;

        [FindsBy(How = How.Id, Using = "uploadPicture")]
        public IWebElement uploadPhoto;

        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement currentAddress;
        
        [FindsBy(How = How.Id, Using = "react-select-3-input")]
        public IWebElement state;
        
        [FindsBy(How = How.Id, Using = "react-select-4-input")]
        public IWebElement city;
        
        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement submit;

        [FindsBy(How = How.ClassName, Using = "modal-content")]
        public IList<IWebElement> tableName;


        public void FillFormWithValidCredentials(string firstname, string lastname, string useremail, string usernumber, string subj, string address, string state1, string city1)
        {
            firstName.SendKeys(firstname);
            lastName.SendKeys(lastname);
            userEmail.SendKeys(useremail);
            male.Click();
            userNumber.SendKeys(usernumber);
            dateOfBirth.Click();
            SelectElement year = new SelectElement(pickYear);
            year.SelectByText(YEAR);
            SelectElement month = new SelectElement(pickMonth);
            month.SelectByText(MONTH);
            WaitElement(pickDate);
            JSExecuter(pickDate);
            pickDate.Click();
            JSExecuter(subject);
            subject.SendKeys(subj);
            subject.SendKeys(Keys.Enter);
            foreach (var el in hobbies)
            {
                JSExecuter(el);
                el.Click();
            }
            JSExecuter(uploadPhoto);
            uploadPhoto.SendKeys(uploadURL);
            currentAddress.SendKeys(address);
            state.SendKeys(state1);
            state.SendKeys(Keys.Enter);
            city.SendKeys(city1);
            city.SendKeys(Keys.Enter);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", submit);
        }
        
        public void FillFormWithInValidCredentials(string firstname, string lastname, string useremail, string usernumber, string subj, string address, string state1, string city1)
        {
            firstName.SendKeys(firstname);
            lastName.SendKeys(lastname);
            userEmail.SendKeys(useremail);
            male.Click();
            userNumber.SendKeys(usernumber);
            dateOfBirth.Click();
            SelectElement year = new SelectElement(pickYear);
            year.SelectByText(YEAR);
            SelectElement month = new SelectElement(pickMonth);
            month.SelectByText(MONTH);
            WaitElement(pickDate);
            JSExecuter(pickDate);
            pickDate.Click();
            JSExecuter(subject);
            subject.SendKeys(subj);
            subject.SendKeys(Keys.Enter);
            foreach (var el in hobbies)
            {
                JSExecuter(el);
                el.Click();
            }
            JSExecuter(uploadPhoto);
            uploadPhoto.SendKeys(uploadURL);
            currentAddress.SendKeys(address);
            state.SendKeys(state1);
            state.SendKeys(Keys.Enter);
            city.SendKeys(city1);
            city.SendKeys(Keys.Enter);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", submit);
        }

        public bool CheckClassExists()
        {
            int elementsCount = tableName.Count();
            if (elementsCount<1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }   
}