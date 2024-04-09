namespace RomanConvertConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rom = new RomanConvert();
            Console.WriteLine(rom.Solution(2814));
        }
    }
}
