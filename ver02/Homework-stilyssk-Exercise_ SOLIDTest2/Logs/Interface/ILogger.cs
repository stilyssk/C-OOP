using System;
using System.Collections.Generic;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public interface ILogger
    {
        void Error(string inputDatetime, string inputMessage);

        void Info(string inputDatetime, string inputMessage);

        void Fatal(string inputDatetime, string inputMessage);

        void Critical(string inputDatetime, string inputMessage);

        void Warning(string inputDatetime, string inputMessage);


    }
}
