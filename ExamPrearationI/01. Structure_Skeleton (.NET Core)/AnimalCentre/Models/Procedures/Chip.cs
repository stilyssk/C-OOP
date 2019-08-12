using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Procedures
{
    public class Chip : Procedure, IChip
    {

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.IsChipped)
            {
                throw new ArgumentException($"{animal.Name} is already chipped");
            }

            animal.ProcedureTime -= procedureTime;

            animal.Happiness -= 5;
            animal.IsChipped = true;



        }
    }
}
