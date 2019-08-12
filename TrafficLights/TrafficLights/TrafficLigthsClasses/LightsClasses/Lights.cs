using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TrafficLights
{
    public class Lights //: ILights
    {
        //private string collor;
        private List<string> lightCollor;
        private string currentLight;
        private int index;

        public Lights(string inputCollor)
        {
            this.lightCollor = new List<string>
            {
            "Green", "Red", "Yellow"
            };
            this.AddLight = inputCollor;
        }

        private string AddLight
        {

            set
            {
                int indexOfLight = this.lightCollor.IndexOf(value);
                if (indexOfLight!=-1)
                {
                    this.index = indexOfLight;
                }
                else
                {
                    throw new ArgumentException("Insert correct light");
                }

            }
        }

        public void RotateLight()
        {
            if (this.lightCollor.Count-1<this.index+1)
            {
                this.index++;
            }
            else
            {
                this.index = 0;
            }
        }

    }
}
