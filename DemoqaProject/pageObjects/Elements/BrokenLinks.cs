using System.Net;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DemoqaProject.PageObjects
{
    public class BrokenLinks : Elements
    {
        [FindsBy(How = How.XPath, Using = "//img[@src='/images/Toolsqa.jpg']")]
        public IWebElement validImage;
        
        [FindsBy(How = How.TagName, Using = "a")]
        public IList<IWebElement> links;
        
        [FindsBy(How = How.TagName, Using = "img")]
        public IList<IWebElement> imageList;
        
        public async Task ValidImage()
        {
            int brokenImages = 0; 
            using var client = new HttpClient();

            foreach (var img in imageList)
            {
                HttpResponseMessage response = await client.GetAsync(img.GetAttribute("src"));
                if (response.StatusCode == HttpStatusCode.OK) 
                { 
                    Console.WriteLine("Image at the link " + img.GetAttribute("src") + " is OK, status is " + response.StatusCode);
                }
                else 
                { 
                    Console.WriteLine("Image at the link " + img.GetAttribute("src") + " is Broken, status is " + response.StatusCode); 
                    brokenImages++;
                }
            }
        }

        public async Task ValidAndInvalidLinks()
        {
            int validLinks = 0, brokenLinks = 0;
            using var client = new HttpClient();

            foreach (var link in links)
            {
                if (!(link.Text == "" || link.Equals(null)))
                {
                    HttpResponseMessage response = await client.GetAsync(link.GetAttribute("href"));
                    Console.WriteLine($"URL: {link.GetAttribute("href")} status is :{response.StatusCode}");
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        validLinks++;
                    }
                    else
                    { 
                        brokenLinks++;
                    }
                }
            }
            Console.WriteLine("Found Valid URL: " + validLinks);
            Console.WriteLine("Found Invalid URL: " + brokenLinks);
        }
    }
}