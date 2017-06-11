using System;
using TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Interfacces;

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Implementations
{
    public class X : Decorator
    {
        public X(IDecoratorInterface inner) : base(inner)
        {
            ;
        }

        public override void DoIt()
        {
            base.DoIt();
            DoX();
        }

        private void DoX()
        {
            Console.Write("X");
        }
    }
}
