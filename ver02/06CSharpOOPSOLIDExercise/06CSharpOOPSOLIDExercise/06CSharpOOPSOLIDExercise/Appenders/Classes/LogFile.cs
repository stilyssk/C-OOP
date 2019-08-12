using _06CSharpOOPSOLIDExercise.Appenders.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _06CSharpOOPSOLIDExercise.Appenders.Classes
{
    public class LogFile : ILogFile
    {
        private string logFileName = "log.txt";

        public LogFile()
        {
            if (File.Exists(logFileName))
            {
                File.Delete(logFileName); 
            }
        }

        public string FileName { get { return this.logFileName; } }


    }
}
