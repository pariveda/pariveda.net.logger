using NLog;

namespace Pariveda.Net.Logging
{
    public class Logger
    {
        private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();

        public static void Error()
        {
            logger.Error("Error");
        }

        public static void Warning()
        {
            logger.Warn("Warning");
        }

        public static void Info()
        {
            logger.Info("Info");
        }

        public static void Debug()
        {
            logger.Debug("Debug");
        }

        private static string FormatMessage(string message)
        {
            return message;
        }
    }
}
