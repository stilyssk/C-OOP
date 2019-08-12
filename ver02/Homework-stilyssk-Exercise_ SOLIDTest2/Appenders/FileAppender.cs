using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public class FileAppender : IAppender//,ILayout
    {
        private string fileName = "log.txt";
        private StreamWriter stream;

        public FileAppender(ILayout layout, ILogger logger)
        {
            Layout = layout;
            Logger = logger;
            File.Delete(fileName);
        }

        //public IAppender Appender { get; }
        //public DateTime DateTimeProp { get ; set; }
        public int ReportLevel { get; set; }

        public string Message { get; set; }
        public ILayout Layout { get; set; }
        public ILogger Logger { get; }

        public ILayout SetLayout (string inputDateTime, string inputReportLevel, string inputMessage, ILayout temLayout)
        {
            temLayout.DateTimeProp = inputDateTime;
            temLayout.ReportLevel = inputReportLevel;
            temLayout.Message = inputMessage;
            return temLayout;
        }

        public void Error(string inputDatetime, string inputMessage)
        {
            this.Layout = SetLayout(inputDatetime, MethodBase.GetCurrentMethod().Name, inputMessage, Layout);
            this.SetMessageAppending(this.Layout.ToString());
            using (stream = File.AppendText(fileName))
            {
                stream.WriteLine(this.GetMessageAppending());
            }
            //Logger.Error(inputDatetime, inputMessage);
        }

        public void Info(string inputDatetime, string inputMessage)
        {
            this.Layout = SetLayout(inputDatetime, MethodBase.GetCurrentMethod().Name, inputMessage, Layout);
            this.SetMessageAppending(this.Layout.ToString());
            using (stream = File.AppendText(fileName))
            {
                stream.WriteLine(this.GetMessageAppending());
            }
            //Logger.Info(inputDatetime, inputMessage);
        }

        public string GetMessageAppending()
        {
            return this.Message;
        }

        public void SetMessageAppending(string value)
        {
            this.Message = value;
        }

        public void Fatal(string inputDatetime, string inputMessage)
        {
            this.Layout = SetLayout(inputDatetime, MethodBase.GetCurrentMethod().Name, inputMessage, Layout);
            this.SetMessageAppending(this.Layout.ToString());
            using (stream = File.AppendText(fileName))
            {
                stream.WriteLine(this.GetMessageAppending());
            }
            //Logger.Info(inputDatetime, inputMessage);
        }

        public void Critical(string inputDatetime, string inputMessage)
        {
            this.Layout = SetLayout(inputDatetime, MethodBase.GetCurrentMethod().Name, inputMessage, Layout);
            this.SetMessageAppending(this.Layout.ToString());
            using (stream = File.AppendText(fileName))
            {
                stream.WriteLine(this.GetMessageAppending());
            }
            //Logger.Info(inputDatetime, inputMessage);
        }


        public void Warning(string inputDatetime, string inputMessage)
        {
            throw new NotImplementedException();
        }
    }
}
