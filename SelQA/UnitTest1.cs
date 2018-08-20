using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
    
        // How to set an alert
        [Test]
        public void Test1()
        {
            IWebDriver driver = new FirefoxDriver();

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
}