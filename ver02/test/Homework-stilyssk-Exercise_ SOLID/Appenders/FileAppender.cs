using System;
using System.Collections.Generic;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class FileAppender : IAppender,ILogger,ILayout
    {
        public FileAppender(ILayout layout, ILogger logger)
        {
            Layout = layout;
            Logger = logger;
        }

        public IAppender Appender { get; }
        public ILayout Layout { get; }
        public ILogger Logger { get; }
        public DateTime DateTimeProp { get ; set; }
        public int ReportLevel { get ; set ; }
        public string Message { get ; set ; }

        public void Error(string inputDatetime, string inputMessage)
        {
            throw new NotImplementedException();
        }

        public string GetMessageAppending()
        {
            throw new NotImplementedException();
        }

        public void Info(string inputDatetime, string inputMessage)
        {
            throw new NotImplementedException();
        }

        public void SetMessageAppending(string value)
        {
            throw new NotImplementedException();
        }
    }
}
