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

        }

        public void Test2()
        {

        }
    }  
}