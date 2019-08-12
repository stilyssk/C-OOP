using System;
using System.Collections.Generic;
using System.Text;

namespace _06CSharpOOPSOLIDExercise.Layouts.Interfaces
{
    public interface ILayout
    {
        string DateTime { get; set; }
        string ReportLevel { get; set; }

        string Message { get; set; }
        string GetMessage();
    }
}
