using NLog;

namespace Pariveda.Net.Logging
{
    public class Logger
    {
        private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();

        private const string defaultError = "An error occured. Please try again later.";

        public static void Error(string message)
        {
            message = string.IsNullOrEmpty(message) ? defaultError : message;
            logger.Error(message);
        }

        public static void Error()
        {
            logger.Error(defaultError);
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
