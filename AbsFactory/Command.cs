using System;

namespace Factory
{
    //---------------------------------------------------------------
    public abstract class Command
    {
        public abstract void Execute();
        protected String query;
        public abstract String Query { get; set; }
    }

}
