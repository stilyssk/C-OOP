﻿namespace BirthdayCelebrations.Interfaces.Child
{
    public interface ICitizen : ITownsman
    {
        string Name { get; set; }
        int Age { get; set; }
        ITownsman TownsmanData { get; set; }
    }

}