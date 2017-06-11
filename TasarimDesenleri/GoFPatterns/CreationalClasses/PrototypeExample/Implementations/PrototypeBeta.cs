using System;
using TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample.Implementations
{
    class PrototypeBeta : IPrototype
    {
        private string _name = "BetaVersion";

        public IPrototype Clone()
        {
            return new PrototypeBeta();
        }

        public string GetName()
        {
            return _name;
        }

        public void Execute()
        {
            Console.WriteLine(_name + ": does something.");
        }
    }
}
