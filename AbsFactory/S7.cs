namespace Factory
{
    public class S7 : Telefon
    {
    
         string model;
         string batarya;
         int en;
         int boy;
        public S7 (string model, string batarya, int en, int boy)
         {
             this.model = model;
             this.batarya = batarya;
             this.en = en;
             this.boy = boy;
             System.Console.WriteLine("S7 is created...");
         }

         public string getModel()   { return model;}
         public string getBatarya() { return batarya; }
         public int getEn()         { return en; }
         public int getBoy()        { return boy;}

    }

}
