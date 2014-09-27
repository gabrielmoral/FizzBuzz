using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    internal class FizzBuzzNumber
    {
        private const string FIZZ = "fizz";
        private const string BUZZ = "buzz";
        private const string FIZZBUZZ = "fizzbuzz";

        private const int THREE = 3;
        private const int FIVE = 5;
        
        public static string Convert(int number)
        {
            if (IsFizzBuzz(number))
            {
                return FIZZBUZZ;
            }
            else if (IsFizz(number))
            {
                return FIZZ;
            }
            else if (IsBuzz(number))
            {
                return BUZZ;
            }
            else
            {
                return number.ToString();
            }
        }

        private static bool IsFizzBuzz(int number)
        {
            return IsNumberDivisibleBy(number, THREE) && IsNumberDivisibleBy(number, FIVE);
        }

        private static bool IsFizz(int number)
        {
            return IsNumberDivisibleBy(number, THREE);
        }

        private static bool IsBuzz(int number)
        {
            return IsNumberDivisibleBy(number, FIVE);
        }

        private static bool IsNumberDivisibleBy(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
