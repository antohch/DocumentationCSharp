using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    [Flags]
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winder = 4,
        Spring = 8,
        All = Summer | Autumn | Winder | Spring
    }
}
