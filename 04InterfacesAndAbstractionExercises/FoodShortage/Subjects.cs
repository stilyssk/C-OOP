namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Subjects: GetDateTime
    {
        private List<Citizen> subjects;
        private List<Rebel> rebels;
        private int food;
        public Subjects()
        {
            this.subjects = new List<Citizen>();
            this.rebels = new List<Rebel>();
            this.Food = 0;
        }
        public int Food
        {
            get => this.food;
            set
            {
                this.food = value;
            }
        }
        public void AddSubject(string inputData)
        {
            var inputDataList = inputData
                .Split(new[] { ' ' })
                .ToList();

            if (inputDataList.Count == 4)
            {
                var newDsteTime = GetDateTime.GetDateTimes(inputDataList[3]);
                Citizen newCitizen = new Citizen( inputDataList[0], int.Parse(inputDataList[1]), inputDataList[2], newDsteTime);
                this.subjects.Add(newCitizen);
            }
            if (inputDataList.Count == 3)
            {
                Rebel newrebel = new Rebel(inputDataList[0],int.Parse(inputDataList[1]),inputDataList[2]);
                this.rebels.Add(newrebel);
            }
        }

        public void BuyFood(string name)
        {
            if (subjects.Exists(x=>x.Name==name))
            {
                this.Food += subjects[0].BuyFood();
            }
            else if (rebels.Exists(x=>x.Name == name))
            {
                this.Food += rebels[0].BuyFood();
            }
        }

        public int PrintFood()
        {
            return this.Food;
        }

        //public string CheckIdNumber(string idNumber)
        //{
        //    StringBuilder result = new StringBuilder();
        //    foreach (var citizen in this.subjects)
        //    {
        //        if (citizen.Id.Contains(idNumber))
        //        {
        //            int index = citizen.Id.LastIndexOf(idNumber);
        //            if (index == (citizen.Id.Length - idNumber.Length))
        //            {
        //                result.AppendLine(citizen.Id);
        //            }
        //        }
        //    }

        //    return result.ToString();
        //}
        //public string CheckDate(DateTime checkYear)
        //{
        //    StringBuilder result = new StringBuilder();
        //    foreach (var citizen in this.subjects)
        //    {
        //        if (citizen.Birthdate.Year==checkYear.Year)
        //        {
        //            result.AppendLine($"{citizen.Birthdate.Day:d2}/{citizen.Birthdate.Month:d2}/{citizen.Birthdate.Year:d4}");

        //        }
        //    }

        //    return result.ToString();
        //}

    }
}
