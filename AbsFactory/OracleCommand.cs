namespace Factory
{
    //---------------------------------------------------------------
    public class OracleCommand : Command
    {
        public override void Execute()
        {
            System.Console.WriteLine("Oracle Executed....");
        }
        public override string Query
        {
            get
            {
                return base.query;
            }
            set
            {
                base.query = value;
            }
        }
    }

}
