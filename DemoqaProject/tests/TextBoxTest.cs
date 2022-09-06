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
            elements.NavigateToTextBox();
            TextBox textBox = new TextBox();
            textBox.FillForm(StoreElementTexts.fullName, StoreElementTexts.email, StoreElementTexts.currentAddress, StoreElementTexts.permanentAddress);
            
            //Checking correct inputs and outputs
            Assert.That(textBox.FullNameText(), Does.Contain(StoreElementTexts.fullName));
            Assert.That(textBox.EmailText(), Does.Contain(StoreElementTexts.email));
            Assert.That(textBox.CurrentAdText(), Does.Contain(StoreElementTexts.currentAddress));
            Assert.That(textBox.PerAdText(), Does.Contain(StoreElementTexts.permanentAddress));
            
            //Checking placeholders
            Assert.AreEqual(StoreElementTexts.fNamePH, textBox.GetFNamePlaceholder());
            Assert.AreEqual(StoreElementTexts.emailPH, textBox.GetEmailPlaceholder());
            Assert.AreEqual(StoreElementTexts.currentPH, textBox.GetCurrentAddPlaceholder());
            Thread.Sleep(3000);
        }
        
        
        [Test]
        public void CheckInvalidEmail()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Elements elements = new Elements();
            elements.NavigateToTextBox();
            TextBox textBox = new TextBox();
            textBox.FillForm(StoreElementTexts.fullName, StoreElementTexts.invalidEmail, StoreElementTexts.currentAddress, StoreElementTexts.permanentAddress);
            Assert.IsTrue(textBox.errorClass.Displayed);
            Thread.Sleep(5000);
        }
    }
}