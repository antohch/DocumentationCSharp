using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStateFather
{
    internal class StrongJoyState : State
    {
        public StrongJoyState() 
        {
            Console.WriteLine("Отец в восторге: ");
            StrongJoy();
        }
        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    {
                        father.State = new PityState();
                        break;
                    }
                case Mark.Five:
                    {
                        father.State = new StrongJoyState();
                        break;
                    }
            }
        }
        private void StrongJoy()
        {
            Console.WriteLine("В восторге");
        }
    }
}
