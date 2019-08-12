using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Procedures
{
    public class Fitness : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            animal.ProcedureTime -= procedureTime;
            animal.Happiness -= 3;
            animal.Energy += 10;

        }
    }
}
