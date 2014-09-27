using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        private int limitResults;

        public FizzBuzzer(int limitResults)
        {
            this.limitResults = limitResults;
        }

        public List<string> Build(int startNumber)
        {
            List<string> results = new List<string>();

            var limitNumber = this.limitResults + startNumber;

            for (int number = startNumber; number < limitNumber; number++)
            {
                results.Add(FizzBuzzerNumber.Convert(number));
            }

            return results;
        }
    }
}   