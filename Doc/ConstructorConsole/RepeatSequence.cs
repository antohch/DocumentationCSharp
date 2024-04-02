using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorConsole
{
    public struct RepeatSequence : IGetNext<RepeatSequence>
    {
        private const char Ch = 'A';
        public string Text = new string(Ch, 1);

        public RepeatSequence() { }

        public static RepeatSequence operator ++(RepeatSequence other)
            => other with { Text = other.Text + Ch };

        public override string ToString() => Text;
    }
}
