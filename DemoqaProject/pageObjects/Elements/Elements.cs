using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class Elements : BaseSeleniumPage
    {

        [FindsBy(How = How.XPath, Using = "//span[text()='Text Box']")]
        public IWebElement textBoxButton;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Check Box']")]
        public IWebElement checkBoxButton;

        [FindsBy(How = How.XPath, Using = "//span[text()='Radio Button']")]
        public IWebElement radioButton;

        [FindsBy(How = How.XPath, Using = "//span[text()='Web Tables']")]
        public IWebElement webTablesButton;
        
        
        

        public Elements()
        {
            PageFactory.InitElements(driver, this);
        }
        
        public TextBox NavigateToTextBox()
        {
            textBoxButton.Click();
            return new TextBox();
        }

        public CheckBox NavigateToCheckBox()
        {
            checkBoxButton.Click();
            return new CheckBox();
        }

        public RadioButton NavigateToRadioButton()
        {
            radioButton.Click();
            return new RadioButton();
        }

        public WebTables NavigateToWebTables()
        {
            webTablesButton.Click();
            return new WebTables();
        }

        
    }
}