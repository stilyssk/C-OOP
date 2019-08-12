using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Factory
{
    public class FactoryClass : IFactoryClass
    {
        public List<string> CreateBaseMashineTargetList()
        {
            return new List<string>();
        }
    }
}
