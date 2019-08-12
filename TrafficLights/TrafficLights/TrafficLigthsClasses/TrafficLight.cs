using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficLights.Classes
{
    public class TrafficLight 
    {
        private List<ILights> traficLight;

        public TrafficLight()
        {
            traficLight = new List<ILights>();
        }

        public List<ILights> TraficLight { get => traficLight; set => traficLight = value; }

        public void AddLight(string light)
        {
            ILights newLight = new Lights(light);
            traficLight.Add(newLight);

        }

        public void rotateLight()
        {
            var firstElement = traficLight[0];
            var lastElement = traficLight[traficLight.Count - 1];
            traficLight.Insert(0, lastElement);
            traficLight.RemoveAt(traficLight.Count - 1);
        }

        public string Print()
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in traficLight)
            {
                result.Append(item.Collor+' ');
            }
            return result.ToString();
        }

        
    }
}
