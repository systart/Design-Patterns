namespace TasarimDesenleri.GoFPatterns.CreationalClasses.PrototypeExample.Interfaces
{
    public interface IPrototype
    {
        IPrototype Clone();
        string GetName();
        void Execute();
    }
}
