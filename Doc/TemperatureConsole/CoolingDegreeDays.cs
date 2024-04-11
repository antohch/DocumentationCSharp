using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConsole
{ 
    public sealed record CoolingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> Temperatures)
        : DegreeDays(BaseTemperature, Temperatures)
    {
        public double DegreeDays => Temperatures.Where(s => s.Mean > BaseTemperature).Sum(s => s.Mean - BaseTemperature);
    }
}
