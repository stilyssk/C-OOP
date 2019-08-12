using System.Collections.Generic;

namespace P04_Hospital
{
    public interface IDepartment
    {
        string Name { get; set; }
        List<IRoom> Rooms { get; set; }
        void NewDepartment();
        int CountOcupate();
        List<string> ListAllPatientInDepartment();
    }
}