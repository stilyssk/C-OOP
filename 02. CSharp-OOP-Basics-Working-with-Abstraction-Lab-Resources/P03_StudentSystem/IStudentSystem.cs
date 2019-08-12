using System.Collections.Generic;

namespace P03_StudentSystem
{
    public interface IStudentSystem
    {
        bool Exit { get; set; }
        Dictionary<string, IStudent> Repo { get; }

        void Create(string[] args);
        string ParseCommand();
        string Show(string[] args);
    }
}