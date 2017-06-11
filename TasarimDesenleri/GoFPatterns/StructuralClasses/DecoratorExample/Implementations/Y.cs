using System;
using TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Interfacces;

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Implementations
{
    public class Y : Decorator
    {
        public Y(IDecoratorInterface inner) : base(inner)
        {
            ;
        }

        public override void DoIt()
        {
            base.DoIt();
            DoY();
        }

        private void DoY()
        {
            Console.Write("Y");
        }
    }
}
