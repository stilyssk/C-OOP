namespace BorderControl
{
    using System;

    public interface ICitizens
    {
        string Name { get; set; }

        int Age { get; set; }

        string Id { get; set; }

        DateTime Birthdate { get; set; }

    }
}
