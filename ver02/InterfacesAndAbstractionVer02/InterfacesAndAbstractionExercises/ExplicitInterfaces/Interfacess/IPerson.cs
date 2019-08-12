using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Interfacess
{
    public interface IPerson
    {
        string Name { get; }
        string country { get; }
        string GetName();
    }
}
