using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Contracts
{
    public class Hotel : IHotel
    {
        private const int Capacity = 10;
        Dictionary<string, IAnimal> Animals;

        public Hotel()
        {
            this.Animals = new Dictionary<string, IAnimal>();
        }

        public IAnimal GetAnimalData(string name)
        {
            return Animals[name];
        }

        public void Accommodate(IAnimal animal)
        {
            if (Capacity<Animals.Count-1)
            {
                throw new InvalidOperationException("Not enough capacity");
            }
            if (Animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal { animal.Name } already exist");
            }
            Animals.Add(animal.Name, animal);
        }

        public void Adopt(string animalName, string owner)
        {
            if (Animals.ContainsKey(animalName))
            {
                Animals[animalName].Owner = owner;
                Animals[animalName].IsAdopt = true;
                Animals.Remove(animalName);
            }
            else
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }
        }
    }
}
