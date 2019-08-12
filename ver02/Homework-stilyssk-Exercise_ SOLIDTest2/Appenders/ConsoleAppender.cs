using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class ConsoleAppender : IAppender//  ILayout
    {
        //private DateTime _dateTimeProp;
        private int _reportLevel;
        //private string _message;
        //public DateTime DateTimeProp { get => _dateTimeProp; set => _dateTimeProp = value; }
        public int ReportLevel { get => _reportLevel; set => _reportLevel = value; }
        //public string Message { get => _message; set => _message = value; }
        private ILayout layout;
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        private string messageAppending;

        public ILayout Layout { get => layout; set => layout = value; }

        public string GetMessageAppending()
        {
            return messageAppending;
        }

        public void SetMessageAppending(string value)
        {
            messageAppending = value;
        }

        public void Error(string inputDatetime, string inputMessage)
        {
            this.Layout.DateTimeProp = inputDatetime;
            this.Layout.ReportLevel = MethodBase.GetCurrentMethod().Name;
            this.Layout.Message = inputMessage;
            this.SetMessageAppending(this.layout.ToString());
            Console.WriteLine(this.GetMessageAppending());
        }

        public void Info(string inputDatetime, string inputMessage)
        {
            this.Layout.DateTimeProp = inputDatetime;
            this.Layout.ReportLevel = MethodBase.GetCurrentMethod().Name;
            this.Layout.Message = inputMessage;
            this.SetMessageAppending(this.layout.ToString());
            Console.WriteLine(this.GetMessageAppending());
        }

        public void Fatal(string inputDatetime, string inputMessage)
        {
            this.Layout.DateTimeProp = inputDatetime;
            this.Layout.ReportLevel = MethodBase.GetCurrentMethod().Name;
            this.Layout.Message = inputMessage;
            this.SetMessageAppending(this.layout.ToString());
            Console.WriteLine(this.GetMessageAppending());
        }

        public void Critical(string inputDatetime, string inputMessage)
        {
            this.Layout.DateTimeProp = inputDatetime;
            this.Layout.ReportLevel = MethodBase.GetCurrentMethod().Name;
            this.Layout.Message = inputMessage;
            this.SetMessageAppending(this.layout.ToString());
            Console.WriteLine(this.GetMessageAppending());
        }


        public void Warning(string inputDatetime, string inputMessage)
        {
            this.Layout.DateTimeProp = inputDatetime;
            this.Layout.ReportLevel = MethodBase.GetCurrentMethod().Name;
            this.Layout.Message = inputMessage;
            this.SetMessageAppending(this.layout.ToString());
            Console.WriteLine(this.GetMessageAppending());
        }
    }
}
