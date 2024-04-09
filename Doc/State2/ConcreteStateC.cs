using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State2
{
    internal class ConcreteStateC : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
