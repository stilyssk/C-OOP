using _06CSharpOOPSOLIDExercise.Enums;
using _06CSharpOOPSOLIDExercise.Layouts.Interfaces;
using System;

namespace _06CSharpOOPSOLIDExercise.Appenders.Interfaces
{

    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        void WriteMessage();

        void SetLayout(string inputDate, string inputReportLevel, string inputMessage);


    }
}
