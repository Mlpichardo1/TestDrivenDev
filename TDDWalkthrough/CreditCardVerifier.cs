using System;

namespace TDDWalkthrough
{
    public class CreditCardVerifier
    {
        public bool Verify(string numbers)
        {
            return IsCreditCardLengthRule(numbers, 13);
        }

        private bool IsCreditCardLengthRule(string numbers, int length)
        {
            if(numbers.Length <= length)
                throw new Exception("Length Rule Violation. Password shuld be of more than characters length.");
            return false;
        }
    }
}
 