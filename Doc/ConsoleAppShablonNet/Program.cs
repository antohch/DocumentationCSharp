using System;

namespace ConsoleAppShablonNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? message = "Message";
            if (message is null)
            {
                Console.WriteLine(message);
            }
            List<string> list = new List<string>();
            list.Add("Message");

            Console.WriteLine(MidPoint(list));
            Console.WriteLine(WaterState(12));
            Console.WriteLine(WaterState2(213));
            Console.WriteLine(CalculateDiscount(new Order(6, 501.00m)));
        }
        public static T MidPoint<T>(IEnumerable<T> sequence)
        {
            if (sequence is IList<T> list)
            {
                return list[list.Count / 2];
            }
            else if (sequence is null)
            {
                throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
            }
            else
            {
                int halfLength = sequence.Count() / 2 - 1;
                if (halfLength < 0)
                {
                    halfLength = 0;
                }
                return sequence.Skip(halfLength).First();
            }
        }
        public State PerformOperation(Operation command) =>
        command switch
        {
            Operation.SystemTest => RunDiagnostics(),
            Operation.Start => StartSystem(),
            Operation.Stop => StopSystem(),
            Operation.Reset => ResetToReady(),
            _ => throw new ArgumentException("Invalid enum value for command", nameof(command)),
        };
        public State PerformOperation2(ReadOnlySpan<char> command) =>
        command switch
        {
            "SystemTest" => RunDiagnostics(),
            "Start" => StartSystem(),
            "Stop" => StopSystem(),
            "Reset" => ResetToReady(),
            _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
        };
        private State ResetToReady()
        {
            throw new NotImplementedException();
        }

        private State StopSystem()
        {
            throw new NotImplementedException();
        }

        private State StartSystem()
        {
            throw new NotImplementedException();
        }

        private State RunDiagnostics()
        {
            throw new NotImplementedException();
        }
        static string WaterState(int tempInFaharenheit) =>
            tempInFaharenheit switch
            {
                (> 32) and (< 212) => "liquid",
                < 32 => "solid",
                > 212 => "gas",
                32 => "solid/liquid transition",
                212 => "liquid / gas transition",
            };
        static string WaterState2(int tempInFaharenheit) =>
        tempInFaharenheit switch
        {
            < 32 => "solid",
            32 => "solid/liquid transition",
            < 212 => "liquid",
            212 => "liquid / gas transition",
            _ => "gas",
        };
        static decimal CalculateDiscount(Order order) =>
            order switch
            {
                { Items: > 10, Cost: > 1000.00m } => 0.10m,
                { Items: > 5, Cost: > 500.00m } => 0.05m,
                { Cost: > 250.00m } => 0.02m,
                null => throw new ArgumentNullException(nameof(order), "Can't calculate"),
                var someObject => 0m,
            };
    }
}