using System;
using TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample.Implementations
{
    class AudiCar : ICar
    {
        public bool MoveForward()
        {
            Console.WriteLine("Audi was moving forward...");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Audi was stopped.");
            return true;
        }
    }
}
