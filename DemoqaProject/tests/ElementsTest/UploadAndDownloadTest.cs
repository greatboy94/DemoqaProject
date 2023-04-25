using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class UploadAndDownloadTest : BaseSeleniumTest
    {
        [Test]
        public void CheckDownload()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            UploadAndDownload uploadAndDownload = new UploadAndDownload(driver);
            uploadAndDownload.NavigateToUploadAndDownload();
            
            uploadAndDownload.DownloadFile();
            Assert.IsTrue(File.Exists(uploadAndDownload.uploadURL));
        }
        
        [Test]
        public void CheckUpload()
        {
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToElementPage();
            UploadAndDownload uploadAndDownload = new UploadAndDownload(driver);
            uploadAndDownload.NavigateToUploadAndDownload();
            
            uploadAndDownload.UploadFile();
            Thread.Sleep(5000);
            Assert.AreEqual(uploadAndDownload.expectedText, uploadAndDownload.uploadedFilePath.Text);
        }
    }
}