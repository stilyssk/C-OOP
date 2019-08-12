namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type classType = typeof(BlackBoxInteger);

            BlackBoxInteger blackBox = (BlackBoxInteger)Activator.CreateInstance(classType, true);

            string command = Console.ReadLine();

            while (!command.Equals("END"))
            {
                string[] inputCommand = command.Split('_');
                string methodName = inputCommand[0];
                int passedValue = int.Parse(inputCommand[1]);

                MethodInfo currentMethod = classType.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);

                currentMethod.Invoke(blackBox, new object[] { passedValue });

                string innerValue = classType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).First().GetValue(blackBox).ToString();
                Console.WriteLine(innerValue);

                command = Console.ReadLine();
            }
        }
    }
}
