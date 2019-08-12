namespace P01_RhombusOfStars
{
    using System;
    using System.Text;
    class StartUp
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            int sizeRhombus = int.Parse(Console.ReadLine());
            for (int i = 0; i < sizeRhombus*2-1; i++)
            {
                result.AppendLine(PrintRow(sizeRhombus, i));
            }
            Console.WriteLine(result);
        }

        static string PrintRow(int sizeRhumbos, int row)
        {
            StringBuilder result = new StringBuilder();
            int tempRow = row + 1;
            if (sizeRhumbos<tempRow)
            {
                tempRow = sizeRhumbos*2-1 - row;
                
            }
            int numberSpace = sizeRhumbos - tempRow;

            result.Append(' ', numberSpace);
            for (int i = 0; i < tempRow; i++)
            {
                result.Append("* ");
            }
            return result.ToString();
        }
    }
}
