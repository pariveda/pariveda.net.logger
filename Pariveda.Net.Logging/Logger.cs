using NLog;

namespace Pariveda.Net.Logging
{
    public class Logger
    {
        private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();

        public static void Error(string message)
        {
            logger.Error(message);
        }

        public static void Warning(string message)
        {
            logger.Warn(message);
        }

        public static void Info(string message)
        {
            logger.Info(message);
        }

        public static void Debug(string message)
        {
            logger.Debug(message);
        }
    }
}
