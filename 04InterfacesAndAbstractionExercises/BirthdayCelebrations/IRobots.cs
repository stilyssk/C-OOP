﻿namespace BorderControl
{
    public interface IRobots
    {
        string Model { get; set; }

        string Id { get; set; }

        string CheckId();
    }
}
