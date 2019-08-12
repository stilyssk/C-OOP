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

        //public DateTime DateTimeProp { get ; set ; }
        //public int ReportLevel { get ; set ; }
        public string DateTimeProp { get ; set ; }
        public string ReportLevel { get ; set ; }
        public string Message { get ; set ; }

        public override string ToString()
        {
            string result= null;
            result += $"<log>\n";
            result += $"\t<date>{this.DateTimeProp}</date>\n";
            result += $"\t<level>{this.ReportLevel}</level>\n";
            result += $"\t<message>{this.Message}</message>\n";
            result += $"</log>\n";


            return result.TrimEnd();
        }
    }
}
