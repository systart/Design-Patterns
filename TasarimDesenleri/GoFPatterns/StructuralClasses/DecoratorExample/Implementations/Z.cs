using System;
using TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Interfacces;

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Implementations
{
    public class Z : Decorator
    {
        public Z(IDecoratorInterface inner) : base(inner)
        {
            ;
        }

        public override void DoIt()
        {
            base.DoIt();
            DoZ();
        }

        private void DoZ()
        {
            Console.Write("Z");
        }
    }
}
