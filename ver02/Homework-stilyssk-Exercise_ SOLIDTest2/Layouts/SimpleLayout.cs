using System;
using System.Collections.Generic;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class SimpleLayout : ILayout
    {
        //private DateTime _dateTimeProp;
        //private int _reportLevel;
        private string _dateTimeProp;
        private string _reportLevel;
        private string _message;

        //public DateTime DateTimeProp { get => _dateTimeProp; set => _dateTimeProp = value; }
        public string DateTimeProp { get => _dateTimeProp; set => _dateTimeProp = value; }
        //public int ReportLevel { get => _reportLevel; set => _reportLevel = value; }
        public string ReportLevel { get => _reportLevel; set => _reportLevel = value; }
        public string Message { get => _message; set => _message = value; }

        public string ResultString()
        {
            return $"<{this.DateTimeProp}> - <{this.ReportLevel}> - <{this.Message}>";
        }

        public override string ToString()
        {
            return ResultString();
        }
    }
}
