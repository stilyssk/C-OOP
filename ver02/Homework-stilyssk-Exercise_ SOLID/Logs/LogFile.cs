using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class LogFile : ILogger
    {
        string path = @"log.txt";
        private StreamWriter sw;

        public LogFile()
        {
            if (!File.Exists(path))
            {
                File.Delete(path);
                Sw = File.CreateText(path);
            }
        }

        public StreamWriter Sw { get => sw; set => sw = value; }

        public void Error(string inputDatetime, string inputMessage)
        {
            using (Sw = File.AppendText(path))
            {
                sw.WriteLine($" <{ inputDatetime}> - {MethodBase.GetCurrentMethod().Name} - <{ inputMessage}> ");

            }
        }

        public void Info(string inputDatetime, string inputMessage)
        {
            using (Sw = File.AppendText(path))
            {
                sw.WriteLine($" <{ inputDatetime}>  - {MethodBase.GetCurrentMethod().Name} - <{ inputMessage}> ");

            }
        }
    }
}
