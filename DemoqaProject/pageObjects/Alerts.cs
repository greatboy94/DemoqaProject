using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Alerts : BaseSeleniumPage
    {
        
        public Alerts() 
        { 
            PageFactory.InitElements(driver, this);
        }
    }
}