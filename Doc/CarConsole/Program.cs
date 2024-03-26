using Calculators;
using CommercialRegistration;
using ConsumerVehicleRegistration;
using LiveryRegistration;

namespace CarConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tollCal = new TollCalculators();

            var car = new Car();
            var taxi = new Taxi();
            var bus = new Bus();
            var truck = new DeliveryTruck();

            Console.WriteLine($"The toll for a car is {tollCal.CalculateToll(car)}");
            Console.WriteLine($"The toll for a taxi is {tollCal.CalculateToll(taxi)}");
            Console.WriteLine($"The toll for a bus is {tollCal.CalculateToll(bus)}");
            Console.WriteLine($"The toll for a truck is {tollCal.CalculateToll(truck)}");

            try
            {
                tollCal.CalculateToll("this will fail");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Caught an argument exception when using the wrong type");
            }
            try
            {
                tollCal.CalculateToll(null!);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Caught an argument exception whe using null");
            }
        }
    }
}
