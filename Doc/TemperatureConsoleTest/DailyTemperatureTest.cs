using TemperatureConsole;

namespace TemperatureConsoleTest
{
    public class DailyTemperatureTest
    {
        DailyTemperature[] data = [
                new DailyTemperature(HighTemp: 57, LowTemp: 30),
                new DailyTemperature(60, 35),
                new DailyTemperature(63, 33),
                new DailyTemperature(68, 29),
                new DailyTemperature(72, 47),
                new DailyTemperature(75, 55),
                new DailyTemperature(77, 55),
                new DailyTemperature(72, 58),
                new DailyTemperature(70, 47),
                new DailyTemperature(77, 59),
                new DailyTemperature(85, 65),
                new DailyTemperature(87, 65),
                new DailyTemperature(85, 72),
                new DailyTemperature(83, 68),
                new DailyTemperature(77, 65),
                new DailyTemperature(72, 58),
                new DailyTemperature(77, 55),
                new DailyTemperature(76, 53),
                new DailyTemperature(80, 60),
                new DailyTemperature(85, 66)
            ];
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 57)]
        [TestCase(1, 60)]
        [TestCase(2, 63)]
        public void ForeachTest(int i, int expect)
        {
            Assert.That(data[i].HighTemp, Is.EqualTo(expect));
        }
        [TestCase(0, 43.5d)]
        public void Mean(int i, double expect)
        {
            Assert.That(data[i].Mean, Is.EqualTo(expect));
        }
    }
}