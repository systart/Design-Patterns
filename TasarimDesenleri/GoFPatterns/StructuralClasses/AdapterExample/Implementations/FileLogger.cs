using System;
using TasarimDesenleri.GoFPatterns.StructuralClasses.AdapterExample.Interfaces;

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.AdapterExample.Implementations
{
    public class FileLogger : ILogger
    {
        public void SaveLog(string logData)
        {
            Console.WriteLine(logData + " was saved to file successfully");
        }
    }
}
