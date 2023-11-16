using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackMadeDll
{
    public class StackMade<T> : IStackMade<T>
    {
        private Entry<T> topOfStack;

        public T Pop()
        {
            if (topOfStack == null)
                throw new InvalidOperationException();

            T resultData = topOfStack.Data;
            topOfStack = topOfStack.Next;
            return resultData;
        }

        public void Push(T data)
        {
            topOfStack = new Entry<T>(topOfStack, data);
        }
    }
}
