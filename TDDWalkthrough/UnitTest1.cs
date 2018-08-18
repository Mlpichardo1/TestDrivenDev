using NUnit.Framework;
using TDDWalkthrough;

namespace Tests
{
    [TestFixture]
    public class CreditCardTesting
    {

        [Test]
        public void IfCreditCardNumberIsEmpty_ReturnException()
        {
            var card = new CreditCardVerifier();
            var input = card.Verify("");
            var expected = "0";

            Assert.AreEqual(expected, input);
        }


    }
}

