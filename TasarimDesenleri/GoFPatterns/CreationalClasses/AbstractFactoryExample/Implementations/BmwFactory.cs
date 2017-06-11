using System;
using TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample.Implementations
{
    public class BmwFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            Console.WriteLine("Bmw car was created.");
            return new BmwCar();
        }
    }
}
