﻿namespace TemperatureConsole
{
    internal class Program
    {
        public static int MaxSequence(int[] arr)
        {
            //TODO : create code
            Array.Sort(arr);
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    if (i + 1 < arr.Length)
                    {
                        if (Math.Abs(arr[i]) - Math.Abs(arr[i + 1]) != 1)
                        {
                            if (arr[i] > 0)
                                max += arr[i];
                            else
                                max += arr[i + 1];
                        }
                    }
                    else
                    {
                        max += arr[i];
                    }
                }
                else if (arr[i] < 0)
                {
                    if (arr[i] < 0 && arr[i+1] > 0)
                    {
                        max += arr[i];
                    }
                    else if (Math.Abs(arr[i]) - Math.Abs(arr[i + 1]) != 1)
                    {
                        if (arr[i] < 0)
                            max += arr[i];

                    }
                }
            }
            return max;
        }








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

            var heatingDegreeDays = new HeatingDegreeDays(65, data);
            Console.WriteLine(heatingDegreeDays);
            var coolingDegreeDays = new CoolingDegreeDays(65, data);
            Console.WriteLine(coolingDegreeDays);

            var growingDegreeDays = coolingDegreeDays with { BaseTemperature = 41 };
            Console.WriteLine(growingDegreeDays);
            Console.WriteLine(coolingDegreeDays);

            List<CoolingDegreeDays> movingAccumulation = new();
            int rangeSize = (data.Length > 5) ? 5 : data.Length;
            for (int start = 0; start < data.Length - rangeSize; start++)
            {
                var fiveDayTotal = growingDegreeDays with { TempRecords = data[start..(start + rangeSize)] };
                movingAccumulation.Add(fiveDayTotal);
            }
            Console.WriteLine();
            Console.WriteLine("Total degree days in the last fime days");
            foreach(var item in movingAccumulation)
            {
                Console.WriteLine(item);
            }




            Console.WriteLine(MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
    }
}
