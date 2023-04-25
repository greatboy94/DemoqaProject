using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class DynamicPropertiesTest : BaseSeleniumTest
    {
        [Test]
        public void CheckEnabledButton()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            DynamicProperties dynamicProperties = new DynamicProperties(driver);
            dynamicProperties.NavigateToDynamicProperties();
            
            dynamicProperties.EnableButton();
            Assert.IsTrue(dynamicProperties.enableButton.Enabled);
        }

        [Test]
        public void CheckRandomID()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            DynamicProperties dynamicProperties = new DynamicProperties(driver);
            dynamicProperties.NavigateToDynamicProperties();
            
            dynamicProperties.RandomID();
            Assert.IsTrue(dynamicProperties.RandomID()!=dynamicProperties.randomIDButton.GetAttribute("id"));
        }

        [Test]
        public void CheckColorChangeButton()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            DynamicProperties dynamicProperties = new DynamicProperties(driver);
            dynamicProperties.NavigateToDynamicProperties();
            
            dynamicProperties.ColorButton();
            Assert.IsTrue(dynamicProperties.colorChangeButton.Displayed);
        }
        
        [Test]
        public void CheckVisibleAfterButton()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            DynamicProperties dynamicProperties = new DynamicProperties(driver);
            dynamicProperties.NavigateToDynamicProperties();
            
            dynamicProperties.VisibleButton();
            Assert.IsTrue(dynamicProperties.visibleAfterButton.Displayed);
        }
    }
}

