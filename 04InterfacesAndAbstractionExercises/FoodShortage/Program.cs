using System;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            Subjects subjects = new Subjects();
            int repeat = int.Parse(Console.ReadLine());
            int i = 0;
            while (true)
            {
                string inputData = Console.ReadLine();
                if (inputData == "End")
                {
                    break;
                }
                if (i < repeat)
                {
                    subjects.AddSubject(inputData);
                    i++;
                }
                else
                {
                    subjects.BuyFood(inputData);
                }
            }

            Console.WriteLine(subjects.PrintFood());
        }
    }
}
