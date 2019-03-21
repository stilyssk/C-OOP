namespace BorderControl
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Subjectс subjectсs = new Subjectс();
            while (true)
            {
                string inputData = Console.ReadLine();
                if (inputData == "End")
                {
                    break;
                }
                else
                {
                    subjectсs.AddSubject(inputData);
                }
            }
            string inputNumber = Console.ReadLine();
            Console.WriteLine(subjectсs.CheckIdNumber(inputNumber));
        }
    }
}
