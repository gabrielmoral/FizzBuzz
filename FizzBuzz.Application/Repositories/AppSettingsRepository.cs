using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace FizzBuzz.Application
{
    public class AppSettingsRepository : IAppSettingsRepository
    {
        public int GetLimitValue()
        {
            return int.Parse(ConfigurationManager.AppSettings["limitValue"]);
        }
    }
}