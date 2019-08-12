namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Classes;
    using MortalEngines.Entities.Contracts;
    using MortalEngines.Common;
    using System.Collections.Generic;
    using System;

    public class MachinesManager : IMachinesManager
    {
        private List<IPilot> pilotsList;
        private List<IMachine> machineList;
        public MachinesManager()
        {
            this.machineList = new List<IMachine>();
            this.pilotsList = new List<IPilot>();

        }


        public string HirePilot(string name)
        {

            if (pilotsList.Exists(x=>x.Name==name))
            {
                return String.Format(OutputMessages.PilotExists, name);
            }
            else
            {
                IPilot pilot = new Pilot(name);
                pilotsList.Add(pilot);
                return String.Format(OutputMessages.PilotHired, name);

            }
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (machineList.Exists(x=>x.Name==name))
            {
                return String.Format(OutputMessages.MachineExists, name);
            }
            else
            {
                ITank machine = new Tank(name,attackPoints,defensePoints);
                machineList.Add(machine);
                return String.Format(OutputMessages.TankManufactured, machine.Name,machine.AttackPoints,machine.DefensePoints);

            }
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (machineList.Exists(x=>x.Name==name))
            {
                return String.Format(OutputMessages.FighterManufactured, name);

            }
            else
            {
                IFighter machine = new Fighter(name, attackPoints, defensePoints);
                machineList.Add(machine);
                var agresiveModeOnOff = "";
                if (machine.AggressiveMode)
                {
                    agresiveModeOnOff = "ON";
                }
                else
                {
                    agresiveModeOnOff = "OFF";
                }
                return String.Format(OutputMessages.FighterManufactured, machine.Name, machine.AttackPoints, machine.DefensePoints,agresiveModeOnOff);
            }
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            if (!pilotsList.Exists(x => x.Name == selectedPilotName))
            {
                return String.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }
            if (!machineList.Exists(x => x.Name == selectedMachineName))
            {
                return String.Format(OutputMessages.MachineNotFound, selectedMachineName);

            }
            var index = machineList.FindIndex(x => x.Name == selectedMachineName);
            if (machineList[index].Pilot != null)
            {
                return String.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);

            }
            else
            {
                var indexPilot = pilotsList.FindIndex(x => x.Name == selectedPilotName);
                machineList[index].Pilot = pilotsList[indexPilot];
                return String.Format(OutputMessages.MachineEngaged, selectedPilotName, selectedMachineName);
            }
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            if (!machineList.Exists(x => x.Name == attackingMachineName))
            {
                return String.Format(OutputMessages.MachineNotFound, attackingMachineName);

            }
            if (!machineList.Exists(x => x.Name == defendingMachineName))
            {
                return String.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }
            var indexAttackingMachine = machineList.FindIndex(x => x.Name == attackingMachineName);
            if (machineList[indexAttackingMachine].HealthPoints < 0)
            {
                return String.Format(OutputMessages.DeadMachineCannotAttack, attackingMachineName);

            }
            var indexDefendingMachine = machineList.FindIndex(x => x.Name == defendingMachineName);
            if (machineList[indexDefendingMachine].HealthPoints<0)
            {
                return String.Format(OutputMessages.DeadMachineCannotAttack, defendingMachineName);

            }
            machineList[indexAttackingMachine].Attack(machineList[indexDefendingMachine]);
            machineList[indexAttackingMachine].Targets.Add(defendingMachineName);
            return String.Format(OutputMessages.AttackSuccessful,  defendingMachineName, attackingMachineName, machineList[indexDefendingMachine].HealthPoints);


        }

        public string PilotReport(string pilotReporting)
        {
            var index = pilotsList.FindIndex(x => x.Name == pilotReporting);
            return pilotsList[index].Report();
        }

        public string MachineReport(string machineName)
        {
            var index = machineList.FindIndex(x => x.Name == machineName);
            return machineList[index].ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if (machineList.Exists(x=>x.Name==fighterName))
            {
                return String.Format(OutputMessages.FighterOperationSuccessful, fighterName);
            }
            else
            {
                return String.Format(OutputMessages.MachineNotFound, fighterName);

            }
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            if (machineList.Exists(x => x.Name == tankName))
            {
                var index = machineList.FindIndex(x => x.Name == tankName);
                var test = (ITank)machineList[index];
                test.ToggleDefenseMode();
                machineList[index] = test;
                return String.Format(OutputMessages.TankOperationSuccessful, tankName);

            }
            else
            {
                return String.Format(OutputMessages.MachineNotFound, tankName);

            }
        }
    }
}