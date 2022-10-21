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
        
        [FindsBy(How = How.Id, Using = "dateOfBirthInput")]
        public IWebElement dateOfBirth;

        [FindsBy(How = How.ClassName, Using = "react-datepicker__month-select")]
        public IWebElement pickMonth;
        
        [FindsBy(How = How.ClassName, Using = "react-datepicker__year-select")]
        public IWebElement pickYear;
        
        [FindsBy(How = How.XPath, Using = "//div[@class='react-datepicker__day react-datepicker__day--024 react-datepicker__day--weekend']")]
        public IWebElement pickDate;

        [FindsBy(How = How.Id, Using = "subjectsContainer")]
        public IWebElement subject;

        [FindsBy(How = How.XPath, Using = "//div[@class='custom-control custom-checkbox custom-control-inline']")]
        public IList<IWebElement> hobbies;

        [FindsBy(How = How.Id, Using = "uploadPicture")]
        public IWebElement uploadPhoto;


        public void FillFormWithValidCredentials()
        {
            firstName.SendKeys("Buyuk");
            lastName.SendKeys("Navruzov");
            userEmail.SendKeys("buyuk@mail.ru");
            male.Click();
            dateOfBirth.Click();
            SelectElement year = new SelectElement(pickYear);
            year.SelectByText(YEAR);
            SelectElement month = new SelectElement(pickMonth);
            month.SelectByText(MONTH);
            WaitElement(pickDate);
            pickDate.Click();
            JSExecuter(subject);
            subject.SendKeys("Math");
            foreach (var el in hobbies)
            {
                JSExecuter(el);
                el.Click();
            }
            JSExecuter(uploadPhoto);
            uploadPhoto.SendKeys(uploadURL);
        }
    }   
}