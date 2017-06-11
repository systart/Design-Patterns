using System;
using TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Interfacces;

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.DecoratorExample.Implementations
{
    public class A : IDecoratorInterface
    {
        public void DoIt()
        {
            Console.Write("A");
        }
    }
}
