namespace BorderControl2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Subjectс 
    {
        //private readonly List<Citizen> subjects;

        //public Subjectс()
        //{
        //    this.subjects = new List<Citizen>();
        //}

        public void AddSubject(string inputData)
        {
            var inputDataList = inputData
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            //if (inputDataList.Count == 2)
            //{
            //    Citizen newRobot = new Citizen(inputDataList[0], inputDataList[1]);
            //    this.subjects.Add(newRobot);
            //}
            //else if (inputDataList.Count == 3)
            //{
            //    Citizen newCitizen = new Citizen(inputDataList[0], int.Parse(inputDataList[1]), inputDataList[2]);
            //    this.subjects.Add(newCitizen);
            //}
        }

        public string CheckIdNumber(string idNumber)
        {
            StringBuilder result = new StringBuilder();
            //foreach (var citizen in this.subjects)
            //{
            //    if (citizen.Id.Contains(idNumber))
            //    {
            //        int index = citizen.Id.LastIndexOf(idNumber);
            //        if (index == (citizen.Id.Length - idNumber.Length))
            //        {
            //            result.AppendLine(citizen.Id);
            //        }
            //    }
            //}

            return result.ToString();
        }
    }
}
