using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class UploadAndDownload : Elements
    {
        public string expectedText = "C:\\fakepath\\sampleFile.jpeg";
        
        [FindsBy(How = How.Id, Using = "downloadButton")]
        public IWebElement downloadButton;

        [FindsBy(How = How.Id, Using = "uploadFile")]
        public IWebElement uploadButton;
        
        [FindsBy(How = How.Id, Using = "uploadedFilePath")]
        public IWebElement uploadedFilePath;

        public string downloadURL = "C:\\Users\\great\\Downloads\\sampleFile.jpeg";
        public string uploadURL = "C:\\Users\\great\\RiderProjects\\DemoqaProject\\DemoqaProject\\files\\sampleFile.jpeg";


        public void DownloadFile()
        {
            string myDownloadFolder = @"C:\Users\great\Downloads";
            var options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", myDownloadFolder);
            downloadButton.Click();
        }

        public void UploadFile()
        {
            uploadButton.SendKeys(uploadURL);
        }
    }
}