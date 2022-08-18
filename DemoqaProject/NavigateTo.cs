using System;
using DemoqaProject.PageObjects;
using OpenQA.Selenium;

namespace DemoqaProject
{
    public static class NavigateTo
    {
        public static void ClickToElement()
        {
            HomePage homePage = new HomePage();
            homePage.elementButton.Click();
        }
        
        public static void ClickToForms()
        {
            HomePage homePage = new HomePage();
            homePage.formsButton.Click();
        }
        
        public static void ClickToAlerts()
        {
            HomePage homePage = new HomePage();
            homePage.alertsButton.Click();
        }
        
        public static void ClickToWidgets()
        {
            HomePage homePage = new HomePage();
            homePage.widgetsButton.Click();
        }
        
        public static void ClickToInteractions()
        {
            HomePage homePage = new HomePage();
            homePage.interactionButton.Click();
        }
        
        public static void ClickToBooks()
        {
            HomePage homePage = new HomePage();
            IJavaScriptExecutor js=Driver.driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,950);");
            homePage.bookButton.Click();
        }
    }
}