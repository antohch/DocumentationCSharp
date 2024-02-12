using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStateFather
{
    internal class PityState : State
    {
        public PityState() 
        {
            Console.WriteLine("Отец в состоянии жалости:");
            Pity();
        }
        protected override void ChangeState(Father father, Mark mark)
        {
            switch (mark)
            {
                case Mark.Two:
                    {
                        father.State = new AngerState();
                        break;
                    }
                case Mark.Five:
                    {
                        father.State = new JoyState();
                        break;
                    }
            }
        }
        private void Pity()
        {
            Console.WriteLine("Жалеет сына");
        }
    }
}
