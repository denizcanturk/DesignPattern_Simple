namespace Factory
{
    //---------------------------------------------------------------
    public class OracleConnection : Connection
    {
        public override void Connect()
        {
            System.Console.WriteLine("Oracle bağlandı...");
        }
        public override string connectionString 
        {
            get
            {
                return base.m_connectionString;
            }
            set
            {
                base.m_connectionString = value;
            }
        }
    }

}
