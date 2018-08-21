using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SelQA
{
    public class UnitTestPractice
    {
        class HandleMultipleWindows
    {
        [Test]
        public void Test()
        { 
			IWebDriver driver = new FirefoxDriver();
			driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";
 
			// Store the parent window of the driver
			String parentWindowHandle = driver.CurrentWindowHandle;
			Console.WriteLine("Parent window's handle -> " + parentWindowHandle);
 
			IWebElement clickElement = driver.FindElement(By.Id("button1"));
 
			// Multiple click to open multiple window
			for (var i = 0; i < 3; i++)
			{
				clickElement.Click();
				Thread.Sleep(3000);
			}
 
			// Store all the opened window into the 'list' 
			List<string> lstWindow = driver.WindowHandles.ToList();
 
			// Traverse each and every window 
			foreach (var handle in lstWindow)
			{
				Console.WriteLine("Switching to window - > " + handle);
				Console.WriteLine("Navigating to google.com");
 
				//Switch to the desired window first and then execute commands using driver
				driver.SwitchTo().Window(handle); 
				driver.Navigate().GoToUrl("http://google.com");
			}
			
        }
    }
    }
}