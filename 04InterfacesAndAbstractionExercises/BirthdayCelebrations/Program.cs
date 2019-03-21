using System;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            Subjects subjects = new Subjects();
            while (true)
            {
                string inputData = Console.ReadLine();
                if (inputData == "End")
                {
                    break;
                }
                else
                {
                    subjects.AddSubject(inputData);
                }
            }
            
            int inputNumber = int.Parse(Console.ReadLine());
            var newDsteTime = new DateTime(inputNumber, 1, 1);

            Console.Write(subjects.CheckDate(newDsteTime));
        }
    }
}
