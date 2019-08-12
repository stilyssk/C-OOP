using System.Collections.Generic;

namespace P04_Hospital
{
    public interface IDoctor
    {
        List<string> ListPatient { get; set; }
        string Name { get; set; }

        void AddPatient(string name);
        List<string> OrderedListPatient();
    }
}