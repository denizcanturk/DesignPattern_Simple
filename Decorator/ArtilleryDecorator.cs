using System;

namespace Decorator
{
    // ConcreteDecorator
    class ArtilleryDecorator
        : ArmsDecorator
    {
        public ArtilleryDecorator(Arms arms)
            : base(arms)
        {
        }
 
        public void Defense()
        {
            Console.WriteLine("\t{0} Savunma Modu!", base._arms.Name);
        }
        public void Easy()
        {
            Console.WriteLine("\t{0} Atış serbest modu!", _arms.Name);
        }
        public override void Fire()
        {
            base.Fire();
        }
    }
}