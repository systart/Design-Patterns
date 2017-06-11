using System;
using TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample.Implementations
{
    public class PrototypeAlpha : IPrototype
    {
        private string _name = "AlphaVersion";

        public IPrototype Clone()
        {
            return new PrototypeAlpha();
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
