using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Solution
{
    public class DIP
    {
        public static void Main()
        {
            var dbLogger = new DBLogger();
            dbLogger.Message = "Mesajjj";

            var manager = new LogManager(dbLogger);
            manager.Log();
        }
    }



    public interface ILogger
    {
        void Log();
    }

    public class FileLogger : ILogger
    {
        public string Message { get; set; }
        public void Log()
        {
            //File Log
        }
    }

    public class DBLogger : ILogger
    {
        public string Message { get; set; }

        public void Log()
        {
            //Database Log
        }
    }

    public class LogManager
    {

        private ILogger _logger;

        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Log()
        {
            _logger.Log();
        }
    }



}
