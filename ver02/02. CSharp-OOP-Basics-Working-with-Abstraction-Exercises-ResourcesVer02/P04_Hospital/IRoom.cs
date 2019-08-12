using System.Collections.Generic;

namespace P04_Hospital
{
    public interface IRoom
    {
        int CurrentRoom { get; set; }
        List<string> Patient { get; set; }
        int RoomCount();
        void AddPatient(string patient);
        List<string> ListAllPatient();
    }
}