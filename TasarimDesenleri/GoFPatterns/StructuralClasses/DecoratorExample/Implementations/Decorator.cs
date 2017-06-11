using TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Interfacces;

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Implementations
{
    public abstract class Decorator : IDecoratorInterface
    {
        private IDecoratorInterface _core;

        protected Decorator(IDecoratorInterface inner)
        {
            _core = inner;
        }

        public virtual void DoIt()
        {
            _core.DoIt();
        }
    }
}
