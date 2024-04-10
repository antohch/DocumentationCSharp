using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public readonly record struct DailyTemperature(double HighTemp, double LowTemp);
}
