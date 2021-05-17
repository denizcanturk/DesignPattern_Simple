using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Factory Design Pattern World!");

            Telefon s7 = TelefonFabrikası.getTelefon("S7", "3400", 6,8);

            Telefon Note3 = TelefonFabrikası.getTelefon("Note3", "6555", 12,15);

        }
    }

}
