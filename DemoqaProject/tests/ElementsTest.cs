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
        }
    }
}