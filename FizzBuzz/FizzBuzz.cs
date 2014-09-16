using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {

        private int limit;

        public FizzBuzz(int limit)
        {  
            this.limit = limit;
        }
        public List<string> GetResult(int startNumber)
        {
            List<string> results = new List<string>();

            var limitNumber = this.limit + startNumber;

            for (int number = startNumber; number < limitNumber; number++)
            {   
                results.Add(FizzBuzzNumber.Convert(number));
            }

            return results;
        }
    }
}
