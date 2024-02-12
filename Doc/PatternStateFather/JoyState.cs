using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStateFather
{
    internal class JoyState : State
    {
        public JoyState() 
        {
            Console.WriteLine("Отец рад:");
            Joy();
        }
        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    {
                        father.State = new NeutralState();
                        break;
                    }
                case Mark.Five:
                    {
                        father.State = new StrongJoyState();
                        break;
                    }
            }
        }
        private void Joy()
        {
            Console.WriteLine("Радуется!");
        }
    }
}
