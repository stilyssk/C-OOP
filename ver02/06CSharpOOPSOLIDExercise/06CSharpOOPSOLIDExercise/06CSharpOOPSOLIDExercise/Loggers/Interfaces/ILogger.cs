using System;
using System.Collections.Generic;
using System.Text;

namespace _06CSharpOOPSOLIDExercise.Loggers.Interfaces
{
    public interface ILogger
    {
        void Error(string inputDate, string inputMessage);
        void Info(string inputDate, string inputMessage);
        void Fatal(string inputDate, string inputMessage);
        void Critical(string inputDate, string inputMessage);
        void Warning(string inputDate, string inputMessage);

    }
}
