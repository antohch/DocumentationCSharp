using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStateFather
{
    abstract class State
    {
        internal virtual void HandleMark(Father father, Mark mark) 
        {
            ChangeState(father, mark);
        }
        protected abstract void ChangeState(Father father, Mark mark);
    }
}
