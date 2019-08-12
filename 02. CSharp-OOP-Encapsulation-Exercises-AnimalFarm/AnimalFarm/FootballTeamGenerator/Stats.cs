using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Stats
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private double averageStats;
        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.AverageStats=this.CalculateAverageStats();
        }

        private int Endurance
        {
            get => this.endurance;
            set
            {
                CheckInRange0to100(value,nameof(this.Endurance));
                this.endurance = value;
            }
        }
        private int Sprint
        {
            get => this.sprint;
            set
            {
                CheckInRange0to100(value, nameof(this.Sprint));
                this.sprint = value;
            }
        }
        private int Dribble
        {
            get => this.dribble;
            set
            {
                CheckInRange0to100(value, nameof(this.Dribble));
                this.dribble = value;
            }
        }
        private int Passing
        {
            get => passing;
            set
            {
                CheckInRange0to100(value, nameof(this.Passing));
                this.passing = value;
            }
        }
        private int Shooting
        {
            get => this.shooting;
            set
            {
                CheckInRange0to100(value, nameof(this.Shooting));
                this.shooting = value;
            }
        }

        public double AverageStats
        {
            get => this.averageStats;
            set => this.averageStats = value;
        }

        private double CalculateAverageStats()
        {
            return (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
        }
        private void CheckInRange0to100(int inputNumber,string propertyName)
        {
            if (inputNumber < 0 || inputNumber > 100)
            {
                throw new ArgumentException($"{propertyName} should be between 0 and 100.");
            }
        }

    }
}
