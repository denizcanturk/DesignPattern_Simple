namespace Factory
{
    public class Note3: Telefon
    {
        string model;
        string batarya;
        int en;
        int boy;

        public Note3 (string model, string batarya, int en, int boy)
        {
            this.model = model;
            this.batarya = batarya;
            this.en = en;
            this.boy = boy;
            System.Console.WriteLine("Note3 is created...");
        }

        public string getModel()   { return model;}
        public string getBatarya() { return batarya; }
        public int getEn()         { return en; }
        public int getBoy()        { return boy;}

    }

}
