using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class DynamicPropertiesTest : BaseSeleniumTest
    {
        [Test]
        public void CheckEnabledButton()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            DynamicProperties dynamicProperties = new DynamicProperties();
            dynamicProperties.NavigateToDynamicProperties();
            
            dynamicProperties.EnableButton();
            Assert.IsTrue(dynamicProperties.enableButton.Enabled);
        }

        [Test]
        public void CheckRandomID()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            DynamicProperties dynamicProperties = new DynamicProperties();
            dynamicProperties.NavigateToDynamicProperties();
            
            dynamicProperties.RandomID();
            Assert.IsTrue(dynamicProperties.RandomID()!=dynamicProperties.randomIDButton.GetAttribute("id"));
        }

        [Test]
        public void CheckColorChangeButton()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            DynamicProperties dynamicProperties = new DynamicProperties();
            dynamicProperties.NavigateToDynamicProperties();
            
            dynamicProperties.ColorButton();
            Assert.IsTrue(dynamicProperties.colorChangeButton.Displayed);
        }
        
        [Test]
        public void CheckVisibleAfterButton()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            DynamicProperties dynamicProperties = new DynamicProperties();
            dynamicProperties.NavigateToDynamicProperties();
            
            dynamicProperties.VisibleButton();
            Assert.IsTrue(dynamicProperties.visibleAfterButton.Displayed);
        }
    }
}

