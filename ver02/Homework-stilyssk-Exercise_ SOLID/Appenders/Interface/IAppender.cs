using System;
using System.Collections.Generic;
using System.Text;

namespace _06._CSharp_OOP_SOLID_Exercise
{
    public interface IAppender:ILogger
    {
        string GetMessageAppending();
        void SetMessageAppending(string value);
    }
}
