using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class BooksTest : BaseSeleniumTest
    {
        [Test]
        public void CheckBooksText()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToBookPage();
            Book book = new Book();
            Assert.AreEqual(StoreElementTexts.bookText, book.GetHeaderText());
        }
    }   
}