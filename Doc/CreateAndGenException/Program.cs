using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndGenException
{
    internal class Program
    {
        static void CopyObject(SampleClass original)
        {
            _ = original ?? throw new ArgumentException("Parameter cannot be null", nameof(original));
        }
        static void Main(string[] args)
        {
        }
    }
}
