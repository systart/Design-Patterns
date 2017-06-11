using System;
using System.Collections.Generic;
using TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample
{
    public class PrototypeModule
    {
        private static List<IPrototype> _prototypes = new List<IPrototype>();

        public static void AddPrototype(IPrototype p)
        {
            _prototypes.Add(p);
        }

        public static IPrototype CreatePrototype(string name)
        {
            foreach (var prototype in _prototypes)
            {
                if (prototype.GetName().Equals(name))
                    return prototype.Clone();
            }
            Console.WriteLine(name + " doesn't exist.");
            return null;
        }
    }
}
