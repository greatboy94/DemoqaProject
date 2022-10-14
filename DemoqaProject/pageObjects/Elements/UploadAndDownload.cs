using OpenQA.Selenium;
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
        
        private static string? RunningPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString())?.ToString();
        public string uploadURL = Path.GetFullPath(Path.Combine(RunningPath ?? string.Empty, $"files{Path.DirectorySeparatorChar}sampleFile.jpeg"));
        

        public void DownloadFile()
        {
            downloadButton.Click();
            WaitInterval(downloadButton);
        }

        public void UploadFile()
        {
            uploadButton.SendKeys(uploadURL);
        }
    }
}