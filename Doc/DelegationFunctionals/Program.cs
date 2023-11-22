using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationFunctionals
{
    delegate double Function(double x);
    class Multiplier 
    {
        double _factor;
        public Multiplier(double factor) => _factor = factor;
        public double Multiply(double x) => x * _factor;
    }
    internal class Program
    {
        static double[] Apply(double[] a, Function f)
        {
            var result = new double[a.Length];
            for(int i = 0; i < a.Length; i++) result[i] = f(a[i]);
            return result;
        }
        static void Main(string[] args)
        {
            double[] a = { 0.0, 0.5, 1.0 };
            double[] squares = Apply(a, (x) => x * x);
            Multiplier m = new Multiplier(2.0);
            double[] doubles = Apply(a, m.Multiply);
            double[] sins = Apply(a, Math.Sin);

            foreach (var item in a) Console.WriteLine($"a=" + item);
            foreach (var item in squares) Console.WriteLine($"squares=" + item);
            foreach (var item in doubles) Console.WriteLine($"doubles=" + item);

            Console.ReadKey();
        }
    }
}
