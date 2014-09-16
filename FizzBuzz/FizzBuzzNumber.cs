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

        public static string Convert(int number)
        {
            if (IsNumberDivisibleByThreeAndFive(number))
            {
                return FIZZBUZZ;
            }
            else if (IsNumberDivisibleByThree(number))
            {
                return FIZZ;
            }
            else if (IsNumberDivisibleByFive(number))
            {
                return BUZZ;
            }
            else
            {
                return number.ToString();
            }
        }

        private static bool IsNumberDivisibleByThreeAndFive(int number)
        {
            return IsNumberDivisibleByThree(number) && IsNumberDivisibleByFive(number);
        }

        private static bool IsNumberDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        private static bool IsNumberDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}
