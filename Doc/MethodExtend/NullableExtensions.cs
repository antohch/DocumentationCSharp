using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtend
{
    public static class NullableExtensions
    {
        public static void Deconstruct<T>( this T? nullable, 
                                            out bool hasValue, 
                                            out T value ) where T : struct 
        {
            hasValue = nullable.HasValue;
            value = nullable.GetValueOrDefault();
        }
    }
}
