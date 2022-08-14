using System;
using DemoqaProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace DemoqaProject
{
    public class Program
    {

        private static string baseURL = "https://demoqa.com/";
        private static IWebDriver driver;
        public static void Main(string[] args)
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();

            
            Elements elements = new Elements();
            elements.ValidatePage(driver);
            
            Forms forms = new Forms();
            forms.ValidatePage(driver);
            
            Alerts alerts = new Alerts();
            alerts.ValidatePage(driver);
            
            Widgets widgets = new Widgets();
            widgets.ValidatePage(driver);
            
            Interactions interactions = new Interactions();
            interactions.ValidatePage(driver);
            
            Book book = new Book();
            book.ValidatePage(driver);
        }

    }
}