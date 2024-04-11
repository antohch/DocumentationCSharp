using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConsole;

namespace TemperatureConsoleTest
{
    public class HeatingDegreeDaysTest 
    {
        [Test]
        public void DegreeDaysTest()
        {
            DailyTemperature[] tempRecords = [ 
                new DailyTemperature(20, 10),
                new DailyTemperature(60, 35)
                ];
            var heatingDegreeDays = new HeatingDegreeDays(35, tempRecords);
            Assert.That(heatingDegreeDays.DegreeDays, Is.EqualTo(20));
        }
    }
   
}
