using System.Globalization;

namespace SwitchProvidesFormatInfo
{
    internal class Program
    {
        static object?[] objects = new object?[]{CultureInfo.CurrentCulture,
                            CultureInfo.CurrentCulture.DateTimeFormat,
                            CultureInfo.CurrentCulture.NumberFormat,
                            new ArgumentException(), null };

        static void Main(string[] args)
        {
            _ = ExecuteAsyncMethods();

            string[] dateStrings = new string[] { "05/01/2018 14:57:32.8", "2018-05-01 14:57:32.8",
                                                  "2018-05-01T14:57:32.8375298-04:00", "5/01/2018",
                                                  "5/01/2018 14:57:32.80 -07:00",
                                                  "1 May 2018 2:57:32.8 PM", "16-05-2018 1:00:32 PM",
                                                  "Fri, 15 May 2018 20:10:57 GMT"};
            foreach(string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, out _))
                    Console.WriteLine($"'{dateString}': valid");
                else
                    Console.WriteLine($"'{dateString}': invalid");
            }

            foreach(var obj in objects)
                ProvidesFormtInfo(obj);


            Method("example");
            Thread.Sleep(60000);

        }
        static void ProvidesFormtInfo(object? obj) =>
            Console.WriteLine(obj switch
            {
                IFormatProvider fmt => $"{fmt.GetType()} object",
                null => "A null object reference",
                _ => "Some object type without form information"
            });
        public static void Method(string arg)
        {
            _ = arg ?? throw new ArgumentException(paramName: nameof(arg), message: "arg can't");
        }
        private static async Task ExecuteAsyncMethods()
        {
            Console.WriteLine("About to launch a task...");
            _ = Task.Run(() =>
            {
                var iteration = 0;
                for (int ctr = 0; ctr < int.MaxValue; ctr++)
                {
                    iteration++;
                }
                Console.WriteLine($"Completed looping operation... {iteration}");
                throw new InvalidOperationException();
            });
            await Task.Delay(5000);
            Console.WriteLine("Exiting after 5 second delay");
        }
    }
}