using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class PracticeFormTest : BaseSeleniumTest
    {

        [TestCase("Andrew", "Garfield", "Andrew@gmail.com", "9987773333", "Computer", "Chicago, USA", "ncr", "Delhi", true)]
        [TestCase("Andrew", "Garfield", "Andrew@gmail.com", "", "Computer", "Chicago, USA", "ncr", "Delhi", false)]
        public void ValidCredentialTest(string firstname, string lastname, string useremail, string usernumber, string subject, string address, string state, string city, bool testCaseOrder)
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToFormsPage();
            PracticeForm practiceForm = new PracticeForm();
            practiceForm.NavigateToPracticeForm();
            practiceForm.FillRegistrationForm(firstname, lastname, useremail, usernumber, subject, address, state, city);

            if (testCaseOrder)
            {
                Assert.IsTrue(practiceForm.CheckClassExists());
            }
            else
            {
                Assert.IsFalse(practiceForm.CheckClassExists());   
            }
        }
    }   
}