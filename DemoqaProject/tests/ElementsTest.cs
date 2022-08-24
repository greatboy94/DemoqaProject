using System;
using DemoqaProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqaProject
{
    public class ElementsTest : BaseSeleniumTest
    {
       
        [Test]
        public void CheckElementText()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            Elements elements = new Elements();
            Assert.AreEqual(StoreElementTexts.elementsText, elements.GetHeaderText());
            
            elements.NavigateToTextBox(StoreElementTexts.fullName, StoreElementTexts.email, StoreElementTexts.currentAddress, StoreElementTexts.permanentAddress);
            Assert.That(elements.FullNameText(), Does.Contain(StoreElementTexts.fullName));
            Assert.That(elements.EmailText(), Does.Contain(StoreElementTexts.email));
            Assert.That(elements.CurrentAdText(), Does.Contain(StoreElementTexts.currentAddress));
            Assert.That(elements.PerAdText(), Does.Contain(StoreElementTexts.permanentAddress));
            Thread.Sleep(5000);
        }
    }
}