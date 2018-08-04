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
            var input = calc.CheckNum("");

            Assert.AreEqual(0, input);
        }

        // [Test]
        // public void ifSingleNumber_ReturnValue()
        // {
        //     var calc = new Calculator();
        //     var output = 3;
        //     var input = calc.CheckThree("3");

        //     Assert.AreEqual(output, input);
        // }
    }


}