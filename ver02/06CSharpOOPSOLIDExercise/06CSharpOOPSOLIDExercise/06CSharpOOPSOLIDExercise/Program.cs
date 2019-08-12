using _06CSharpOOPSOLIDExercise.Appenders.Classes;
using _06CSharpOOPSOLIDExercise.Appenders.Interfaces;
using _06CSharpOOPSOLIDExercise.Layouts.Classes;
using _06CSharpOOPSOLIDExercise.Layouts.Interfaces;
using _06CSharpOOPSOLIDExercise.Loggers.Classes;
using _06CSharpOOPSOLIDExercise.Loggers.Interfaces;
using _06CSharpOOPSOLIDExercise.Enums;
using System;
using System.Collections.Generic;
//using static _06CSharpOOPSOLIDExercise.Appenders.Interfaces.testEnum;

namespace _06CSharpOOPSOLIDExercise
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<IAppender> testAppender = new List<IAppender>(); 
            ILayout layout = null;
            ILogFile logFile = new LogFile();
            var repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                IAppender appender = null;

                var inputCommand = Console.ReadLine().Split(' ');
                if (inputCommand[1] == "SimpleLayout")
                {
                    layout = new SimpleLayout();
                }
                if (inputCommand[1] == "XmlLayout")
                {
                    layout = new XmlLayout();
                }

                if (inputCommand[0] == "ConsoleAppender")
                {
                    appender = new ConsoleAppender(layout);
                }
                else if (inputCommand[0] == "FileAppender")
                {
                    appender = new FileAppender(layout, logFile);
                }
                if (inputCommand.Length == 3)
                {
                    foreach (ReportLevel current in Enum.GetValues(typeof(ReportLevel)))
                    {
                        if (current.ToString().ToLower() == inputCommand[2].ToLower())
                        {
                            appender.ReportLevel = current;
                        }
                    }
                }
                testAppender.Add(appender);
            }
            ILogger logger = new Logger(testAppender.ToArray());

            while (true)
            {
                var inputCommand = Console.ReadLine().Split('|');

                if (inputCommand[0] == "END")
                {
                    break;
                }
                switch (inputCommand[0])
                {
                    case "INFO":
                        logger.Info(inputCommand[1], inputCommand[2]);
                        break;
                    case "WARNING":
                        logger.Warning(inputCommand[1], inputCommand[2]);
                        break;
                    case "ERROR":
                        logger.Error(inputCommand[1], inputCommand[2]);
                        break;
                    case "CRITICAL":
                        logger.Critical(inputCommand[1], inputCommand[2]);
                        break;
                    case "FATAL":
                        logger.Fatal(inputCommand[1], inputCommand[2]);
                        break;
                    default:
                        break;
                }

                
            }

        }
    }
}
