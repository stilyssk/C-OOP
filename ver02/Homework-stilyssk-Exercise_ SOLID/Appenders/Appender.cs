using System;
using System.Collections.Generic;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise.Appenders
{
    public class Appender : IAppender
    {
        private ILayout layout;

        public Appender(ILayout layout)
        {
            Layout = layout;
        }

        public ILayout Layout { get => layout; set => layout = value; }

        public void Error(string inputDatetime, string inputMessage)
        {
            throw new NotImplementedException();
        }
        public void Info(string inputDatetime, string inputMessage)
        {
            throw new NotImplementedException();
        }

        public virtual string GetMessageAppending()
        {
            return this.Layout.Message;
        }



        public virtual void SetMessageAppending(string value)
        {
            this.Layout.Message = value;
        }
    }
}
