using System;
using DemoqaProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoqaProject
{
    public class Program : BaseSeleniumTest
    {
       
        [Test]
        public void CheckElementText()
        {
            String getHeader = Config.elementsText;
            HomePage homePage = new HomePage();
            Elements el = new Elements();
            homePage.ClickElem();
            Assert.AreEqual(getHeader, el.GetHeaderText());
        }
    }
}