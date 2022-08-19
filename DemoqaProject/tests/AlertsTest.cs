using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class AlertsTest : BaseSeleniumTest
    {
        [Test]
        public void CheckAlertsText()
        {
            String getHeader = Config.alertsText;
            HomePage homePage = new HomePage();
            Alerts alerts = new Alerts();
            homePage.ClickAlert();
            Assert.AreEqual(getHeader, alerts.GetHeaderText());
        }
    }   
}