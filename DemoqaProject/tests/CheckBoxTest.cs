using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class CheckBoxTest : BaseSeleniumTest
    {
        [Test]
        public void SelectAll()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Elements elements = new Elements();
            elements.NavigateToCheckBox();

            Thread.Sleep(3000);
            elements.Count();
            Thread.Sleep(3000);
            Assert.IsFalse(elements.selectAll.Selected);
            
            elements.SpecificCategories();
            elements.SelectGroupAndUncheckSub();
            elements.ExpendAndCollapseAll();

            Thread.Sleep(5000);
        }
    }
}