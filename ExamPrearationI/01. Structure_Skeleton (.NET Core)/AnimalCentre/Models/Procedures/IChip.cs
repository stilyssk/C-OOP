using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public interface IChip
    {
        void DoService(IAnimal animal, int procedureTime);
    }
}