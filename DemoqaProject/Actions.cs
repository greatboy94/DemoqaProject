using System;
using DemoqaProject.PageObjects;
using OpenQA.Selenium;

namespace DemoqaProject
{
    public static class Actions
    {
        public static void SetUpDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.baseURL);
            Driver.driver.Manage().Window.Maximize();
        }
    }
}