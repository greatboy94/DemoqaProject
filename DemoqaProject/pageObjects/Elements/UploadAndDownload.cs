using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System.IO;

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

        //public string downloadURL = "C:\\Users\\great\\Downloads\\sampleFile.jpeg";
        public static string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
        public string uploadURL = string.Format("{0}files\\sampleFile.jpeg", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\..\")));

        public void DownloadFile()
        {
            string myDownloadFolder = "C:\\Users\\great\\RiderProjects\\DemoqaProject\\DemoqaProject\\files";
            var options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", myDownloadFolder);
            driver = new ChromeDriver();
            downloadButton.Click();
        }

        public void UploadFile()
        {
            uploadButton.SendKeys(uploadURL);
        }
    }
}