namespace Feature12
{
    public class C0
    {
        public void f(ref dynamic a)
        {

        }
        public void M(dynamic d)
        {
            f(d);
        }
    }

    class C
    {
        public string M(in int i) => "C";
    }

    static class E
    {
        public static string M(this C c, ref int i) => "E";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var i1 = 5;
            Console.WriteLine(new C().M(ref i1));
            Console.WriteLine(E.M(new C(), ref i1));

            int[] a = [1, 2, 3, 4, 5, 6];
            List<string> b = ["one", "two", "three"];
            Span<char> c = ['a', 'b', 'c', 'd'];
            int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

            int[] row0 = [1, 2, 3];
            int[] row1 = [4, 5, 6];
            int[] row2 = [7, 8, 9];
            int[][] twoDFromVariables = [row0, row1, row2];

            int[] single = [.. row0, .. row1, .. row2];
            foreach(var element in single)
            {
                Console.WriteLine($"{element}");
            }

            var buffer = new Buffer();
            for (int i = 0; i < 10; i++)
            {
                buffer[i] = i;
            }
            foreach(var i in buffer)
            {
                Console.WriteLine(i);
            }

        }

        [System.Runtime.CompilerServices.InlineArray(10)]
        public struct Buffer
        {
            private int _element0;
        }

    }
}
