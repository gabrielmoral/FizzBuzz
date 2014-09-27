using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using FizzBuzz.Infrastructure;

namespace FizzBuzz.Application
{
    public class FizzBuzzFile
    {
        private FizzBuzzer fizzBuzz;

        private IFizzBuzzFileRepository fizzBuzzFileRepository;

        public FizzBuzzFile(IFizzBuzzFileRepository fizzBuzzFileRepository, IAppSettingsRepository appSettingsRepository)
        {
            int limit = appSettingsRepository.GetLimitValue();

            this.fizzBuzzFileRepository = fizzBuzzFileRepository;
            this.fizzBuzz = new FizzBuzzer(limit);
        }

        public void SetResultsInFile(int startNumber)
        {
            var resultList = this.fizzBuzz.Build(startNumber);

            if (resultList.Any())
            {
                this.fizzBuzzFileRepository.Save(resultList);
            }
        }
    }
}