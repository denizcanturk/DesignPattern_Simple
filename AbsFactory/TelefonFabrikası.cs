namespace Factory
{
    public class TelefonFabrikası
    {
        public static Telefon getTelefon(string model, string batarya, int en, int boy)
        {
            Telefon telefon = null;
            if (model == "S7")
            {
                telefon = new S7(model, batarya, en,boy);
                System.Console.WriteLine("Model: " + model);
                System.Console.WriteLine("Barty: " + batarya);
                System.Console.WriteLine("En   : " + en);
                System.Console.WriteLine("Boy  : " + boy);
                System.Console.WriteLine("=================");
            }
            else if (model == "Note3")
            {
                telefon = new Note3(model, batarya,en,boy);
                System.Console.WriteLine("Model: " + model);
                System.Console.WriteLine("Barty: " + batarya);
                System.Console.WriteLine("En   : " + en);
                System.Console.WriteLine("Boy  : " + boy);
            } else
                System.Console.WriteLine("Olmadı hacı abi bu iş olmaz... ");
            
            return telefon;
        }
    }

}
