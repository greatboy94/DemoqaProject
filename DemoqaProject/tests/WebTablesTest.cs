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
            
            //Filling form
            elements.NavigateToWebTables(StoreElementTexts.firstName, StoreElementTexts.lastName, StoreElementTexts.email, StoreElementTexts.age, StoreElementTexts.salary, StoreElementTexts.department);
            //Checking added user with name Denzel
            Assert.IsTrue(elements.CheckName("Denzel"));
            //Editing existing record
            elements.EditRecord();
            //Checking edite user with name Tom
            Assert.IsTrue(elements.CheckName("Tom"));
            //Deleting existing record
            elements.DeleteRecord();
            //Checking user name Tom deleted
            Assert.IsFalse(elements.CheckName("Tom"));
            //Changing rows to 5 checking for pagination
            elements.ChangeRows();
            
            //Adding more record for checking pagination
            for (int i = 0; i < 3; i++)
            {
                elements.NavigateToWebTables(StoreElementTexts.firstName, StoreElementTexts.lastName, StoreElementTexts.email, StoreElementTexts.age, StoreElementTexts.salary, StoreElementTexts.department);
            }
            //Clicking to Next and Previous button
            elements.ClickNext();
            Thread.Sleep(5000);
            elements.ClickPrevious();
            
            //Clicking to sorting table
            elements.CheckSorting();
            //Checking page results
            Assert.AreEqual("2",elements.totalPages.Text);
            //Search Box test
            elements.CheckSearch(StoreElementTexts.firstName);
            Thread.Sleep(5000);
        }
    }
}

