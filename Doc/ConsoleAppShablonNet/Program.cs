using System;
using System.Diagnostics;

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
            TransactionRead();
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
        static string[][] ReadRecords()
        {
            return new string[][]
            {
                new string[]{ "04-01-2020", "DEPOSIT",    "Initial deposit","2250,00"},
                new string[]{"04-15-2020", "DEPOSIT",    "Refund",                      "125,65" },
                new string[]{"04-18-2020", "DEPOSIT",    "Paycheck",                    "825,65" },
                new string[]{"04-22-2020", "WITHDRAWAL", "Debit",           "Groceries", "255,73" },
                new string[]{"05-01-2020", "WITHDRAWAL", "#1102",           "Rent, apt", "2100,00" },
                new string[]{"05-02-2020", "INTEREST",                                  "0,65" },
                new string[]{"05-07-2020", "WITHDRAWAL", "Debit",           "Movies",      "12,57" },
                new string[]{"04-15-2020", "FEE",                                       "5,55" }
            };
        }
        static void TransactionRead()
        {
            decimal balance = 0m;
            foreach (string[] transaction in ReadRecords())
            {
                balance += transaction switch
                {
                    [_, "DEPOSIT", _, var amount] => decimal.Parse(amount),
                    [_, "WITHDRAWAL", .., var amount] => -decimal.Parse(amount),
                    [_, "INTEREST", var amount] => decimal.Parse(amount),
                    [_, "FEE", var fee] => -decimal.Parse(fee),
                    _ => throw new InvalidOperationException($"Record{string.Join(", ", transaction)} is not in the expected format"),
                };
                Console.WriteLine($"Record: {string.Join(", ", transaction)}, New balance: {balance:C}");
            }
        }
    }
}