using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipeklTYpe
{
    internal enum FileMode
    {
        CreateNew = 1,
        Create = 2,
        Open = 3,
        OpenOrCreate = 4,
        Truncate = 5,
        Append = 6,
    }
}
