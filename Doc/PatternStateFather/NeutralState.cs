using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStateFather
{
    internal class NeutralState : State
    {
        public NeutralState() 
        {
            Console.WriteLine("Отец в нейтральном состоянии:");
            Hope();
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
                        father.State = new JoyState();
                        break;
                    }
            }
        }
        private void Hope()
        {
            Console.WriteLine("Надеется на хорошие оценки.");
        }
    }
}
