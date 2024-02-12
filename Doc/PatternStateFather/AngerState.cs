using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStateFather
{
    internal class AngerState : State
    {
        public AngerState() 
        {
            Console.WriteLine("Отец зол:");
            Anger();
        }
        protected override void ChangeState(Father father, Mark mark)
        {
            switch(mark)
            {
                case Mark.Two:
                    {
                        father.State = new StrongAngerState();
                        break;
                    }
                case Mark.Five:
                    {
                        father.State = new PityState();
                        break;
                    }
            }
        }
        private void Anger()
        {
            Console.WriteLine("Отец злится!");
        }
    }
}
