using _06CSharpOOPSOLIDExercise.Appenders.Interfaces;
using _06CSharpOOPSOLIDExercise.Enums;
using _06CSharpOOPSOLIDExercise.Layouts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06CSharpOOPSOLIDExercise.Appenders.Classes
{
    public class ConsoleAppender : IAppender
    {

        private ILayout layout;
        private ReportLevel reportLevel;
        public ConsoleAppender(ILayout inputLayout)
        {
            this.Layout = inputLayout;
            this.reportLevel = 0;
        }

        public ILayout Layout
        {
            get => layout;
            set
            {
                layout = value;
            }
        }

        public ReportLevel ReportLevel
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

        public void WriteMessage()
        {
            var compareLevel = (int)this.ReportLevel;
            var second = 0;
            int i = 0;
            foreach (ReportLevel current in Enum.GetValues(typeof(ReportLevel)))
            {
                if (current.ToString() == this.Layout.ReportLevel)
                {
                    second = i;
                }
                i++;
            }
            if (compareLevel <= second)
            {
                Console.WriteLine(this.Layout.GetMessage());

            }

        }

        public void SetLayout(string inputDate, string inputReportLevel, string inputMessage)
        {
            this.Layout.DateTime = inputDate;
            this.Layout.ReportLevel = inputReportLevel;
            this.Layout.Message = inputMessage;
        }


    }
}
