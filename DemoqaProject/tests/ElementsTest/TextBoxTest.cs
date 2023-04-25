using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class TextBoxTest : BaseSeleniumTest
    {

        [Test]
        public void FillForm()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            TextBox textBox = new TextBox(driver);
            textBox.NavigateToTextBox();
            textBox.FillForm(TextBox.fullName, TextBox.email, TextBox.currentAddress, TextBox.permanentAddress);
            
            //Checking correct inputs and outputs
            Assert.That(textBox.FullNameText(), Does.Contain(TextBox.fullName));
            Assert.That(textBox.EmailText(), Does.Contain(TextBox.email));
            Assert.That(textBox.CurrentAdText(), Does.Contain(TextBox.currentAddress));
            Assert.That(textBox.PerAdText(), Does.Contain(TextBox.permanentAddress));
        }
        
        [Test]
        public void CheckInvalidEmail()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            TextBox textBox = new TextBox(driver);
            textBox.NavigateToTextBox();
            
            textBox.FillForm(TextBox.fullName, TextBox.invalidEmail, TextBox.currentAddress, TextBox.permanentAddress);
            Assert.IsTrue(textBox.errorClass.Displayed);
        }

        [Test]
        public void CheckPlaceholders()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            TextBox textBox = new TextBox(driver);
            textBox.NavigateToTextBox();
            
            //Checking placeholders
            Assert.AreEqual(StoreElementTexts.fNamePH, textBox.GetFNamePlaceholder());
            Assert.AreEqual(StoreElementTexts.emailPH, textBox.GetEmailPlaceholder());
            Assert.AreEqual(StoreElementTexts.currentPH, textBox.GetCurrentAddPlaceholder());
        }
    }
}