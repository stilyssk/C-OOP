using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Department : IDepartment
    {
        private string name;
        private List<IRoom> rooms;

        public Department(string name)
        {
            Name = name;
            this.Rooms = new List<IRoom>();
            NewDepartment();
        }

        public List<IRoom> Rooms { get => rooms; set => rooms = value; }
        public string Name { get => name; set => name = value; }

        public void NewDepartment()
        {
            for (int i = 0; i < 20; i++)
            {
                this.Rooms.Add(new Room(i));
            }
        }

        public int CountOcupate()
        {
            int count = 0;
            foreach (var currentRoom in this.Rooms)
            {
                count += currentRoom.RoomCount();
            }
            return count;
        }

        public List<string> ListAllPatientInDepartment()
        {
            var allPatietnInDepartment = new List<string>();
            foreach (var currentRoom in this.Rooms)
            {
                foreach (var patient in currentRoom.ListAllPatient())
                {
                    allPatietnInDepartment.Add(patient);
                }
 
            }
            return allPatietnInDepartment;
        }
    }
}
