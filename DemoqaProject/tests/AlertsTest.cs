using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class AlertsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckAlertsText()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToAlertsPage();
            Alerts alerts = new Alerts();
            Assert.AreEqual(StoreElementTexts.alertsText, alerts.GetHeaderText());
        }
    }   
}