using System;
using TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample.Implementations
{
    public class ReleasePrototype : IPrototype
    {
        private string _name = "ReleaseCandidate";

        public IPrototype Clone()
        {
            return new ReleasePrototype();
        }

        public string GetName()
        {
            return _name;
        }

        public void Execute()
        {
            Console.WriteLine(_name + ": does real work.");
        }
    }
}
