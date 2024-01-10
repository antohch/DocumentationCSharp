using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtend
{
    public static class ExtendDictionary
    {
        public static void Deconstruct(this KeyValuePair<string, int> dict, out string key, out int val)
        {
            key = dict.Key;
            val = dict.Value;
        }
    }
}
