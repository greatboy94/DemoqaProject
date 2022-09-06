using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class CheckBoxTest : BaseSeleniumTest
    {
        [Test]
        public void SelectAllCategories()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Elements elements = new Elements();
            elements.NavigateToCheckBox();
            CheckBox checkBox = new CheckBox();

            checkBox.SelectAll();
            Thread.Sleep(3000);
            checkBox.Count(17);
            Thread.Sleep(3000);
            Assert.IsFalse(checkBox.selectAll.Selected);
            
            checkBox.SelectSpecificCategories();
            checkBox.SelectGroupAndUncheckSub();
            checkBox.ExpendAndCollapseAll();

            Thread.Sleep(5000);
        }
    }
}