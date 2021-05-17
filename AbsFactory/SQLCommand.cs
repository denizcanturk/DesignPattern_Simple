namespace Factory
{
    //---------------------------------------------------------------
    public class SQLCommand : Command
    {
        public override void Execute()
        {
            System.Console.WriteLine("T_SQL Executed....");
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
