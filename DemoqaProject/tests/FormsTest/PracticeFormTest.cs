using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class PracticeFormTest : BaseSeleniumTest
    {
        [Test]
        public void ValidCredentialTest()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToFormsPage();
            PracticeForm practiceForm = new PracticeForm();
            practiceForm.NavigateToPracticeForm();
            practiceForm.FillFormWithValidCredentials();
            
            Thread.Sleep(5000);
        }
    }   
}