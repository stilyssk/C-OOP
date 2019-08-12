using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class LogFile : ILogger
    {
        public string fileName = "log.txt";
        private StreamWriter stream ;
        public LogFile()
        {
            File.Delete(fileName);

        }

        public void Critical(string inputDatetime, string inputMessage)
        {
            using (stream = File.AppendText(fileName))
            {
                stream.WriteLine($" <{ inputDatetime}> - {MethodBase.GetCurrentMethod().Name} - <{ inputMessage}> ");

            }
        }

        public void Error(string inputDatetime, string inputMessage)
        {
            using (stream = File.AppendText(fileName))
            {
                stream.WriteLine($" <{ inputDatetime}> - {MethodBase.GetCurrentMethod().Name} - <{ inputMessage}> ");

            }
        }

        public void Fatal(string inputDatetime, string inputMessage)
        {
            using (stream = File.AppendText(fileName))
            {
                stream.WriteLine($" <{ inputDatetime}> - {MethodBase.GetCurrentMethod().Name} - <{ inputMessage}> ");

            }
        }

        public void Info(string inputDatetime, string inputMessage)
        {
            using (stream = File.AppendText(fileName))
            {
                stream.WriteLine($" <{ inputDatetime}> - {MethodBase.GetCurrentMethod().Name} - <{ inputMessage}> ");

            }
        }

        public void Warning(string inputDatetime, string inputMessage)
        {
            throw new NotImplementedException();
        }
    }
}
