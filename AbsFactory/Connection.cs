using System;

namespace Factory
{
    //---------------------------------------------------------------
    public abstract class Connection
    {
        public abstract void Connect();
        protected String m_connectionString;
        public abstract String connectionString{get; set;}

    }

}
