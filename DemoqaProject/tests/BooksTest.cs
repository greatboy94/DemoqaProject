using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class BooksTest : BaseSeleniumTest
    {
        [Test]
        public void CheckBooksText()
        {
            String getHeader = Config.bookText;
            HomePage homePage = new HomePage();
            Book book = new Book();
            homePage.ClickBook();
            Assert.AreEqual(getHeader, book.GetHeaderText());
        }
    }   
}