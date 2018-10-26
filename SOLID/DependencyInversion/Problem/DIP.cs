using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Problem
{

    public class FileLogger
    {
        public string Message { get; set; }

        public void Log()
        {

        }
    }

    public class Dbloger
    {
        public string Message { get; set; }

        public void Log()
        {



        }
    }

    public class LogManager
    {
        private FileLogger _file;
        private Dbloger _db;

        public LogManager()
        {
            _file = new FileLogger();
            _db = new Dbloger();
        }

        public void Log()
        {
            _file.Log();
            _db.Log();
        }

    }



}
