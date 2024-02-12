using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStateFather
{
    internal class StrongAngerState : State
    {
        public StrongAngerState() 
        {
            Console.WriteLine("Отец сильно злой:");
            StrongAnger();
        }
        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    {
                        father.State = new StrongAngerState();
                        break;
                    }
                case Mark.Five:
                    {
                        father.State = new NeutralState();
                        break;
                    }
            }
        }
        private void StrongAnger()
        {
            Console.WriteLine("Бьет сына ремнем!");
        }
    }
}
