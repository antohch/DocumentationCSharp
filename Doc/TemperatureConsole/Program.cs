namespace TemperatureConsole
{
    internal class Program
    {
        private static DailyTemperature[] data = [
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
        static void Main(string[] args)
        {
            foreach (var item in data)
                Console.WriteLine(item);
        }
    }
}
