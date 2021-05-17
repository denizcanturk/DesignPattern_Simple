using System;

namespace Factory
{
    //---------------------------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Factory Design Pattern World!");

            DBFactory db = FactoryUtil.GetFactory("SQL");
            Connection cnn = db.CreateConnection();
            cnn.Connect();

            Command cmd = db.CreateCommand();
            cmd.Query = "Select * from Table";
            cmd.Execute();

            db = FactoryUtil.GetFactory("Oracle");
            cnn = db.CreateConnection();
            cnn.Connect();
            cmd = db.CreateCommand();
            cmd.Query = "Select * from table";
            cmd.Execute();

        }
    }

}
