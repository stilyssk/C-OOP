using System;
using System.Collections.Generic;
using System.Linq;
using TrafficLights.Classes;

namespace TrafficLights
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            TrafficLight newTrafficLight = new TrafficLight();
            string[] inputLight = Console.ReadLine()
                .Split(new[] { ' ' })
                .ToArray();
            int repeatTime = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLight.Length; i++)
            {
                newTrafficLight.AddLight(inputLight[i]);
            }

            for (int i = 0; i < repeatTime; i++)
            {
                newTrafficLight.rotateLight();
                Console.WriteLine(newTrafficLight.Print());
            }
        }
    }
}
