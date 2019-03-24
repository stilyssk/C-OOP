using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Employee: IDetailsPrinter
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void PrintDetails()
        {
            throw new NotImplementedException();
        }
    }
}
