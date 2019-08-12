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
            pilotsList = new List<IPilot>();
            this.machineList = new List<IMachine>();
            this.pilotsList = new List<IPilot>();

        }
        private List<IPilot> PilotsList
        {
            get
            {
                return this.pilotsList;
            }
            set
            {
                this.pilotsList = value;
            }
        }
        private List<IMachine> MachineList
        {
            get
            {
                return this.machineList;
            }
            set
            {
                this.machineList = value;
            }
        }
        public string HirePilot(string name)
        {

            if (PilotsList.Exists(x=>x.Name==name))
            {
                return String.Format(OutputMessages.PilotExists, name);
            }
            else
            {
                IPilot pilot = new Pilot(name);
                PilotsList.Add(pilot);
                return String.Format(OutputMessages.PilotHired, name);

            }
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (MachineList.Exists(x=>x.Name==name))
            {
                return String.Format(OutputMessages.MachineExists, name);
            }
            else
            {
                IMachine machine = new Tank(name,attackPoints,defensePoints);
                MachineList.Add(machine);
                return String.Format(OutputMessages.TankManufactured, machine.Name,machine.AttackPoints,machine.DefensePoints);

            }
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (MachineList.Exists(x=>x.Name==name))
            {
                return String.Format(OutputMessages.FighterManufactured, name);

            }
            else
            {
                IFighter machine = new Fighter(name, attackPoints, defensePoints);
                MachineList.Add(machine);
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
            if (!PilotsList.Exists(x => x.Name == selectedPilotName))
            {
                return String.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }
            if (!MachineList.Exists(x => x.Name == selectedMachineName))
            {
                return String.Format(OutputMessages.MachineNotFound, selectedMachineName);

            }
            var index = MachineList.FindIndex(x => x.Name == selectedMachineName);
            if (machineList[index].Pilot != null)
            {
                return String.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);

            }
            else
            {
                var indexPilot = PilotsList.FindIndex(x => x.Name == selectedPilotName);
                machineList[index].Pilot = PilotsList[indexPilot];
                return String.Format(OutputMessages.MachineEngaged, selectedPilotName, selectedMachineName);
            }
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            if (!MachineList.Exists(x => x.Name == attackingMachineName))
            {
                return String.Format(OutputMessages.MachineNotFound, attackingMachineName);

            }
            if (!MachineList.Exists(x => x.Name == defendingMachineName))
            {
                return String.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }
            var indexAttackingMachine = MachineList.FindIndex(x => x.Name == attackingMachineName);
            if (MachineList[indexAttackingMachine].HealthPoints < 0)
            {
                return String.Format(OutputMessages.DeadMachineCannotAttack, attackingMachineName);

            }
            var indexDefendingMachine = MachineList.FindIndex(x => x.Name == defendingMachineName);
            if (MachineList[indexDefendingMachine].HealthPoints<0)
            {
                return String.Format(OutputMessages.DeadMachineCannotAttack, defendingMachineName);

            }
            MachineList[indexAttackingMachine].Attack(MachineList[indexDefendingMachine]);

            MachineList[indexAttackingMachine].Targets.Add(defendingMachineName);
            return String.Format(OutputMessages.AttackSuccessful,  defendingMachineName, attackingMachineName, MachineList[indexDefendingMachine].HealthPoints);


        }

        public string PilotReport(string pilotReporting)
        {
            var index = PilotsList.FindIndex(x => x.Name == pilotReporting);
            return PilotsList[index].Report();
        }

        public string MachineReport(string machineName)
        {
            var index = MachineList.FindIndex(x => x.Name == machineName);
            return MachineList[index].ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if (MachineList.Exists(x=>x.Name==fighterName))
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
            if (MachineList.Exists(x => x.Name == tankName))
            {
                var index = MachineList.FindIndex(x => x.Name == tankName);
                var test = (ITank)MachineList[index];
                test.ToggleDefenseMode();
                MachineList[index] = test;
                return String.Format(OutputMessages.TankOperationSuccessful, tankName);

            }
            else
            {
                return String.Format(OutputMessages.MachineNotFound, tankName);

            }
        }
    }
}