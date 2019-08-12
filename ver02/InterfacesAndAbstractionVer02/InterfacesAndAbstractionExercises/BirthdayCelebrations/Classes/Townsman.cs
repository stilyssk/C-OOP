using BirthdayCelebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations.Classes
{
    public class Townsman : ITownsman
    {
        private string iD;

        public Townsman(string iD)
        {
            ID = iD;
        }

        public string ID
        {
            get => iD;
            set => iD = value;
        }
    }
}
