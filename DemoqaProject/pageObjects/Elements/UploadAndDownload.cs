using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class UploadAndDownload : Elements
    {
        [FindsBy(How = How.Id, Using = "downloadButton")]
        public IWebElement downloadButton;

        public string downloadURL = "C:\\Users\\great\\Downloads\\sampleFile.jpeg";


        public void DownloadFile()
        {
            String myDownloadFolder = @"C:\Users\great\Downloads";
            var options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", myDownloadFolder);
            downloadButton.Click();
        }
    }
}