using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Room
    {
        private string[] patient;
        private int ocupateIndex;
        public Room()
        {
            this.ocupateIndex = 0;
            this.patient = new string[3];
        }
        
        public bool CheckEmty()
        {
            if (ocupateIndex<3)
            {
                return true;
            }
   
            return false;
        }

        public void AddPatient(string newPatient)
        {
            
            patient[ocupateIndex] = newPatient;
            ocupateIndex++;
        }

        public List<string> getAllPatientInRoom()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < patient.Length; i++)
            {
                if (patient[i]!=null)
                {
                    result.Add(patient[i]);
                }
            }
            return result;
        }
    }
}
