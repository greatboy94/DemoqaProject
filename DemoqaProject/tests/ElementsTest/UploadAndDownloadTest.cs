using DemoqaProject.PageObjects;
using NUnit.Framework;

namespace DemoqaProject
{
    public class UploadAndDownloadTest : BaseSeleniumTest
    {
        [Test]
        public void CheckDownload()
        {
            HomePage homePage = new HomePage();
            homePage.NavigateToElementPage();
            UploadAndDownload uploadAndDownload = new UploadAndDownload();
            uploadAndDownload.NavigateToUploadAndDownload();
            
            uploadAndDownload.DownloadFile();
            Assert.IsTrue(File.Exists(uploadAndDownload.downloadURL));
        }
    }
}