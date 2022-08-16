using System;
using DemoqaProject.PageObjects;

namespace DemoqaProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Driver.driver.Navigate().GoToUrl(Config.baseURL);
            Driver.driver.Manage().Window.Maximize();

            HomePage homePage = new HomePage();
            homePage.elementButton.Click();
           
        }

    }
}