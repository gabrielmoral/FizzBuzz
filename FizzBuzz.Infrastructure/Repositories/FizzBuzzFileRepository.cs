using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace FizzBuzz.Infrastructure
{
    public class FizzBuzzFileRepository : IFizzBuzzFileRepository
    {
        private static ReaderWriterLock objLock= new ReaderWriterLock(); 

        public void Save(List<string> resultList)
        {
            using (var file = File.CreateText(@"c:\FizzBuzzResults.txt"))
            {
                var fizzBuzzResult = string.Join(" ", resultList.ToArray());
                var line = string.Format("{0} {1}", fizzBuzzResult, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff"));
                file.WriteLine(line);
            }
        }
    }
}