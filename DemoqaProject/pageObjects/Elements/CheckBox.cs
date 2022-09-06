using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class CheckBox : Elements
    {
        [FindsBy(How = How.ClassName, Using = "rct-checkbox")]
        public IWebElement selectAll;

        [FindsBy(How = How.Id, Using = "result")]
        public IWebElement checkSelectedResult;

        [FindsBy(How = How.XPath, Using = "//button[@class='rct-collapse rct-collapse-btn'][1]")]
        public IWebElement arrowButton;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Desktop']")]
        public IWebElement desktopButton;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Commands']")]
        public IWebElement commandsButton;
        
        [FindsBy(How = How.XPath, Using = "//button[@title='Expand all']")]
        public IWebElement expendAll;
        
        [FindsBy(How = How.XPath, Using = "//button[@title='Collapse all']")]
        public IWebElement collapseAll;
        
        [FindsBy(How = How.XPath, Using = "//span[@class='text-success']")]
        public IList<IWebElement> textSuccess;
        
        [FindsBy(How = How.XPath, Using = "//button[@class='rct-collapse rct-collapse-btn']")]
        public IList<IWebElement> collapseButton;

        public void SelectAll()
        {
            selectAll.Click();
        }
        
        public void Count(int number)
        {
            IList<IWebElement> checkbox = textSuccess;
            Console.WriteLine(checkbox.Count);
            if (checkbox.Count==number)
            {
                Console.WriteLine("Selected all");
            }
            else if (!selectAll.Selected)
            {
                Console.WriteLine("Deselected all");
            }
            selectAll.Click();
        }

        public void SpecificCategories()
        {
            //Select specific category and verify
            arrowButton.Click();
            if (!desktopButton.Selected)
            {
                desktopButton.Click();
                Console.WriteLine("Category Desktop selected");
            }
            else
            {
                Console.WriteLine("Category Desktop not selected");
            }
        }

        public void SelectGroupAndUncheckSub()
        {
            IList<IWebElement> checkbox = collapseButton;
            checkbox[1].Click();
            if (!commandsButton.Selected)
            {
                commandsButton.Click();
                Console.WriteLine("Sub group deselected");
            }
        }

        public void ExpendAndCollapseAll()
        {
            expendAll.Click();
            collapseAll.Click();
        }
    }   
}