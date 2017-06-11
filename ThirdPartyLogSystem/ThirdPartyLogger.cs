using System;

namespace ThidPartyLogSystem
{
    public class ThirdPartyLogger
    {
        public void LogIt(LogItem logItem)
        {
            Console.WriteLine(logItem.LogData + " was successfully logged by 3rd party logger.");
        }
    }
}
