using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionTest
{
    internal class Program
    {
        static void TestFinally()
        {
            FileStream file = null;
            FileInfo fileInfo = new System.IO.FileInfo("./file.txt");
            try
            {
                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            finally
            {
                file?.Close();
            }

            try
            {
                file = fileInfo.OpenWrite();
                Console.WriteLine("OpenWrite() succeeded");
            }
            catch (IOException)
            {
                Console.WriteLine("OpenWrite() failed");
            }

        }
        private static void TestThrow()
        {
            throw new CustomException("Custom exception in TestThrow()");
        }
        static double SafeDivision(double x, double y)
        {
            if (y==0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
        static void Main(string[] args)
        {
            TestFinally();
            try
            {
                TestThrow();
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            double a = 98, b = 0;
            double result;
            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divide by {1} = {2}", a, b, result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Attempted divide by zero.");
            }

            try
            {
                using (var sw = new StreamWriter("./test.txt"))
                {
                    sw.WriteLine("Hello");
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}
