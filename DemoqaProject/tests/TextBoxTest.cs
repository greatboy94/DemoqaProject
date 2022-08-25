using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class TextBoxTest : BaseSeleniumTest
    {

        [Test]
        public void FillForm()
        {
            
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Elements elements = new Elements();
            elements.NavigateToTextBox(StoreElementTexts.fullName, StoreElementTexts.email, StoreElementTexts.currentAddress, StoreElementTexts.permanentAddress);
            
            //Checking correct inputs and outputs
            Assert.That(elements.FullNameText(), Does.Contain(StoreElementTexts.fullName));
            Assert.That(elements.EmailText(), Does.Contain(StoreElementTexts.email));
            Assert.That(elements.CurrentAdText(), Does.Contain(StoreElementTexts.currentAddress));
            Assert.That(elements.PerAdText(), Does.Contain(StoreElementTexts.permanentAddress));
            
            //Checking placeholders
            Assert.AreEqual(StoreElementTexts.fNamePH, elements.GetFNamePlaceholder());
            Assert.AreEqual(StoreElementTexts.emailPH, elements.GetEmailPlaceholder());
            Assert.AreEqual(StoreElementTexts.currentPH, elements.GetCurrentAddPlaceholder());
            Thread.Sleep(3000);
        }
        
        
        [Test]
        public void CheckInvalidEmail()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Elements elements = new Elements();
            elements.NavigateToTextBox(StoreElementTexts.fullName, StoreElementTexts.invalidEmail, StoreElementTexts.currentAddress, StoreElementTexts.permanentAddress);
            Assert.IsTrue(elements.errorClass.Displayed);
            Thread.Sleep(5000);
        }
    }
}