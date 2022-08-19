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
            String getHeader = Config.elementsText;
            HomePage homePage = new HomePage();
            Elements el = new Elements();
            homePage.ClickElement();
            Assert.AreEqual(getHeader, el.GetHeaderText());
        }
    }
}