using System;

namespace SingletonDesignPatern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SourceHelper sH = SourceHelper.GetInstance("Instance 1");
            Console.WriteLine(sH.InctanceName);

            SourceHelper sH2 = SourceHelper.GetInstance("Instance 2");
            Console.WriteLine(sH2.InctanceName);

            Console.Read();
        }
    }
}
