using System;
using System.Linq;

namespace RhombusOfStars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int inputDimmentinRhombus = int.Parse(Console.ReadLine());
            int countStar = 0;
            for (int i = 1; i < inputDimmentinRhombus*2; i++)
            {
                if (i<=inputDimmentinRhombus)
                {
                    countStar++;
                    PrintRow(countStar, inputDimmentinRhombus + countStar-1);
                }
                else
                {
                    countStar--;

                    PrintRow(countStar, inputDimmentinRhombus + countStar-2);
                }
            }
        }

        static void PrintRow(int countStars, int maxLenth)
        {
            string printString = null;
            //int tempCountStar = countStars;
            bool flagStar = true;
            for (int i = 0; i < maxLenth; i++)
            {
                if (flagStar&& countStars != 0)
                {
                    printString += "*";
                    countStars--;
                    flagStar = false;
                }
                else
                {
                    printString += " ";
                    flagStar = true;
                }
            }
            Console.WriteLine(printString);
            
        }
    }
}
