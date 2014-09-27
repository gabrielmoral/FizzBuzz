using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    internal class FizzBuzzerNumber
    {
        private const string FIZZ = "fizz";
        private const string BUZZ = "buzz";
        private const string FIZZBUZZ = "fizzbuzz";

        private const int THREE = 3;
        private const int FIVE = 5;

        public static string Convert(int number)
        {
            string result = String.Empty;

            if (IsFizz(number))
            {
                result = FIZZ;
            }

            if (IsBuzz(number))
            {
                result += BUZZ;
            }

            if (string.IsNullOrEmpty(result))
            {
                result = number.ToString();
            }

            return result;
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
