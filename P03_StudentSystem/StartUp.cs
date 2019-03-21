namespace P03_StudentSystem
{
    using P03_StudentSystem.StudentsClass;
    class StartUp
    {
        static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();
            while (true)
            {
                studentSystem.ParseCommand();
            }
        }
    }
}
