using System;

namespace Decorator
{
    // ConcreteComponent
    class Artillery
        : Arms
    {
        protected double _barrel;
        protected double _range;
 
        public Artillery(double barrel, double range, string name)
        {
            _barrel = barrel;
            _range = range;
            Name = name;
        }
 
        public override void Fire()
        {
            Console.WriteLine("{0} sınıfından olan topçu, {1} mm namlusundan {2} mesafeye ateşleme yaptı", Name, _barrel.ToString(), _range.ToString());
        }
    }
}