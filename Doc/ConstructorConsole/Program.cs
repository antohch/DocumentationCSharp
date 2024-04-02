using System.Numerics;

namespace ConstructorConsole
{
    public interface IGetNext<T> where T : IGetNext<T>
    {
        static abstract T operator ++(T other);
    }
    internal class Program
    {

        public static double MidPoint(double left, double right) =>
            (left + right) / (2.0);

        public static T MidPoint<T>(T left, T right)
            where T : INumber<T> => (left + right) / T.CreateChecked(2);

        static void Main(string[] args)
        {
            var str = new RepeatSequence();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(str++);
            }
        }
    }
}
