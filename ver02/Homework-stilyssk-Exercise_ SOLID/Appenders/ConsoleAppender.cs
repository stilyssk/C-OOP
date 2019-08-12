using _06._CSharp_OOP_SOLID_Exercise.Appenders;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class ConsoleAppender :IAppender, ILogger,ILayout
    {
        private DateTime dateTime;
        private int reportLevel;
        private string message;
        public ConsoleAppender(ILayout layout)
        {
        }

        public DateTime DateTimeProp
        {
            get => this.dateTime;
            set
            {
                this.dateTime=value;
            }
        }
        public int ReportLevel { get => this.reportLevel; set => this.reportLevel=value; }
        public string Message { get => this.message; set => this.message=value; }

        public void Error(string inputDatetime, string inputMessage)
        {
            Console.WriteLine($"{inputDatetime} - {MethodBase.GetCurrentMethod().Name}  - {inputMessage}");
        }

        public string GetMessageAppending()
        {
            throw new NotImplementedException();
        }

        public void Info(string inputDatetime, string inputMessage)
        {
            this.DateTimeProp = DateTime.Parse( inputDatetime);
            //this.ReportLevel = MethodBase.GetCurrentMethod().Name;
            this.Message = inputDatetime;
            Console.WriteLine($"{inputDatetime}  - {MethodBase.GetCurrentMethod().Name} - {inputMessage}");
        }

        public void SetMessageAppending(string value)
        {
            throw new NotImplementedException();
        }
    }
}
