namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string UnitsFolder = "Units";
        public IUnit CreateUnit(string unitType)
        {
            string unitsNamespace = Assembly
                 .GetExecutingAssembly()
                 .GetTypes()
                 .Select(t => t.Namespace)
                 .Distinct()
                 .Where(n => n != null)
                 .FirstOrDefault(n => n.Contains(UnitsFolder));

            Type typeOfUnit = Type.GetType($"{unitsNamespace}.{unitType}");
            IUnit instanceOfUnit = (IUnit)Activator.CreateInstance(typeOfUnit);

            return instanceOfUnit;
            //TODO: implement for Problem 3
            //throw new NotImplementedException();
        }
    }
}
