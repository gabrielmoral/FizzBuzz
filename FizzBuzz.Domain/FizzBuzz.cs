using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private int limitResults;

        public FizzBuzz(int limitResults)
        {
            this.limitResults = limitResults;
        }

        public List<string> GetResult(int startNumber)
        {
            List<string> results = new List<string>();

            var limitNumber = this.limitResults + startNumber;

            for (int number = startNumber; number < limitNumber; number++)
            {
                results.Add(FizzBuzzNumber.Convert(number));
            }

            return results;
        }
    }
}