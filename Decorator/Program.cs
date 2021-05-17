using System.Collections.Generic;

namespace Decorator
{

    // Client
    class Program
    {
        static void Main()
        {
            // Bileşen örneklenir
            Artillery azman = new Artillery(125, 40, "Fırtına A1");
            azman.Fire();
 
            // Decorator nesnesi örneklenir
            ArtilleryDecorator  azmanDekorator= new ArtilleryDecorator(azman);
            // Decorator nesnesi üzerinden o anki asıl Component için(Artillery sınıfı) ek fonksiyonellikler çağırılır.
            azmanDekorator.Defense();
            azmanDekorator.Fire();
            azmanDekorator.Easy();
            azmanDekorator.Fire();
        }
    }
}