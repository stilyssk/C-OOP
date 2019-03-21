namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Subjects: GetDateTime
    {
        private List<Citizen> subjects;

        public Subjects()
        {
            this.subjects = new List<Citizen>();
        }

        public void AddSubject(string inputData)
        {
            var inputDataList = inputData
                .Split(new[] { ' ' })
                .ToList();
            if (inputDataList[0] == "Robot")
            {
                Citizen newRobot = new Citizen(inputDataList[0], inputDataList[1], inputDataList[2]);
                this.subjects.Add(newRobot);
            }
            else if (inputDataList[0] == "Pet")
            {
                var newDsteTime = GetDateTime.GetDateTimes(inputDataList[2]);
                Citizen newPet = new Citizen(inputDataList[0], inputDataList[1], newDsteTime);
                this.subjects.Add(newPet);
            }
            else if (inputDataList[0] == "Citizen")
            {
                var newDsteTime = GetDateTime.GetDateTimes(inputDataList[4]);
                Citizen newCitizen = new Citizen(inputDataList[0], inputDataList[1], int.Parse(inputDataList[2]), inputDataList[3], newDsteTime);
                this.subjects.Add(newCitizen);
            }
        }

        public string CheckIdNumber(string idNumber)
        {
            StringBuilder result = new StringBuilder();
            foreach (var citizen in this.subjects)
            {
                if (citizen.Id.Contains(idNumber))
                {
                    int index = citizen.Id.LastIndexOf(idNumber);
                    if (index == (citizen.Id.Length - idNumber.Length))
                    {
                        result.AppendLine(citizen.Id);
                    }
                }
            }

            return result.ToString();
        }
        public string CheckDate(DateTime checkYear)
        {
            StringBuilder result = new StringBuilder();
            foreach (var citizen in this.subjects)
            {
                if (citizen.Birthdate.Year==checkYear.Year)
                {
                    result.AppendLine($"{citizen.Birthdate.Day:d2}/{citizen.Birthdate.Month:d2}/{citizen.Birthdate.Year:d4}");

                }
            }

            return result.ToString();
        }

    }
}
