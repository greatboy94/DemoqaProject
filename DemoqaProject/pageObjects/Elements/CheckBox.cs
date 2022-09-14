using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class CheckBox : Elements
    {
        
        public List<string> expectedTexts = new List<string>() {"desktop", "notes", "commands"};
        public List<string> commandsText = new List<string>() {"commands"};

        [FindsBy(How = How.ClassName, Using = "rct-checkbox")]
        public IWebElement selectAll;

        [FindsBy(How = How.XPath, Using = "//button[@class='rct-collapse rct-collapse-btn'][1]")]
        public IWebElement arrowButton;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Desktop']")]
        public IWebElement desktopButton;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Commands']")]
        public IWebElement commandsButton;

        [FindsBy(How = How.XPath, Using = "//span[@class='text-success']")]
        public IList<IWebElement> textSuccess;
        
        [FindsBy(How = How.XPath, Using = "//button[@class='rct-collapse rct-collapse-btn']")]
        public IList<IWebElement> collapseButton;

        public void SelectAll()
        {
            selectAll.Click();
        }

        public List<string> SelectSpecificCategories()
        {
            arrowButton.Click();
            desktopButton.Click();
            List<string> storeTexts = new List<string>();
            IList<IWebElement> getTexts = textSuccess;
            foreach (var el in getTexts)
            {
                storeTexts.Add(el.Text);
            }
            return storeTexts;
        }

        public List<string> SelectGroupAndUncheckSub()
        {
            IList<IWebElement> checkbox = collapseButton;
            checkbox[0].Click();
            checkbox[1].Click();
            commandsButton.Click();
            List<string> storeTexts = new List<string>();
            IList<IWebElement> getTexts = textSuccess;
            foreach (var el in getTexts)
            {
                storeTexts.Add(el.Text);
            }
            return storeTexts;
        }
    }   
}