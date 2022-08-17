using System;
using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Actions.SetUpDriver();
            //NavigateTo.ClickToElement();
        }

        [SetUp]
        public void SetUp()
        {
            Actions.SetUpDriver();
        }
        
        [Test]
        public void CheckElementText()
        {
            NavigateTo.ClickToElement();
            Elements elements = new Elements();
            var store = elements.elementsText.Text;
            Assert.AreEqual(Config.GetTexts.elementsText, store, "Successful");
        }
        
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            Driver.driver.Quit();
        }
    }
}