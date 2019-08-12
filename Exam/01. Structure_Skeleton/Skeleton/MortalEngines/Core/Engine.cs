using MortalEngines.Core.Contracts;
using MortalEngines.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MortalEngines.Core
{
    public class Engine : IEngine, IWriter
    {
        public void Run()
        {
            IMachinesManager machinesManager = new MachinesManager();
            var inputCommand = Console.ReadLine();

            while (inputCommand != "Quit")
            {
                var inputCommandList = inputCommand.Split(new string[] { " " }, StringSplitOptions.None).ToList();

                switch (inputCommandList[0])
                {
                    case "HirePilot":
                        Write(machinesManager.HirePilot(inputCommandList[1]));
                        break;
                    case "PilotReport":
                        Write(machinesManager.PilotReport(inputCommandList[1]));
                        break;
                    case "ManufactureTank":
                        Write(machinesManager.ManufactureTank(inputCommandList[1], double.Parse(inputCommandList[2]), double.Parse(inputCommandList[3])));
                        break;
                    case "ManufactureFighter":
                        Write(machinesManager.ManufactureFighter(inputCommandList[1], double.Parse(inputCommandList[2]), double.Parse(inputCommandList[3])));
                        break;
                    case "MachineReport":
                        Write(machinesManager.MachineReport(inputCommandList[1]));
                        break;
                    case "AggressiveMode":
                        Write(machinesManager.ToggleFighterAggressiveMode(inputCommandList[1]));
                        break;
                    case "DefenseMode":
                        Write(machinesManager.ToggleTankDefenseMode(inputCommandList[1]));
                        break;
                    case "Engage":
                        Write(machinesManager.EngageMachine(inputCommandList[1], inputCommandList[2]));
                        break;
                    case "Attack":
                        Write(machinesManager.AttackMachines(inputCommandList[1], inputCommandList[2]));
                        break;

                }
                inputCommand = Console.ReadLine();

            }
        }

        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
