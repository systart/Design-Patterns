using System;
using TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.AbstractFactoryExample.Implementations
{
    class BmwCar : ICar
    {
        public bool MoveForward()
        {
            Console.WriteLine("Bmw was moving forward...");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Bmw was stopped.");
            return true;
        }
    }
}
