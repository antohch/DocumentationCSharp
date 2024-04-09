using System;

namespace State
{
    internal class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            this.State = state;
        }

        internal void Request()
        {
            this.State.Handle(this);
        }
    }
}