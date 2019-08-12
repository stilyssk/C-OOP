using System;
using System.Collections.Generic;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise.Layouts
{
    public class XmlLayout : ILayout
    {
        public XmlLayout()
        {
        }

        public DateTime DateTimeProp { get ; set ; }
        public int ReportLevel { get ; set ; }
        public string Message { get ; set ; }
    }
}
