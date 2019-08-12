namespace P01_RawData.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine : IEngine
    {
        private int engineSpeed;
        private int enginePower;

        public int EngineSpeed { get => engineSpeed; set => engineSpeed = value; }
        public int EnginePower { get => enginePower; set => enginePower = value; }

        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
    }
}
