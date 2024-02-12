using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStateFather
{
    internal class Father
    {
        internal State State { get; set; }
        public Father()
        {
            State = new NeutralState();
        }
        public void FindOut(Mark mark)
        {
            State.HandleMark(this, mark);
        }
    }
}
