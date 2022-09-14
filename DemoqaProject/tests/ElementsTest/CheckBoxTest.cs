using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class CheckBoxTest : BaseSeleniumTest
    {
        [Test]
        public void SelectAllCategories()
        {
            //Appears 17 classes when selected all
            int allSelectedClasses = 17;
            
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            CheckBox checkBox = new CheckBox();
            checkBox.NavigateToCheckBox();

            checkBox.SelectAll();
            Assert.IsTrue(checkBox.textSuccess.Count==allSelectedClasses);
        }

        [Test]
        public void DeselectAllCategories()
        {
            //Appears 0 classes when deselected all
            int allSelectedClasses = 0;
            
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            CheckBox checkBox = new CheckBox();
            checkBox.NavigateToCheckBox();
            
            Assert.IsTrue(checkBox.textSuccess.Count==allSelectedClasses);
        }
        
        [Test]
        public void SelectSpecificCategories()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            CheckBox checkBox = new CheckBox();
            checkBox.NavigateToCheckBox();
            
            Assert.AreEqual(checkBox.expectedTexts, checkBox.SelectSpecificCategories());
        }
        
        [Test]
        public void SelectGroupAndUncheckSubs()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            CheckBox checkBox = new CheckBox();
            checkBox.NavigateToCheckBox();
            
            Assert.AreEqual(checkBox.commandsText, checkBox.SelectGroupAndUncheckSub());
        }
    }
}