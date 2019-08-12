using _06._CSharp_OOP_SOLID_Exercise.Appenders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class FileAppender :IAppender, ILogger
    {
        private ILogger logger;
        public FileAppender(ILayout layout, ILogger logger)
        {
            Logger = logger;
        }

        public ILogger Logger { get; }


        public void Error(string inputDatetime, string inputMessage)
        {
            Logger.Error(inputDatetime, inputMessage);
        }

        public string GetMessageAppending()
        {
            throw new NotImplementedException();
        }

        public void Info(string inputDatetime, string inputMessage)
        {
            Logger.Info(inputDatetime, inputMessage);
        }

        public void SetMessageAppending(string value)
        {
            throw new NotImplementedException();
        }
    }
}
