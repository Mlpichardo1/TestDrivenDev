using StringCalc;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        // [SetUp]
        // public void Setup()
        // {
        // }

        [Test]
        public void ifEmptyString_Return0()
        {
            var calc = new Calculator();
            var input = 0;
            var output = calc.CheckEmpty("");

            Assert.AreEqual(output, input);
        }
    }


}