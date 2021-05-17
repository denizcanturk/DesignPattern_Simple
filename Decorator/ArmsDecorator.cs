namespace Decorator
{
    // Decorator
    abstract class ArmsDecorator
        : Arms
    {
        protected Arms _arms;
        public ArmsDecorator(Arms arms)
        {
            _arms = arms;
        }
        public override void Fire()
        {
            if (_arms != null)
                _arms.Fire();
        }
    }
}