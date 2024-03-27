namespace OutOfRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CodeWithoutCleanup();
            CodeWithCleanup();

            int[] arr = { 1, 2, 3 };
            GetInt(arr, 4);
        }
        static int GetInt(int[] array, int index)
        {
            try 
            { 
                return array[index]; 
            }    
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine(e.Message);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", e);
            }
        }
        static void CodeWithoutCleanup()
        {
            FileStream? file = null;
            FileInfo fileInfo = new FileInfo("./file.txt");

            file = fileInfo.OpenWrite();
            file.WriteByte(0xF);

            file.Close();
        }
        static void CodeWithCleanup()
        {
            FileStream? file = null;
            FileInfo? fileInfo = null;

            try
            {
                fileInfo = new FileInfo("./file.txt");
                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);

            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                file?.Close();
            }
        }
    }
}
