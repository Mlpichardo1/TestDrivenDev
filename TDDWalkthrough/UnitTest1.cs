using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void ifNameIsBob_ReturnGreeting()
        {
            string input = "";
            Assert.AreSame("Bob", input);
        }
    }
}