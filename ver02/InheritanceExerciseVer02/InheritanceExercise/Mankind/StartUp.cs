using System;

namespace Mankind
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var readStudentInfo = Console.ReadLine()
                .Split(new[] { ' ' });
            var readWorkerInfo = Console.ReadLine()
                .Split(new[] { ' ' });
            try
            {
                Student student = new Student(readStudentInfo[0], readStudentInfo[1], readStudentInfo[2]);
                Worker worker = new Worker(readWorkerInfo[0], readWorkerInfo[1], double.Parse(readWorkerInfo[2]), double.Parse(readWorkerInfo[3]));
                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
