using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Department
    {
        private string name;
        private Room[] rooms;

        public Department(string name)
        {
            this.Name = name;
            this.rooms = new Room[20];
            this.AddNewRooms();
        }

        private void AddNewRooms()
        {

            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new Room();
            }

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public bool AddPatient(string patient)
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i].CheckEmty())
                {
                    rooms[i].AddPatient(patient);
                    return true;
                }
            }
            return false;
        }

        public List<string> printAllPacient()
        {
            var newPateint = new List<string>();
            foreach (var patientInRoom in rooms)
            {

                var newTempPateint = patientInRoom.getAllPatientInRoom();
                foreach (var patient in newTempPateint)
                {
                    newPateint.Add(patient);
                }
            }
            return newPateint;
        }

        public List<string> PrintPatientInRoom (int roomNumber)
        {
            return rooms[roomNumber - 1].getAllPatientInRoom();
        }
    }
}
