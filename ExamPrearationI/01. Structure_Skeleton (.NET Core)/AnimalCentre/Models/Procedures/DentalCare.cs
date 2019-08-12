﻿using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Procedures
{
    public class DentalCare : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            animal.ProcedureTime -= procedureTime;
            animal.Happiness += 12;
            animal.Energy += 10;

        }
    }
}
