using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SelQA
{
    public class UnitTest1
    {
        IWebDriver driver;

        // How to set an alert
        public bool isAlertPresent()
        {
            
            try 
            {
                
                driver.SwitchTo().Alert();
                return true;
                {
                   catch (Exception e)
                   return false;
                }
            }

        }
        
        public void SelQuestionsA()
        {
            IWebDriver driver;
            driver = new FirefoxDriver();

            // Accept an alert
            driver.SwitchTo().Alert().Accept();
            // Dismiss an alert
            driver.SwitchTo().Alert().Dismiss();

            // Getting the text of the alert
            var alert = driver.SwitchTo().Alert();
            System.Console.WriteLine(alert.Text); // changed GetText to GetType

            // Selecting a Frame
            driver.SwitchTo().Frame(0);
            driver.SwitchTo().Frame("frame");
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("")));

            // Getting Widow Handles
            String pwindow = driver.CurrentWindowHandle; // get parent window handle unique ID
            List<string> allWindows = driver.WindowHandles.ToList(); // get all window handles
            foreach(var allWindow in allWindows)
            {
                System.Console.WriteLine(allWindow);
            }

            String ParentWindow = allWindow.next(); // First Window
            driver.SwitchTo().Window(ParentWindow); // Switching to First Window

            String ChildWindow = allWindow.next(); // Second Window
            driver.SwitchTo().Window(ChildWindow);

            // How to get back to the Parent Window
            driver.SwitchTo().DefaultContent();

            // Implicit Wait and Explicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        // public void Test2()
        // {

        // }
    }  
}