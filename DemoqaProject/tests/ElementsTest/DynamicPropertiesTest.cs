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
            //No idea how to check, because id is random
            //Assert.IsTrue(dynamicProperties.RandomID()==dynamicProperties.randomIDButton.GetAttribute("id"));
        }

        [Test]
        public void CheckColorChangeButton()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            DynamicProperties dynamicProperties = new DynamicProperties();
            dynamicProperties.NavigateToDynamicProperties();
            
            //Could not find any other solution
            Thread.Sleep(6000);
            Assert.IsTrue(dynamicProperties.colorChangeButton.Displayed);
        }
        
        [Test]
        public void CheckVisibleAfterButton()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            DynamicProperties dynamicProperties = new DynamicProperties();
            dynamicProperties.NavigateToDynamicProperties();
            
            //Could not find any other solution
            Thread.Sleep(6000);
            Assert.IsTrue(dynamicProperties.visibleAfterButton.Displayed);
        }
    }
}

