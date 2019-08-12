using _06CSharpOOPSOLIDExercise.Appenders.Interfaces;
using _06CSharpOOPSOLIDExercise.Layouts.Interfaces;
using System;
using _06CSharpOOPSOLIDExercise.Enums;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _06CSharpOOPSOLIDExercise.Appenders.Classes
{
    public class FileAppender : IAppender
    {

        private ILayout layout;
        private ILogFile logFile;
        private ReportLevel reportLevel;

        public FileAppender(ILayout inputLayout, ILogFile inputLogFile)
        {
            this.Layout = inputLayout;
            this.LogFile = inputLogFile;
        }

        public ILayout Layout { get => layout; set => layout = value; }
        public ILogFile LogFile { get => logFile; set => logFile = value; }
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

        public void SetLayout(string inputDate, string inputReportLevel, string inputMessage)
        {
            this.Layout.DateTime = inputDate;
            this.Layout.ReportLevel = inputReportLevel;
            this.Layout.Message = inputMessage;
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
            using (StreamWriter sw = File.AppendText(this.LogFile.FileName))
            {
                sw.WriteLine(this.Layout.GetMessage());

            }
            }

        }


    }
}
