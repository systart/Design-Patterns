using TasarimDesenleri.GoFPatterns.StructuralClasses.AdapterExample.Interfaces;
using ThidPartyLogSystem;

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.AdapterExample.Implementations
{
    public class LoggerAdapter : ILogger
    {
        private ThirdPartyLogger _thirdPartyLogger;
        public void SaveLog(string logData)
        {
            LogItem logItem = new LogItem();
            logItem.LogData = logData;
            _thirdPartyLogger = new ThirdPartyLogger();
            _thirdPartyLogger.LogIt(logItem);
        }
    }
}
