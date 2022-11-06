using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class PracticeFormTest : BaseSeleniumTest
    {
        private string firstname = "Andrew";
        private string lastname = "Garfield";
        private string useremail = "Andrew@gmail.com";
        private string usernumber = "9987773333";
        private string subject = "Computer";
        private string address = "Chicago, USA";
        private string state = "ncr";
        private string city = "Delhi";
        
        private string usernumber2 = "";
        
        [Test]
        public void ValidCredentialTest()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToFormsPage();
            PracticeForm practiceForm = new PracticeForm();
            practiceForm.NavigateToPracticeForm();
            practiceForm.FillFormWithValidCredentials(firstname, lastname, useremail, usernumber, subject, address, state, city);
            
            Thread.Sleep(2000);
            Assert.IsTrue(practiceForm.CheckClassExists());
        }
        
        [Test]
        public void InValidCredentialTest()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToFormsPage();
            PracticeForm practiceForm = new PracticeForm();
            practiceForm.NavigateToPracticeForm();
            practiceForm.FillFormWithInValidCredentials(firstname, lastname, useremail, usernumber2, subject, address, state, city);
            
            Thread.Sleep(2000);
            Assert.IsFalse(practiceForm.CheckClassExists());
        }
    }   
}