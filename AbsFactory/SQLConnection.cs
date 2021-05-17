namespace Factory
{
    //---------------------------------------------------------------
    public class SQLConnection : Connection
    {
        public override void Connect()
        {
            System.Console.WriteLine("SQL e bağlandı...");
        }
        public override string connectionString 
        {   get 
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
