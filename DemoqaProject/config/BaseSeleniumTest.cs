using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace DemoqaProject
{
    public class BaseSeleniumTest
    {
        protected IWebDriver driver;
        public static string? RunningPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString())?.ToString();
        string myDownloadFolder = Path.GetFullPath(Path.Combine(RunningPath ?? string.Empty, $"files{Path.DirectorySeparatorChar}"));

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            var options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", myDownloadFolder);
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad=(TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(10));
            BaseSeleniumPage.SetDriver(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }    
}