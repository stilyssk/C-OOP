﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        private string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public IReadOnlyCollection<Person> FirstTeam
        {
            get => this.firstTeam;
        }
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get => this.reserveTeam;
        }

        public void AddPlayer(Person person)
        {
            if (person.Age <40)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }
    }
}
