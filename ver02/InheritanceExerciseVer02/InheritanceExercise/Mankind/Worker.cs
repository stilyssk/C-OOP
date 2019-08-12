using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;
        private double moneyByAnHour;
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
            CalculateMoneyByAnHour();
        }

        public double WeekSalary
        {
            get => weekSalary;
            set
            {
                if (value<=10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }
        public double WorkHoursPerDay
        {
            get => workHoursPerDay;
            set
            {
                if (value<1||value>12)
                {
                    throw new AggregateException($"Expected value mismatch! Argument: workHoursPerDay");
                }
                workHoursPerDay = value;
            }
        }
        private double MoneyByAnHour
        {
            get => moneyByAnHour;
            set => moneyByAnHour = value;
        }

        private void CalculateMoneyByAnHour()
        {
            MoneyByAnHour = weekSalary / (WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine($"Week Salary: {WeekSalary:f2}");
            result.AppendLine($"Hours per day: {WorkHoursPerDay:f2}");
            result.AppendLine($"Salary per hour: {MoneyByAnHour:f2}");
            return result.ToString().TrimEnd();
        }
    }
}
