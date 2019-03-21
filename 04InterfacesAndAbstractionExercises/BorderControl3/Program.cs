using System;

namespace BorderControl3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Subjects subjectсs = new Subjects();
            while (true)
            {
                string inputData = Console.ReadLine();
                if (inputData == "End")
                {
                    break;
                }
                //else
                //{
                //    subjectсs.AddSubject(inputData);
                //}
            }
            string inputNumber = Console.ReadLine();
            //Console.WriteLine(subjectсs.CheckIdNumber(inputNumber));
        }
    }
}
