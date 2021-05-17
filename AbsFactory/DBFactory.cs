namespace Factory
{
    //---------------------------------------------------------------
    public abstract class DBFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }

}
