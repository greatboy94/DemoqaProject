using System;
using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class Program
    {

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
            Assert.AreEqual(Config.GetTexts.elementsText, store);
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
        }
        
        [Test]
        public void CheckFormsText()
        {
            NavigateTo.ClickToForms();
            Forms forms = new Forms();
            var store = forms.FormsText.Text;
            Assert.AreEqual(Config.GetTexts.formsText, store);
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
        }
        
        [Test]
        public void CheckAlertsText()
        {
            NavigateTo.ClickToAlerts();
            Alerts alerts = new Alerts();
            var store = alerts.AlertsText.Text;
            Assert.AreEqual(Config.GetTexts.alertsText, store);
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
        }
        
        [Test]
        public void CheckWidgetsText()
        {
            NavigateTo.ClickToWidgets();
            Widgets widgets = new Widgets();
            var store = widgets.WidgetsText.Text;
            Assert.AreEqual(Config.GetTexts.widgetsText, store);
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
        }
        
        [Test]
        public void CheckInteractionsText()
        {
            NavigateTo.ClickToInteractions();
            Interactions interactions = new Interactions();
            var store = interactions.InteractionsText.Text;
            Assert.AreEqual(Config.GetTexts.interactionText, store);
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
        }
        
        [Test]
        public void CheckBookText()
        {
            NavigateTo.ClickToBooks();
            Book book = new Book();
            var store = book.BookText.Text;
            Assert.AreEqual(Config.GetTexts.bookText, store);
            Thread.Sleep(2000);
            Driver.driver.Navigate().Back();
        }
        
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            Driver.driver.Quit();
        }
    }
}