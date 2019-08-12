namespace P03_StudentSystem
{
    class StartUp
    {
        static void Main()
        {
            IStudentSystem studentSystem = new StudentSystem();
            while (true)
            {
                System.Console.Write(studentSystem.ParseCommand());
                if (studentSystem.Exit)
                {
                    break;
                }
            }
        }
    }
}
