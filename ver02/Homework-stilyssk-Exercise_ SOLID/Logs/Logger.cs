using _06._CSharp_OOP_SOLID_Exercise.Appenders;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class Logger : ILogger
    {
        //private string _messageAppending;

        private IAppender fileAppender;

        private IAppender consoleAppender;
        private List<IAppender> appender = new List<IAppender>();

        public List<IAppender> Appender => appender; public IAppender ConsoleAppender { get => consoleAppender; set => consoleAppender = value; }
        public IAppender FileAppender { get => fileAppender; set => fileAppender = value; }

        public Logger(IAppender appender)
        {
            Appender.Add(appender);
        }

        public Logger(IAppender consoleAppender, IAppender fileAppender)
        {
            Appender.Add(consoleAppender);
            Appender.Add(fileAppender);
        }

        public void Error(string inputDatetime, string inputMessage)
        {
            //foreach (var currentAppender in Appender)
            //{
            //    currentAppender.SetMessageAppending($"{inputDatetime} - {MethodBase.GetCurrentMethod().Name} - {inputMessage}");
            //    currentAppender.GetMessageAppending();
            //}
            foreach (var currentAppender in Appender)
            {
                currentAppender.Error(inputDatetime, inputMessage);
            }
        }

        public void Info(string inputDatetime, string inputMessage)
        {

            //foreach (var currentAppender in Appender)
            //{
            //    currentAppender.SetMessageAppending($"{inputDatetime} - {MethodBase.GetCurrentMethod().Name} - {inputMessage}");
            //    currentAppender.GetMessageAppending();
            //}
            foreach (var currentAppender in Appender)
            {
                currentAppender.Info(inputDatetime, inputMessage);
            }

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
