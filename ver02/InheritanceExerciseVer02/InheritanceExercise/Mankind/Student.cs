using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student( string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;

        }

        public string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (value.Length<5||value.Length>10 || !value.All(x => char.IsLetterOrDigit(x)))
                {
                    throw new ArgumentException($"Invalid faculty number!");
                }
                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine($"Faculty number: {FacultyNumber}");
            return result.ToString().TrimEnd();
        }
    }
}
