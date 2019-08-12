using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;
using AnimalCentre.Models.Procedures;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre
{
    public class AnimalCentre 
    {
        Hotel hotel;
        public AnimalCentre()
        {
            hotel = new Hotel();
        }

        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            IAnimal newAnimal;
            if (type == "Cat")
            {
                 newAnimal= new Cat(name, energy, happiness, procedureTime);
            }
            else if (type == "Dog")
            {
                newAnimal = new Cat(name, energy, happiness, procedureTime);

            }
            else if (type== "Lion")
            {
                newAnimal = new Lion(name, energy, happiness, procedureTime);

            }
            else if (type == "Pig")
            {
                newAnimal = new Pig(name, energy, happiness, procedureTime);

            }
            else
            {
                throw new ArgumentException("oo");
            }

            hotel.Accommodate(newAnimal);
            return $"Animal {newAnimal.Name} registered successfully";
            
        }

        public string Chip(string name, int procedureTime)
        {
            IChip chip = new Chip();
            chip.DoService(hotel.GetAnimalData(name), procedureTime);
            return $"{name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string Fitness(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string Play(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string DentalCare(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string NailTrim(string name, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public string Adopt(string animalName, string owner)
        {
            throw new NotImplementedException();
        }

        public string History(string type)
        {
            throw new NotImplementedException();
        }
    }
}
