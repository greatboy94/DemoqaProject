using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class WebTablesTest : BaseSeleniumTest
    {
        [Test]
        public void CRUDTest()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Elements elements = new Elements();
            WebTables webTables = new WebTables();

            //Filling form
            elements.NavigateToWebTables();
            webTables.RegistrationForm(StoreElementTexts.firstName, StoreElementTexts.lastName, StoreElementTexts.email, StoreElementTexts.age, StoreElementTexts.salary, StoreElementTexts.department);
            //Checking added user with name Denzel
            Assert.IsTrue(webTables.CheckName("Denzel"));
            //Editing existing record
            webTables.EditRecord();
            //Checking edite user with name Tom
            Assert.IsTrue(webTables.CheckName("Tom"));
            //Deleting existing record
            webTables.DeleteRecord();
            //Checking user name Tom deleted
            Assert.IsFalse(webTables.CheckName("Tom"));
            //Changing rows to 5 checking for pagination
            webTables.ChangeRows();
            
            //Adding more record for checking pagination
            for (int i = 0; i < 3; i++)
            {
                webTables.RegistrationForm(StoreElementTexts.firstName, StoreElementTexts.lastName, StoreElementTexts.email, StoreElementTexts.age, StoreElementTexts.salary, StoreElementTexts.department);
            }
            //Clicking to Next and Previous button
            webTables.ClickNext();
            Thread.Sleep(5000);
            webTables.ClickPrevious();
            
            //Clicking to sorting table
            webTables.CheckSorting();
            //Checking page results
            Assert.AreEqual("2",webTables.totalPages.Text);
            //Search Box test
            webTables.CheckSearch(StoreElementTexts.firstName);
            Thread.Sleep(5000);
        }
    }
}
