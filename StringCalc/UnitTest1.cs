using StringCalc;
using NUnit.Framework;
using System;

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

        [Test]
        public void ifSingleNumber_ReturnSingleNumber([Values("1", "2", "3", "4", "5")] 
        string singleNum)
        {
            var calc = new Calculator();
            var input = calc.CheckNum(singleNum);

            Assert.AreEqual(Convert.ToInt32(singleNum), input);
        }

        // Two numbers, comma delimited, returns the sum
        [TestCase(3, "1,2")]
        [TestCase(6, "4,2")]
        [TestCase(10, "5,5")]

        public void TwoNumbers_CommaDelimited_ReturnSum(int expected, string twoNums)
        {
            

            var calc = new Calculator();
            // var input = calc.SumTwoNums(twoNums);

            Assert.AreEqual(expected, calc.SumTwoNums(twoNums));
        }

        
    }


}