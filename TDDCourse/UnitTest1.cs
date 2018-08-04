using System;
using NUnit.Framework;

namespace TDDCourse
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void ifBusinessDay_ReturnDueDate()
        {
            var obj = new Bill();
            var input = new DateTime (2018,8,4);
            var output = obj.CheckDate(input);
            Assert.AreEqual(input, output);
        }

        [Test]
        public void ifSaturday_ReturnMonday()
        {
            var obj = new Bill();
            var input = new DateTime (2018,8,4);
            var output = obj.CheckDate(input);
            Assert.AreEqual(input.AddDays(2), output);

        [Test]
        
        public void ifHoliday_returnNextDay()
        {
            var obj = new Bill();
            var input = new DateTime (2018,12,25);
            var output = obj.CheckDate(input);
            Assert.AreEqual(input.AddDays(1), output);    
        }

    }
}