using System;

namespace Factory
{
    public class FactoryUtil
    {
        public static DBFactory GetFactory(string db_name)
        {
            if (db_name == "SQL")
            {
                return new SQLFactory();
            }
            if (db_name == "Oracle")
            {
                return new OracleFactory();
            }
            throw new Exception("Shit happened");
        }
    }

}
