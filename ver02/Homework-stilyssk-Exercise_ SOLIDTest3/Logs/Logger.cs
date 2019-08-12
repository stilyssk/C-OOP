using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class Logger : ILogger, IAppender
    {
        private string _messageAppending;

        public IAppender Appender { get; }

        public Logger(IAppender appender)
        {
            Appender = appender;
        }

        public Logger(IAppender consoleAppender,IAppender fileAppender)
        {
        }

        public string GetMessageAppending()
        {
            return _messageAppending;
        }

        public void SetMessageAppending(string value)
        {
            _messageAppending = value;
        }

        public void Error(string inputDatetime, string inputMessage)
        {
            Console.WriteLine($"{inputDatetime} - {MethodBase.GetCurrentMethod().Name} - {inputMessage}");
        }

        public void Info(string inputDatetime, string inputMessage)
        {

            Console.WriteLine($"{inputDatetime} - {MethodBase.GetCurrentMethod().Name} - {inputMessage}");
        }

        public void Fatal(string inputDatetime, string inputMessage)
        {

            Console.WriteLine($"{inputDatetime} - {MethodBase.GetCurrentMethod().Name} - {inputMessage}");
        }

        public void Critical(string inputDatetime, string inputMessage)
        {

            Console.WriteLine($"{inputDatetime} - {MethodBase.GetCurrentMethod().Name} - {inputMessage}");
        }

        public void Warning(string inputDatetime, string inputMessage)
        {

            Console.WriteLine($"{inputDatetime} - {MethodBase.GetCurrentMethod().Name} - {inputMessage}");
        }
    }
}
