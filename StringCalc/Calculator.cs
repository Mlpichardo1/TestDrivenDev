using System;
using Tests;

namespace StringCalc
{
    public class Calculator
    {
        public int CheckNum(string input)
        {
            var answer = Convert.ToInt32(input);
            return answer;
        }

        public int SumTwoNums(string input)
        {
            var splitInput = input.Split(",");
            
            var sum = Convert.ToInt32(splitInput[0]) + Convert.ToInt32(splitInput[1]);

            return sum;
        }
       

    }
}