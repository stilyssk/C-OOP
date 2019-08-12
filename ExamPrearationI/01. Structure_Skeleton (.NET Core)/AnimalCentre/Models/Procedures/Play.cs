using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Procedures
{
    public class Play : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            animal.ProcedureTime -= procedureTime;
            animal.Energy -= 6;
            animal.Happiness += 12;

        }
    }
}
