using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConsole;

namespace TemperatureConsoleTest
{
    public abstract record DegreeDaysTest(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords);
}
