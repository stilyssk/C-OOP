using System;
using System.Collections.Generic;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public interface ILayout
    {
        DateTime DateTimeProp { get; set; }
        int ReportLevel { get; set; }
        string Message { get; set; }
    }
}
