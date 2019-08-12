using System;
using System.Collections.Generic;
using System.Text;

namespace P03_StudentSystem
{
    public class StudentSystem : IStudentSystem
    {
        private Dictionary<string, IStudent> repo;
        private bool exit;
        public StudentSystem()
        {
            this.Repo = new Dictionary<string, IStudent>();
            this.Exit = false;
        }

        public Dictionary<string, IStudent> Repo
        {
            get { return repo; }
            private set { repo = value; }
            
        }

        public bool Exit
        {
            get
            {
                return this.exit;
            }
            set
            {
                this.exit = value;
            }
        }

        public string ParseCommand()
        {
            StringBuilder result = new StringBuilder();
            string[] args = Console.ReadLine().Split();

            if (args[0] == "Create")
            {
                Create(args);
            }
            else if (args[0] == "Show")
            {
                result.AppendLine(Show(args));
            }
            else if (args[0] == "Exit")
            {
                this.Exit = true;
            }
            return result.ToString();
        }

        public void Create(string[] args)
        {
            var name = args[1];
            var age = int.Parse(args[2]);
            var grade = double.Parse(args[3]);
            if (!repo.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                Repo[name] = student;
            }
        }

        public string Show(string[] args)
        {
            var name = args[1];
            if (Repo.ContainsKey(name))
            {
                var student = Repo[name];
                string view = $"{student.Name} is {student.Age} years old.";

                if (student.Grade >= 5.00)
                {
                    view += " Excellent student.";
                }
                else if (student.Grade < 5.00 && student.Grade >= 3.50)
                {
                    view += " Average student.";
                }
                else
                {
                    view += " Very nice person.";
                }
                return view;
            }
            return null;
        }
    }
}
