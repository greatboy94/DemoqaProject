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
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Buttons']")]
        public IWebElement buttons;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Links']")]
        public IWebElement links;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Broken Links - Images']")]
        public IWebElement brokenLinks;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Upload and Download']")]
        public IWebElement uploadAndDownload;
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Dynamic Properties']")]
        public IWebElement dynamicProperties;


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

        public Buttons NavigateToButtons()
        {
            buttons.Click();
            return new Buttons();
        }

        public Links NavigateToLinks()
        {
            links.Click();
            return new Links();
        }
        
        public BrokenLinks NavigateToBrokenLinks()
        {
            brokenLinks.Click();
            return new BrokenLinks();
        }
        
        public UploadAndDownload NavigateToUploadAndDownload()
        {
            JSExecuter(uploadAndDownload);
            uploadAndDownload.Click();
            return new UploadAndDownload();
        }
        
        public DynamicProperties NavigateToDynamicProperties()
        {
            JSExecuter(dynamicProperties);
            dynamicProperties.Click();
            return new DynamicProperties();
        }
    }
}