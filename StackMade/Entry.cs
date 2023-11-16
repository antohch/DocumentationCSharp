namespace StackMadeDll
{
    public class Entry<T>
    {
        public Entry(Entry<T> topOfStack, T data)
        {
            Next = topOfStack;
            Data = data;
        }

        public Entry<T> Next { get; set; }
        public T Data { get; set; }
    }
}