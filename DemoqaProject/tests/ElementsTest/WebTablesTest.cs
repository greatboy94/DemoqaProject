using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class WebTablesTest : BaseSeleniumTest
    {
        private string Denzel = "Denzel";
        private string Tom = "Denzel";
        
        [Test]
        public void CreateTest()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            WebTables webTables = new WebTables();
            webTables.NavigateToWebTables();
            
            //Filling form
            webTables.RegistrationForm(WebTables.firstName, WebTables.lastName, WebTables.emailForm, WebTables.age, WebTables.salary, WebTables.department);
            //Checking added user with name Denzel
            Assert.IsTrue(webTables.CheckName(Denzel));

            //Clicking to sorting table
            webTables.CheckSorting();
            //Checking page results
            Assert.AreEqual(WebTables.pageNumber, webTables.totalPages.Text);
            //Search Box test
            webTables.CheckSearch(WebTables.firstName);
        }

        [Test]
        public void UpdateTest()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            WebTables webTables = new WebTables();
            webTables.NavigateToWebTables();
            
            //Filling form
            webTables.RegistrationForm(WebTables.firstName, WebTables.lastName, WebTables.emailForm, WebTables.age, WebTables.salary, WebTables.department);
            //Editing existing record
            webTables.EditRecord(Tom);
            //Checking edite user with name Tom
            Assert.IsTrue(webTables.CheckName(Tom));
        }

        [Test]
        public void DeleteTest()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            WebTables webTables = new WebTables();
            webTables.NavigateToWebTables();
            
            //Filling form
            webTables.RegistrationForm(WebTables.firstName, WebTables.lastName, WebTables.emailForm, WebTables.age, WebTables.salary, WebTables.department);
            //Deleting existing record
            webTables.DeleteRecord();
            //Checking user name Tom deleted
            Assert.IsFalse(webTables.CheckName(Tom));
        }

        [Test]
        public void Pagination()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            WebTables webTables = new WebTables();
            webTables.NavigateToWebTables();
            
            //Changing pagination
            webTables.Pagination();
            //Adding more record for checking pagination
            for (int i = 0; i < 3; i++)
            {
                webTables.RegistrationForm(WebTables.firstName, WebTables.lastName, WebTables.emailForm, WebTables.age, WebTables.salary, WebTables.department);
            }
            //Clicking to Next and Previous button
            webTables.ClickNext();
            webTables.ClickPrevious();
        }
    }
}

