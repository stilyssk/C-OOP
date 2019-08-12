using _06CSharpOOPSOLIDExercise.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06CSharpOOPSOLIDExercise.Layouts.Classes
{
    public class SimpleLayout : ILayout
    {
        private string dateTime;
        private string reportLevel;
        private string message;
        public string DateTime
        {
            get
            {
                return this.dateTime;
            }

            set
            {
                this.dateTime = value;
            }
        }

        public string ReportLevel
        {
            get
            {
                return this.reportLevel;
            }

            set
            {
                this.reportLevel = value;
            }
        }

        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.message = value;
            }
        }

        public string GetMessage()
        {
            return $"{this.DateTime} - {this.ReportLevel} - {this.Message}";
        }
    }
}
