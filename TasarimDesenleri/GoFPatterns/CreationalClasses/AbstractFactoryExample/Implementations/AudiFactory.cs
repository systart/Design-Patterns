using System;
using TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample.Implementations
{
    public class AudiFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            Console.WriteLine("Audi car was created.");
            return (new AudiCar());
        }
    }
}
