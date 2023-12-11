using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    interface IEquatable<T>
    {
        bool Equals(T other);
    }
}
