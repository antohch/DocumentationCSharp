using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackMadeDll
{
    internal interface IStackMade<T>
    {
        void Push(T data);
        T Pop();

    }
}
