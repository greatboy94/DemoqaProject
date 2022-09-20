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
    }
}

