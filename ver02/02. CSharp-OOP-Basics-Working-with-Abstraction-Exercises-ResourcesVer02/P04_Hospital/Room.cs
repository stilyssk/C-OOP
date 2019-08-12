using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Room : IRoom
    {
        private int currentRoom;
        private List<string> patient;

        public Room(int currentRoom)
        {
            CurrentRoom = currentRoom;
            this.patient = new List<string>();
            
        }

        public int CurrentRoom { get => currentRoom; set => currentRoom = value; }
        public List<string> Patient { get => patient; set => patient = value; }

        public int RoomCount()
        {
            return this.Patient.Count;
        }

        public void AddPatient(string patient)
        {
            this.Patient.Add(patient);
        }

        public List<string> ListAllPatient()
        {
            return this.Patient;
        }
    }
}
