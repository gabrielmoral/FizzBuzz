using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Application
{
    public interface IAppSettingsRepository
    {
        int GetLimitValue();
    }
}