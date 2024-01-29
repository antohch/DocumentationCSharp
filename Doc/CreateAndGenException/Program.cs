using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndGenException
{
    internal class Program
    {
        static async Task<Toast> ToastBreadAsyncCore(int slices, int time)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                await Console.Out.WriteLineAsync("Putting a slice of bread int the toaster");
            }
            await Task.Delay(time);
            if (time > 2_000)
            {
                throw new InvalidOperationException("The toaster is on fire!");
            }
            Console.WriteLine("Toast is ready!");
            return new Toast();
        }
        public static Task<Toast> ToastBreadAsync(int slices, int toastTime)
        {
            if (slices < 1 || slices > 4)
            {
                throw new ArgumentException("You must specify between 1 and 4 slices of bread.", nameof(slices));
            }
            if (toastTime < 1)
            {
                throw new ArgumentException("Toast time is too shor.", nameof(toastTime));
            }

 
            return ToastBreadAsyncCore(slices, toastTime);

        }
        static void CopyObject(SampleClass original)
        {
            _ = original ?? throw new ArgumentException("Parameter cannot be null", nameof(original));
        }
        static void Main(string[] args)
        {
            var toast = ToastBreadAsync(3, 20);
            Console.WriteLine(toast.GetType());
            Console.ReadLine();
        }
    }
}
