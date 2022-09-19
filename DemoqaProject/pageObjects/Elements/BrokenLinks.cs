using System.Net;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class BrokenLinks : Elements
    {
        [FindsBy(How = How.XPath, Using = "//img[@src='/images/Toolsqa.jpg']")]
        public IWebElement validImage;
        
        public async Task ValidImage()
        {
            int broken_images = 0; 
            using var client = new HttpClient(); 
            var image_list = driver.FindElements(By.TagName("img"));
            
            foreach (var img in image_list)
            {
                HttpResponseMessage response = await client.GetAsync(img.GetAttribute("src"));
                if (response.StatusCode == HttpStatusCode.OK) 
                { 
                    Console.WriteLine("Image at the link " + img.GetAttribute("src") + " is OK, status is " + response.StatusCode);
                }
                else 
                { 
                    Console.WriteLine("Image at the link " + img.GetAttribute("src") + " is Broken, status is " + response.StatusCode); 
                    broken_images++;
                }
            }
        }
    }
}