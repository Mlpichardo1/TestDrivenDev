using NUnit.Framework;

namespace Tests
{
    public class Tests
    {

        // How to set an alert
        public bool isAlertPresent()
        {
            WebDriver driver;
            try 
            {
                driver.switchTo().alert();
                return true
                {
                   catch (Eexception e)
                   return false
                }
            }

        }

        [Test]
        public void Test1()
        {
            driver = new FirefoxDriver();

            // Accept an alert
            driver.switchTo().alert().Accept();
            // Dismiss an alert
            driver.switchTo().alert().Dismiss();

            // Getting the text of the alert
            Alert text = driver.switchTo().alert();
            System.Console.WriteLine(text.getText());

            // Selecting a Frame
            dirver.switchTo().Frame(0);
            driver.switchTo().Frame("frame");
            driver.switchTo().Frame(driver.findElement(By.xpath("")));

            // Getting Widow Handles
            String pwindow = driver.getWindowHandle(); // get parent window handle unique ID
            Set<String> allWindows = driver.getWindowHandles(); // get all window handles
            Iterator<String> allWindow allWindows.iterator();

            String ParentWindow = allWindow.next(); // First Window
            driver.switchTo().window(ParentWindow); // Switching to First Window

            String ChildWindow = allWindow.next(); // Second Window
            driver.switchTo().window(ChildWindow);

            // How to get back to the Parent Window
            driver.switchTo().defaultContent();

            // Implicit Wait and Explicit Wait
            
        }

        public void Test2()
        {

        }
    }  
}