using _06CSharpOOPSOLIDExercise.Appenders.Interfaces;
using _06CSharpOOPSOLIDExercise.Loggers.Interfaces;
using System;
using System.Reflection;
namespace _06CSharpOOPSOLIDExercise.Loggers.Classes
{
    public class Logger : ILogger
    {
        private IAppender[] tempAppender;
        public Logger(params IAppender[] inputAppender)
        {
            this.TempAppender = inputAppender;
        }
        private IAppender[] TempAppender { get; set; }

        public void Critical(string inputDate, string inputMessage)
        {
            SetAndWriteMessaage(inputDate, MethodInfo.GetCurrentMethod().Name, inputMessage);
        }

        public void  Error(string inputDate, string inputMessage)
        {
            SetAndWriteMessaage(inputDate, MethodInfo.GetCurrentMethod().Name, inputMessage);
        }

        public void Fatal(string inputDate, string inputMessage)
        {
            SetAndWriteMessaage(inputDate, MethodInfo.GetCurrentMethod().Name, inputMessage);
        }

        public void Info(string inputDate, string inputMessage)
        {
            SetAndWriteMessaage(inputDate, MethodInfo.GetCurrentMethod().Name, inputMessage);
        }

        public void Warning(string inputDate, string inputMessage)
        {
            SetAndWriteMessaage(inputDate, MethodInfo.GetCurrentMethod().Name, inputMessage);

        }

        private void SetAndWriteMessaage(string inputDate,string reportLevel, string inputMessage)
        {
            foreach (var currentAppender in TempAppender)
            {
                currentAppender.SetLayout(inputDate, reportLevel, inputMessage);
                currentAppender.WriteMessage();
            }
        }
    }
}
