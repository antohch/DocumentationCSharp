using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConsole;

namespace TemperatureConsole
{
    public abstract record DegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
    {
        protected virtual bool PrintMembers(StringBuilder stringBuilder)
        {
            stringBuilder.Append($"BaseTemperature = {BaseTemperature}");
            return true;
        }
    }
}
