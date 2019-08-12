using System;
using System.Collections.Generic;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class ConsoleAppender : IAppender, ILayout
    {
        private DateTime _dateTimeProp;
        private int _reportLevel;
        private string _message;

        public ConsoleAppender(ILayout layout)
        {
        }

        public DateTime DateTimeProp { get => _dateTimeProp; set => _dateTimeProp = value; }
        public int ReportLevel { get => _reportLevel; set => _reportLevel = value; }
        public string Message { get => _message; set => _message = value; }

        private string messageAppending;

        public string GetMessageAppending()
        {
            return messageAppending;
        }

        public void SetMessageAppending(string value)
        {
            messageAppending = value;
        }
    }
}
